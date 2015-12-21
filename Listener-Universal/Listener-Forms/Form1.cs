using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shared;

namespace Listener_Forms
{
    public partial class Form1 : Form
    {
        ExportListener listener;
        int defaultPort;
        int count;
        int byteCount;
    


        public Form1()
        {
            InitializeComponent();
            defaultPort = 7777;
            PortTextBox.Text = defaultPort.ToString();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            MessageReceivedEventArgs args = new MessageReceivedEventArgs();
            string text = "hello";
            byte[] message = new byte[text.Length * sizeof(char)];
            System.Buffer.BlockCopy(text.ToCharArray(), 0, message, 0, message.Length);
            args.ByteCount = message.Length;
            args.Message = message;
            this.OnMessageReceived(this,args);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {

            Reset();
              
        }

        private void Reset()
        {
            count = 0;
            byteCount = 0;
            SetByteCount(byteCount.ToString());
            SetCount(count.ToString());

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int port;
            bool parsed = Int32.TryParse(PortTextBox.Text, out port);
            if (!parsed)
            {
                PortTextBox.Text = defaultPort.ToString();
                port = defaultPort;
            }
            PortTextBox.ReadOnly = true;
            StartButton.Enabled = false;
            StopButton.Enabled = true;
            listener = new ExportListener(port, "192.168.1.2"); //address is not used...will listen on IPAddress.Any
            listener.MessageReceived += this.OnMessageReceived;
            listener.Start();
        }

        private void OnMessageReceived(object sender, MessageReceivedEventArgs e)
        {
            count += 1;
            byteCount += e.ByteCount;
            SetCount(count.ToString());
            SetByteCount(byteCount.ToString());

        }

        delegate void SetCountCallback(string count);
        delegate void SetByteCountCallback(string byteCount);

        private void StopButton_Click(object sender, EventArgs e)
        {
            listener.Stop();
            PortTextBox.ReadOnly = false;
            StopButton.Enabled = false;
            StartButton.Enabled = true;
        }

        private void SetCount(string count)
        {
            if (this.HitTextBox.InvokeRequired)
            {
                SetCountCallback d = new SetCountCallback(SetCount);
                this.Invoke(d, new object[] { count });
            }
            else this.HitTextBox.Text = count;
        }
        private void SetByteCount(string byteCount)
        {
            if (this.BytesTextBox.InvokeRequired)
            {
                SetByteCountCallback d = new SetByteCountCallback(SetByteCount);
                this.Invoke(d, new object[] { byteCount });
            }
            else this.BytesTextBox.Text = byteCount;
        }
    }
}
