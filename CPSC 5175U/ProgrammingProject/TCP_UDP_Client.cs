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

namespace _5175U_ProgrammingProject
{
    public enum Mode { TCP, UDP };
    public partial class NetworksProject : Form
    {
        TcpClient tClient;
        UdpClient uClient;
        public Mode mode;
        public NetworksProject()
        {
            InitializeComponent();
            mode = Mode.TCP;
        }

        private void tCPModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.TCP;
        }

        private void uDPModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = Mode.UDP;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            byte[] statusMessageBytes = new byte[256];
            String message;
            String filePath = fileLocationBox.Text;
            statusBox.Clear();
            if(mode == Mode.TCP)
            {
                String ipAddress = serverAddressBox.Text;
                Int32 port = Convert.ToInt32(portBox.Text);
                IPAddress address = IPAddress.Parse(ipAddress);
                IPEndPoint endPoint = new IPEndPoint(address, port);
                tClient = new TcpClient(ipAddress, port);
                NetworkStream tStream = tClient.GetStream();
                FileStream fs = File.OpenRead(filePath);
                byte[] fileBytes = new byte[fs.Length];
                fs.Read(fileBytes, 0, fileBytes.Length);
                fs.Close();

                if(tStream.CanWrite)
                {
                    for (int i = 0; i < 9999; i++)
                    {
                        try
                        {
                            tStream.Write(fileBytes, 0, fileBytes.Length);
                        }

                        catch (SocketException exc)
                        {
                            statusBox.Text += "Something went wrong. Here is your error: " + exc.ToString() + "\r\n";
                        }

                        if (tStream.CanRead)
                        {
                            try
                            {
                                tStream.Read(statusMessageBytes, 0, statusMessageBytes.Length);
                            }
                            catch (ObjectDisposedException ex)
                            {
                                statusBox.Text += "Something went wrong. Here is your error: " + ex.ToString() + "\r\n";
                            }
                        }

                        message = Encoding.Unicode.GetString(statusMessageBytes, 0, statusMessageBytes.Length);
                        statusBox.Text += message + "\r\n";
                        if (!message.Equals("good"))
                        {
                            statusBox.Text += "Something went wrong on the server-side end system." + "\r\n";
                            break;
                        }
                        statusBox.Text += i + "\r\n";
                        tClient.Close();
                        tClient = new TcpClient(ipAddress, port);
                    }
                    tClient.Close();
                }
                else
                {
                    statusBox.Text += "Cannot write to network. There is something wrong with your connection." + "\r\n";
                }
            }
            else 
            {
                String ipAddress = serverAddressBox.Text;
                Int32 port = Convert.ToInt32(portBox.Text);
                IPAddress address = IPAddress.Parse(ipAddress);
                IPEndPoint endPoint = new IPEndPoint(address, port);
                uClient = new UdpClient(port);
                FileStream fs = File.OpenRead(filePath);
                byte[] fileBytes = new byte[fs.Length];
                fs.Read(fileBytes, 0, fileBytes.Length);
                fs.Close();
                
                uClient.Connect(address, port);
                for (int i = 0; i < 9999; i++)
                {
                    try
                    {
                        uClient.Send(fileBytes, fileBytes.Length);

                    }
                    catch(Exception exc)
                    {
                        statusBox.Text += "Something went wrong. Here is your error: " + exc.ToString() + "\r\n";
                    }

                    try
                    {
                        statusMessageBytes = uClient.Receive(ref endPoint);
                    }

                    catch(Exception exc)
                    {
                        statusBox.Text += "Something went wrong. Here is your error: " + exc.ToString() + "\r\n";
                    }

                    message = Encoding.UTF8.GetString(statusMessageBytes, 0, statusMessageBytes.Length);
                    if(!message.Equals("good"))
                    {
                        statusBox.Text += "Something went wrong on the server-side end system." + "\r\n";
                        break;
                    }
                }  
            }
        }


    }
}
