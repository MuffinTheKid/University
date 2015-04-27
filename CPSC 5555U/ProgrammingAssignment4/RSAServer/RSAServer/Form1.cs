using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Numerics;

namespace RSAServer
{
    public enum MODE { START , STOP };
    public partial class RSAServer : Form
    {
  
        private MODE mode;
        public RSAServer()
        {
            InitializeComponent();
        }

        public void createListener()
        {
            //create TcpListener
            #region TcpListener creation and start up
            TcpListener tcpListener = null;
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            serverIPBox.Text = "127.0.0.1";
            Application.DoEvents();
            try
            {
                //Set the IPAddress and port of the listener
                tcpListener = new TcpListener(ipAddress, 13000);
                //Start the listener
                tcpListener.Start();
                infoBox.Text += "waiting for a connection..." + "\r\n";
                Application.DoEvents();
            }
            catch(Exception e)
            {
                //reporting any caught errors
                infoBox.Text += "Error Caught::" + "\r\n";
                infoBox.Text += "########################" + "\r\n";
                infoBox.Text += e.ToString() + "\r\n";
                infoBox.Text += "########################" + "\r\n";
                Application.DoEvents();
            }
            #endregion

            while(true)
            {
                //switch case engine that starts or stops the server
                #region Server engine
                //Sleep call ensures cpu locking is avoided
                Thread.Sleep(10);
                //Create a TcpClient to read data sent from server
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                //Checking if there is a client connected
                if (mode == MODE.STOP)
                {
                    infoBox.Text += "Server stopping...";
                    Application.DoEvents();
                    break;
                }

                if (tcpClient.Connected)
                {
                    //read data from client
                    byte[] bytes = new byte[256];
                    NetworkStream stream = tcpClient.GetStream();
                    stream.Read(bytes, 0, bytes.Length);
                    SocketHelper helper = new SocketHelper();
                    string keyPacket = helper.processMsg(tcpClient, stream, bytes);
                    infoBox.Text += keyPacket;
                    Application.DoEvents();
                    bytes = new byte[256];
                    stream.Read(bytes, 0, bytes.Length);
                    string mess = helper.processMsg(tcpClient, stream, bytes);
                    System.IO.File.WriteAllText("message.txt", mess);
                    infoBox.Text += mess;
                    Application.DoEvents();
                    break;
                }
                else
                {
                    infoBox.Text += "No connection yet..." + "\r\n";
                    Application.DoEvents();
                    break;
                }
                #endregion
            }
        }

        private void startServer_Click(object sender, EventArgs e)
        {
            mode = MODE.START;
            this.createListener();
        }

        private void stopServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = MODE.STOP;
        }

        private void clearInfoBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoBox.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }
    }
}
