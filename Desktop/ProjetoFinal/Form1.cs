using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Form1 : Form
    {
        //Creates a UdpClient for reading incoming data.
        UdpClient receivingUdpClient = new UdpClient(12345);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client();
        }

        void server()
        {
            Task.Run(() =>
            {

                //Creates an IPEndPoint to record the IP Address and port number of the sender.
                // The IPEndPoint will allow you to read datagrams sent from any source.
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 12345);
                try
                {
                    while (true)
                    {
                        // Blocks until a message returns on this socket from a remote host.
                        Byte[] receiveBytes = receivingUdpClient.Receive(ref RemoteIpEndPoint);

                        string returnData = Encoding.UTF8.GetString(receiveBytes);

                        Console.WriteLine(returnData.ToString());

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            });
        }


        void client() {

            byte[]
                b = Encoding.ASCII.GetBytes(textBox1.Text);
            UdpClient C = new UdpClient();
            C.Send(b, b.Length, "255.255.255.255", 12346);

        }
    }
}
 