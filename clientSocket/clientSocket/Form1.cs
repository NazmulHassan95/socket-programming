using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace clientSocket
{
    public partial class Form1 : Form
    {
        public Socket clientSocket;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        //the connection between the server and the client starts here by a request from client
        private void ClickToConnect(object sender, EventArgs e)
        {
            //a socketClient object is created. it is the base of socket programming
            Socket socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);
            clientSocket = socketClient;

            //connect to server
            try
            {
                socketClient.Connect(IPAddress.Parse(IpAddTextBox.Text), int.Parse(PortToConnectTextBox.Text));
                DisplayMsgBoxText.AppendText("Connected to the server");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            //send to and receive from the server
            Thread thread = new Thread(new ParameterizedThreadStart(getDataFromServer));
            thread.IsBackground = true;
            thread.Start(clientSocket);
        }

        //gets a limited text from server
        public void getDataFromServer(object socket)
        {
            var SocketValueForProxy = socket as Socket;
            byte[] data = new byte[1024 * 1024];
            while (true)
            {
                int length = 0;
                try
                {
                    length = SocketValueForProxy.Receive(data, 0, data.Length, SocketFlags.None);
                }
                catch (Exception)
                {
                    //server does not normaly quit 
                    this.AddTextToTheEndOfLogs(string.Format("\r\nServer down suddenly!\n"));
                    ConnectiongToServerDown();
                    return;
                }

                //displays the data from server
                if (length <= 0)
                {
                    //the client quits
                    this.AddTextToTheEndOfLogs(string.Format("\r\nServer down normally.\n"));
                    ConnectiongToServerDown();
                    return;
                }

                //pre-process the received data
                //The first byte has two types:1. string; 2. file
                int type = data[0];
                if (type == 1)
                {
                    TextTypeAnalys(data);
                }
                else if(type == 2)
                {
                    FileTransferProc(data,length);
                }
            }
        }
        
        //save the file that the servers sends
        public void FileTransferProc(byte[] data, int length)
        {
            using (SaveFileDialog sFile = new SaveFileDialog())
            {
                sFile.Filter = /*text file(*.txt)|*.txt|picture(*jpg)|*.jpg|...*/"all file(*.*)|*.*";
                if (sFile.ShowDialog(this) != DialogResult.OK)
                    return;

                byte[] ByteDataTransfer = new byte[length - 1];
                Buffer.BlockCopy(data, 1, ByteDataTransfer, 0, length - 1);

                File.WriteAllBytes(sFile.FileName, ByteDataTransfer);
            }
        }

        //print the message that client recieves in message box
        public void TextTypeAnalys(byte[] data)
        {
            string DataFromServer = Encoding.Default.GetString(data, 1, data.Length-1);
            this.AddTextToTheEndOfLogs(string.Format("\r\nRecived massage: {0}", DataFromServer));
        }

        //end the connection to the server and close the socket
        public void ConnectiongToServerDown()
        {
            try
            {
                if (clientSocket.Connected)
                {
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close(5);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        //add any text to the end of log
        public void AddTextToTheEndOfLogs(string text)
        {
            if (DisplayMsgBoxText.InvokeRequired)
            {
                DisplayMsgBoxText.Invoke(new Action<string>(s => {
                    DisplayMsgBoxText.AppendText(s);
                }), text);
            }
            else
            {
                DisplayMsgBoxText.AppendText(text);
            }
        }

        //send message function and show in display message box
        private void ClickToSend_Button(object sender, EventArgs e)
        {
            if(clientSocket.Connected)
            {
                byte[] data = Encoding.Default.GetBytes(SendMsgToServerBoxText.Text);
                DisplayMsgBoxText.AppendText(string.Format("\r\nMessage Sent: {0}", SendMsgToServerBoxText.Text));
                clientSocket.Send(data, 0, data.Length, SocketFlags.None);
            }
        }
        
        //function to close the main form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConnectiongToServerDown();
        }
        
        //function to close the connection to server
        private void ClickToCloseButton(object sender, EventArgs e)
        {
            ConnectiongToServerDown();
        }
    }
}