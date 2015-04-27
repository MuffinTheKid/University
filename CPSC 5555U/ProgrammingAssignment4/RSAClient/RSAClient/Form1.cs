using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Numerics;
using System.Net;
using System.Threading;

namespace RSAClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendMessage_Click(object sender, EventArgs e)
        {
            this.Connect(serverIpAddress.Text, messageBox.Text);
        }

        private void Connect(string ServerIP, string Message)
        {
            try
            {
                //Creates a TcpClient on a specific address and port
                TcpClient client = new TcpClient(ServerIP, 13000);

                //Initiate communication with the Server
                byte[] data = new byte[256];
                data = Encoding.ASCII.GetBytes("hello");
                //Get client's NetworkStream for reading and writing
                NetworkStream stream = client.GetStream();
                //Send initial test message
                stream.Write(data, 0, data.Length);
                infoBox.Text += "Sent initial connection test message..." + "\r\n";
                Application.DoEvents();
                /***************************************************
                 * Loop to determine what type of communication is *
                 * needed.                                         *
                 ***************************************************/
                #region Communication loop
                while(true)
                {
                    //Making Thread sleep to prevent cpu locking
                    Thread.Sleep(10);
                    //Resetting data and then reading server response
                    data = new byte[256];
                    stream.Read(data, 0, data.Length);
                    //Checking if anything was actually sent
                    if(data.ToString().Equals(""))
                    {
                        infoBox.Text += "Server Error, no data sent..." + "\r\n";
                        Application.DoEvents();
                        break;
                    }

                    //check to see if message was start message
                    string strMessage = Encoding.ASCII.GetString(data, 0, data.Length);
                    strMessage = strMessage.Substring(0, 5);
                    #region Receiving Public key, then encrypting message and sending message
                    if(strMessage.Equals("ready"))
                    {
                        //sleep to avoid cpu locking
                        //Thread.Sleep(10);
                        data = new byte[256];
                        stream.Read(data, 0, data.Length);
                        BigInteger e = new BigInteger(data);
                        data = new byte[256];
                        stream.Read(data, 0, data.Length);
                        BigInteger n = new BigInteger(data);
                        Key pu = new Key(e, n);
                        BigInteger eMessage = this.encrypt(Message, pu.returnKey());
                        data = eMessage.ToByteArray();
                        infoBox.Text += "Encrypted message " + eMessage.ToString() + "\r\n";
                        stream.Write(data, 0, data.Length);
                        infoBox.Text += "Encrypted Message sent..." + "\r\n";
                        Application.DoEvents();
                        break;
                    }
                    #endregion
                }
                #endregion
                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                //reporting any caught errors
                infoBox.Text += "Error Caught::" + "\r\n";
                infoBox.Text += "########################" + "\r\n";
                infoBox.Text += e.ToString() + "\r\n";
                infoBox.Text += "########################" + "\r\n";
                Application.DoEvents();
            }
        }

        public BigInteger encrypt(string message, BigInteger[] key)
        {
            BigInteger C = new BigInteger(0);
            if (message.Length > key[1])
            {
                return C;
            }
            else
            {
                Byte[] messageB = System.Text.Encoding.ASCII.GetBytes(message);
                BigInteger M = new BigInteger(messageB);
                C = BigInteger.ModPow(M, key[0], key[1]);
                return C;
            }
        }

        private void clearInfoBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoBox.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
