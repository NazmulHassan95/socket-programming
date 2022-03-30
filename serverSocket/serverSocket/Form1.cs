using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace serverSocket
{
    public partial class Server : Form
    {
        List<Socket> ClientSockets = new List<Socket>();
        public Server()
        {
            InitializeComponent();
            string IPaddress = ServerIPAddress();
            DisplayMessagesTextBox.AppendText(string.Format("The server's IP is {0}", IPaddress));
            IPAddLable.Text = IPaddress;
        }
        
        //listen for client to connect to server
        private void buttonService_Click(object sender, EventArgs e)
        {
            //a socket object is created
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);

            //a port is assigned
            socket.Bind(new IPEndPoint(IPAddress.Parse(IPAddLable.Text), int.Parse(PortOfServerTextBox.Text)));

            //start listening for a client to connect
            socket.Listen(1);
            DisplayMessagesTextBox.AppendText("\r\nstart linstening...");

            //accept the cilent's require
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.AcceptConnectionRequestFromClient),socket);
        }
        
        //accept the request from client and show the message about that
        public void AcceptConnectionRequestFromClient(object socket)
        {
            var serverSocket = socket as Socket;
            var proxSocket = serverSocket.Accept();
            this.AddMessagetoLog(string.Format("\r\nThe client {0} is connected", proxSocket.RemoteEndPoint.ToString()));
            ClientSockets.Add(proxSocket);
            
            //keep receving client's message
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.AcceptDataFromClient),proxSocket);
        }
        
        //analys the message and decide to accept it or not
        public void AcceptDataFromClient(object socket)
        {
            var SocketForProxy = socket as Socket;
            byte[] TransmissionData = new byte[1024 * 1024];
            while(true)
            {
                int length = 0;
                try
                {
                    length = SocketForProxy.Receive(TransmissionData, 0, TransmissionData.Length, SocketFlags.None);
                }
                catch(Exception)
                {
                    //not normal quit
                    this.AddMessagetoLog(string.Format("\r\n {0} quits suddenly!", SocketForProxy.RemoteEndPoint.ToString()));
                    ClientSockets.Remove(SocketForProxy);
                    stopConnect(SocketForProxy);
                    return; //end this thread
                }

                //display the receieved TransmissionData into the textBox
                if(length <= 0)
                {
                    //the client quits
                    this.AddMessagetoLog(string.Format("\r\n{0} normally quits.\n", SocketForProxy.RemoteEndPoint.ToString()));
                    ClientSockets.Remove(SocketForProxy);
                    stopConnect(SocketForProxy);
                    return; //end this thread
                }

                string receivedData = Encoding.Default.GetString(TransmissionData, 0, length);
                this.AddMessagetoLog(string.Format("\r\nRecived massage from: {0}  {1}", SocketForProxy.RemoteEndPoint.ToString(),
                    receivedData));
            }
        }
        
        //end the connection between server and client
        public void stopConnect(object socket)
        {
            var SocketProxyValue = socket as Socket;
            try
            {
                if (SocketProxyValue.Connected)
                {
                    SocketProxyValue.Shutdown(SocketShutdown.Both);
                    SocketProxyValue.Close(10);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //it adds the new logs to the end of current log and show as me message
        public void AddMessagetoLog(string text)
        {
            if(DisplayMessagesTextBox.InvokeRequired)
            {
                DisplayMessagesTextBox.Invoke(new Action<string>(s => {
                    DisplayMessagesTextBox.AppendText(s);
                }), text);
            }
            else
            {
                DisplayMessagesTextBox.AppendText(text);
            }
        }

        //IP address is very important in any connection types
        public string ServerIPAddress()
        {
            try
            {
                string HostName = Dns.GetHostName(); //get the name of localhost
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //IPv4 type IPAddressofServer addresses is used.
                    //AddressFamily.InterNetwork represents IPv4 (while AddressFamily.InterNetworkV6 represents IPv6)
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        return IpEntry.AddressList[i].ToString();
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting local IP:" + ex.Message);
                return "";
            }
        }

        //send message to the connected client
        private void ClickSend(object sender, EventArgs e)
        {
            foreach(var proxSocket in ClientSockets)
            {
                if(proxSocket.Connected)
                {
                    byte[] TransmissionData = Encoding.Default.GetBytes(SendingMessageTextBox.Text.ToString());
                    DisplayMessagesTextBox.AppendText(string.Format("\r\nMessage sent: {0}",SendingMessageTextBox.Text));
                    byte[] final = new byte[TransmissionData.Length + 1];
                    final[0] = 1;
                    Buffer.BlockCopy(TransmissionData, 0, final, 1, TransmissionData.Length);
                    proxSocket.Send(final, 0, final.Length,SocketFlags.None);
                }
            }
        }

        //server peeks for incomming messages
        private void FlashSend(object sender, EventArgs e)
        {
            foreach (var proxSocket in ClientSockets)
            {
                if (proxSocket.Connected)
                {
                    proxSocket.Send(new byte[] {2}, SocketFlags.None);
                }
            }
        }
        
        //send a file to client
        private void SendAFileToClient(object sender, EventArgs e)
        {
            //select a file
            using (OpenFileDialog file = new OpenFileDialog())
            {
                if (file.ShowDialog() != DialogResult.OK)
                    return;
                byte[] fileData = File.ReadAllBytes(file.FileName);

                byte[] final = new byte[fileData.Length + 1];
                final[0] = 2;
                Buffer.BlockCopy(fileData, 0, final, 1, fileData.Length);

                foreach (var proxSocket in ClientSockets)
                {
                    if (proxSocket.Connected)
                    {
                        proxSocket.Send(final, SocketFlags.None);
                    }
                }

            }
        }
    }
}