using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;

public enum Mode { TCP, UDP };

namespace _5175U_ProgrammingProjectServer
{
    public partial class Form1 : Form
    {
        TcpListener tListener;
        UdpClient uListener;
        TcpClient client;
        public Mode mode;
        public Form1()
        {
            InitializeComponent();
            mode = Mode.TCP;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tCPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.TCP;
        }

        private void uDPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.UDP;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            statusBox.Text = "";
            byte[] buffer = new byte[1024];
            String fileLocation = fileDownloadLocationBox.Text + fileNameBox.Text;
            IPAddress serverIp = IPAddress.Parse(ipAddressBox.Text);
            Int32 port = Int32.Parse(serverPortBox.Text);
            String good = "good";
            String bad = "not good";
            byte[] gMessage = System.Text.Encoding.Unicode.GetBytes(good);
            byte[] bMessage = System.Text.Encoding.Unicode.GetBytes(bad);
            String originalPath = fileDownloadLocationBox.Text + "test.txt";

            if(mode == Mode.TCP)
            {
                try
                {
                    statusBox.Text += "Server IP address is: " + serverIp.ToString() + "\r\n";
                    tListener = new TcpListener(serverIp, port);

                    tListener.Start();
                    statusBox.Text += "Waiting for a connection..." + "\r\n";
                    while(true)
                    {
                        statusBox.Text += "Waiting for a connection..." + "\r\n";
                        client = tListener.AcceptTcpClient();
                        if(client != null)
                        {
                            statusBox.Text += "Client connected!" + "\r\n";
                            NetworkStream stream = client.GetStream();
                            stream.Read(buffer, 0, buffer.Length);
                            File.WriteAllBytes(fileLocation, buffer);
                            if(compareFiles(originalPath, fileLocation) == false)
                            {
                                stream.Write(bMessage, 0, bMessage.Length);
                                break;
                            }
                            stream.Write(gMessage, 0, gMessage.Length);
                        }
                        else
                        {
                            tListener.Stop();
                            break;
                        }
                    }
                }
                catch(Exception exc)
                {
                    statusBox.Text = "There was an error! Here is the error: " + exc.ToString() + "\r\n";
                }
                
            }
            else
            {
                try
                {
                    uListener = new UdpClient(port);
                    IPEndPoint snder = new IPEndPoint(IPAddress.Any, port);
                    uListener.Connect(snder);
                    statusBox.Text += "Waiting for a connection..." + "\r\n";
                    while(true)
                    {
                        buffer = uListener.Receive(ref snder);
                        if(buffer.Length != 0)
                        {
                            File.WriteAllBytes(fileLocation, buffer);
                            if(compareFiles(originalPath, fileLocation) == false)
                            {

                                uListener.Send(bMessage, bMessage.Length);
                                break;
                            }
                            uListener.Send(gMessage, gMessage.Length);
                        }
                        else
                        {
                            break;
                        }
                    }
                    uListener.Close();
                }
                catch(Exception exc)
                {
                    statusBox.Text += "There was an error! Here is the error: " + exc.ToString() + "\r\n";
                }
                
                

            }

        }

        public bool compareFiles(String path1, String path2)
        {
            byte[] file1 = File.ReadAllBytes(path1);
            byte[] file2 = File.ReadAllBytes(path2);

                for(int i = 0; i < file1.Length; i++)
                {
                    if(file1[i] != file2[i])
                    {
                        return false;
                    }
                }
                return true;
        }

        private void iPAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String host = Dns.GetHostName();
            IPAddress[] ips = Dns.GetHostAddresses(host);
            foreach(IPAddress ip in ips)
            {
                statusBox.Text += ip + "\r\n";
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBox.Clear();
        }
    }
}
