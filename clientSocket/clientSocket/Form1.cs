﻿using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

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

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //A socket object is created
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);
            clientSocket = socket;

            //Connect to server
            try
            {
                socket.Connect(IPAddress.Parse(textBoxIP.Text), int.Parse(textBoxPort.Text));
                textBoxDisplay.AppendText("Connected to the server");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            //Send and Receive server
            Thread thread = new Thread(new ParameterizedThreadStart(receiveData));
            thread.IsBackground = true;
            thread.Start(clientSocket);
        }

        public void receiveData(object socket)
        {
            var proxSocket = socket as Socket;
            byte[] data = new byte[1024 * 1024];
            while (true)
            {
                int length = 0;
                try
                {
                    length = proxSocket.Receive(data, 0, data.Length, SocketFlags.None);
                }
                catch (Exception)
                {
                    //not normal quit
                    this.appendTextToLog(string.Format("\r\nServer abnormally quits!\n"));
                    stopConnect();
                    return;
                }

                //display the receieved data into the textBox
                if (length <= 0)
                {
                    //the client quits
                    this.appendTextToLog(string.Format("\r\nServer normally quits!\n"));
                    stopConnect();
                    return;
                }

                //pre-process the received data
                //The first byte has two types:
                //1. string; 2. file
                int type = data[0];
                if (type == 1)
                {
                    processingText(data);
                }
                else if(type == 2)
                {
                    processingFile(data,length);
                }
            }
        }
        
        public void processingFile(byte[] data, int length)
        {
            using (SaveFileDialog sFile = new SaveFileDialog())
            {
                sFile.Filter = "text file(*.txt)|*.txt|picture(*jpg)|*.jpg|word(*docx)|*docx|all file(*.*)|*.*";
                if (sFile.ShowDialog(this) != DialogResult.OK)
                    return;

                byte[] storedData = new byte[length - 1];
                Buffer.BlockCopy(data, 1, storedData, 0, length - 1);

                File.WriteAllBytes(sFile.FileName, storedData);
            }
        }

        public void processingText(byte[] data)
        {
            string receivedData = Encoding.Default.GetString(data, 1, data.Length-1);
            this.appendTextToLog(string.Format("\r\nRecived massage: {0}", receivedData));
        }

        public void stopConnect()
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

        public void appendTextToLog(string text)
        {
            if (textBoxDisplay.InvokeRequired)
            {
                textBoxDisplay.Invoke(new Action<string>(s => {
                    textBoxDisplay.AppendText(s);
                }), text);
            }
            else
            {
                textBoxDisplay.AppendText(text);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if(clientSocket.Connected)
            {
                byte[] data = Encoding.Default.GetBytes(textBoxSend.Text);
                textBoxDisplay.AppendText(string.Format("\r\nMessage Sent: {0}", textBoxSend.Text));
                clientSocket.Send(data, 0, data.Length, SocketFlags.None);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopConnect();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            stopConnect();
        }
    }
}