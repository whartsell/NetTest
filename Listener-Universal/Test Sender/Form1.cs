using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Sender
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource tokenSource;
        private bool isSending;
        private int defaultPort = 7777;
        private string defaultAddress = "192.168.1.2";
        private Socket socket;
        private IPEndPoint endPoint;
        public Form1()
        {
            InitializeComponent();
            PortTextBox.Text = defaultPort.ToString();
            AddressTextBox.Text = defaultAddress;
            isSending = false;
            tokenSource = new CancellationTokenSource();
            setButtonsState();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPAddress host = IPAddress.Parse(AddressTextBox.Text);
                int port;
                if (!Int32.TryParse(PortTextBox.Text, out port))
                {
                    port = defaultPort;
                    PortTextBox.Text = defaultPort.ToString();

                }
                endPoint = new IPEndPoint(host, port);
            isSending = true;
                setButtonsState();
                Task.Run(() => startSending(tokenSource.Token), tokenSource.Token);
        }


        private void startSending(CancellationToken token)
        {
            Random random = new Random();
            while (!token.IsCancellationRequested)
            {
                byte[] b = new Byte[random.Next(1, 15)];
                random.NextBytes(b);
                socket.SendTo(b, endPoint);
                Thread.Sleep(1000);
            }
           
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            socket.Dispose();
            isSending = false;
            setButtonsState();
        }

        private void setButtonsState()
        {
            if (isSending == false)
            {
                StartButton.Enabled = true;
                StopButton.Enabled = false;
            }
            else
            {
                StartButton.Enabled = false;
                StopButton.Enabled = true;
            }
            
        }
    }
}
