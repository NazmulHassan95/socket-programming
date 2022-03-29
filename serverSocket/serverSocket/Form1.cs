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
        List<Socket> ClientSocketsList = new List<Socket>();
        public Server()
        {
            InitializeComponent();
            string IPaddress = GetLocalIP();
            textBoxDisplay.AppendText(string.Format("The server's IP is {0}", IPaddress));
            labelIP.Text = IPaddress;
        }

        private void buttonService_Click(object sender, EventArgs e)
        {
            //A socket object is created
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);

            //A port is assigned
            socket.Bind(new IPEndPoint(IPAddress.Parse(labelIP.Text), int.Parse(textBoxPort.Text)));

            //Start listening for 1 client to connect
            socket.Listen(1);
            textBoxDisplay.AppendText("\r\nstart linstening...");

            //Accept the cilent's require
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.AcceptClientConnect),socket);
        }

        public void AcceptClientConnect(object socket)
        {
            var serverSocket = socket as Socket;

                var proxSocket = serverSocket.Accept();
                this.appendTextToLog(string.Format("\r\nThe client {0} is connected", proxSocket.RemoteEndPoint.ToString()));
                ClientSocketsList.Add(proxSocket);

                //keep receving client's message
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.receiveClientData),proxSocket);
        }

        public void receiveClientData(object socket)
        {
            var proxSocket = socket as Socket;
            byte[] data = new byte[1024 * 1024]; // Maximum of text message is 1MB!
            while(true)
            {
                int length = 0;
                try
                {
                    length = proxSocket.Receive(data, 0, data.Length, SocketFlags.None);
                }
                catch(Exception)
                {
                    //not normal quit
                    this.appendTextToLog(string.Format("\r\n {0} Abnormally quits!", proxSocket.RemoteEndPoint.ToString()));
                    ClientSocketsList.Remove(proxSocket);
                    stopConnect(proxSocket);
                    return; //end this thread
                }

                //display the receieved data into the textBox
                if(length <= 0)
                {
                    //the client quits
                    this.appendTextToLog(string.Format("\r\n{0} normally quits!\n", proxSocket.RemoteEndPoint.ToString()));
                    ClientSocketsList.Remove(proxSocket);
                    stopConnect(proxSocket);
                    return; //end this thread
                }

                string receivedData = Encoding.Default.GetString(data, 0, length);
                this.appendTextToLog(string.Format("\r\nRecived massage from: {0}  {1}", proxSocket.RemoteEndPoint.ToString(),
                    receivedData));
            }
        }

        public void stopConnect(object socket)
        {
            var proxSocket = socket as Socket;
            try
            {
                if (proxSocket.Connected)
                {
                    proxSocket.Shutdown(SocketShutdown.Both);
                    proxSocket.Close(10);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void appendTextToLog(string text)
        {
            if(textBoxDisplay.InvokeRequired)
            {
                textBoxDisplay.Invoke(new Action<string>(s => {
                    textBoxDisplay.AppendText(s);
                    ///textBoxDisplay.Text = string.Format("{0}\r\n{1}", s, textBoxDisplay.Text);
                }), text);
            }
            else
            {
                textBoxDisplay.AppendText(text);
            }
        }

        public string GetLocalIP()
        {
            try
            {
                string HostName = Dns.GetHostName(); //get the name of localhost
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //IPv4 type labelServerIP addresses is used.
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

        private void buttonSend_Click(object sender, EventArgs e)
        {
            foreach(var proxSocket in ClientSocketsList)
            {
                if(proxSocket.Connected)
                {
                    byte[] data1 = Encoding.Default.GetBytes(textBoxSend.Text.ToString());
                    textBoxDisplay.AppendText(string.Format("\r\nMessage sent: {0}",textBoxSend.Text));
                    byte[] final = new byte[data1.Length + 1];
                    final[0] = 1;
                    Buffer.BlockCopy(data1, 0, final, 1, data1.Length);
                    proxSocket.Send(final, 0, final.Length,SocketFlags.None);
                }
            }
        }

        private void buttonFlash_Click(object sender, EventArgs e)
        {
            foreach (var proxSocket in ClientSocketsList)
            {
                if (proxSocket.Connected)
                {
                    proxSocket.Send(new byte[] {2}, SocketFlags.None);
                }
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            //1. select a file
            using (OpenFileDialog file = new OpenFileDialog())
            {
                if (file.ShowDialog() != DialogResult.OK)
                    return;
                byte[] fileData = File.ReadAllBytes(file.FileName);

                byte[] final = new byte[fileData.Length + 1];
                final[0] = 2;
                Buffer.BlockCopy(fileData, 0, final, 1, fileData.Length);

                foreach (var proxSocket in ClientSocketsList)
                {
                    if (proxSocket.Connected)
                    {
                        proxSocket.Send(final, SocketFlags.None);
                    }
                }

            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {

        }

        private void Server_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void lableServerPort_Click(object sender, EventArgs e)
        {

        }
        //private void buttonClose_Click(object sender, object socket, EventArgs e)
        //{
        //    var proxSocket = socket as Socket;
        //    stopConnect(proxSocket);
        //}
    }
}