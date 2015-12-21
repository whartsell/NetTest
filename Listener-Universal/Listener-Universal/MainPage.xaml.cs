using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using shared;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Listener_Universal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ExportListener listener;
        int defaultPort;
        int count;
        int byteCount;
        public MainPage()
        {
            this.InitializeComponent();
            defaultPort = 7777;
            PortTextBox.Text = defaultPort.ToString();
        }


        delegate void SetCountCallback(string count);
        delegate void SetByteCountCallback(string byteCount);


        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            MessageReceivedEventArgs args = new MessageReceivedEventArgs();
            string text = "hello";
            byte[] message = new byte[text.Length * sizeof(char)];
            System.Buffer.BlockCopy(text.ToCharArray(), 0, message, 0, message.Length);
            args.ByteCount = message.Length;
            args.Message = message;
            this.OnMessageReceived(this, args);
        }



        private void Reset()
        {
            count = 0;
            byteCount = 0;
            HitCountTextBox.Text = 0.ToString();
            BytesReceivedTextBox.Text = 0.ToString();
        }

       

        async private void OnMessageReceived(object sender, MessageReceivedEventArgs e)
        {
            
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,() =>
            {
                count += 1;
                byteCount += e.ByteCount;
                HitCountTextBox.Text = count.ToString();
                BytesReceivedTextBox.Text = byteCount.ToString();
            });

        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.Reset();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            int port;
            bool parsed = Int32.TryParse(PortTextBox.Text, out port);
            if (!parsed)
            {
                PortTextBox.Text = defaultPort.ToString();
                port = defaultPort;
            }
            PortTextBox.IsReadOnly = true;
            StartButton.IsEnabled = false;
            StopButton.IsEnabled = true;
            listener = new ExportListener(port, "192.168.1.2"); //address is not used...will listen on IPAddress.Any
            listener.MessageReceived += this.OnMessageReceived;
            listener.Start();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            listener.Stop();
            PortTextBox.IsReadOnly = false;

            StopButton.IsEnabled = false;
            StartButton.IsEnabled = true;
        }
    }
}
