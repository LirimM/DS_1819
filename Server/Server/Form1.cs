using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Security.Cryptography;

namespace Server
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public String receive;
        public String TextToSend;
        public Form1()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ServerIPtextBox.Text = address.ToString();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(ServerPorttextBox.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;

            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = STR.ReadLine();
                    if (receive != null)
                    {
                        this.ChatScreentextBox.Invoke(new MethodInvoker(delegate ()
                        {
                            ChatScreentextBox.AppendText("\nClient:" + Dekripto(receive));
                            ChatScreentextBox.AppendText(Environment.NewLine);
                        }));
                        receive = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                if (TextToSend != null)
                {
                    TextToSend = Enkripto(TextToSend);
                    STW.WriteLine(TextToSend);
                    this.ChatScreentextBox.Invoke(new MethodInvoker(delegate ()
                    {
                        ChatScreentextBox.AppendText("\nServer:" + TextToSend);
                        ChatScreentextBox.AppendText(Environment.NewLine);
                    }));
                }
            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker2.CancelAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessagetextBox.Text != "")
            {
                TextToSend = MessagetextBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            MessagetextBox.Text = "";
        }

        public string Enkripto(string TextToSend)
        {
            byte[] Celesi = Encoding.UTF8.GetBytes("12365478");
            DESCryptoServiceProvider objDES = new DESCryptoServiceProvider();

            byte[] bytePlainTexti = Encoding.UTF8.GetBytes(TextToSend);

            objDES.Key = Celesi;
            objDES.Padding = PaddingMode.Zeros;
            objDES.Mode = CipherMode.CBC;
            objDES.IV = Encoding.UTF8.GetBytes("11223344");

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, objDES.CreateEncryptor(), CryptoStreamMode.Write);

            cs.Write(bytePlainTexti, 0, bytePlainTexti.Length);
            cs.Close();

            byte[] byteCiphertexti = ms.ToArray();
            return Convert.ToBase64String(byteCiphertexti);



        }

        public string Dekripto(string cyphertext)
        {
            byte[] celesi = Encoding.UTF8.GetBytes("12365478");

            DESCryptoServiceProvider objDES = new DESCryptoServiceProvider();

            objDES.Key = celesi;
            objDES.Padding = PaddingMode.Zeros;
            objDES.IV = Encoding.UTF8.GetBytes("11223344");
            objDES.Mode = CipherMode.CBC;
            cyphertext = cyphertext.Replace(" ", "+");
            int mod4 = cyphertext.Length % 4;
            if (mod4 > 0)
            {
                cyphertext += new string('=', 4 - mod4);
            }
            byte[] ciphertexti = Convert.FromBase64String(cyphertext);
            MemoryStream ms = new MemoryStream(ciphertexti);
            CryptoStream cs = new CryptoStream(ms, objDES.CreateDecryptor(), CryptoStreamMode.Read);
            byte[] bytetextiDekriptuar = new byte[ms.Length];
            cs.Read(bytetextiDekriptuar, 0, bytetextiDekriptuar.Length);
            cs.Close();

            return Encoding.UTF8.GetString(bytetextiDekriptuar);
        }
    }
}