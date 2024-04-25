using System;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LocalMessenger
{
    public partial class frmMain : Form
    {
        private const int _port = 8888;
        private TcpClient _client;
        private NetworkStream _stream;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Form prompt = new Form();
            prompt.StartPosition = FormStartPosition.CenterScreen;
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.MaximizeBox = false;
            prompt.MaximumSize = new System.Drawing.Size(300, 150);
            prompt.MinimumSize = new System.Drawing.Size(300, 150);
            prompt.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            prompt.Text = "Server IP";

            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Server IP:" };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };

            Button confirmation = new Button() { Text = "Ok", Left = 150, Width = 100, Top = 80 };
            confirmation.Click += (sender2, e2) => { prompt.Close(); };

            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.ShowDialog();

            string input = textBox.Text;
            string pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

            if (string.IsNullOrEmpty(input) || !Regex.IsMatch(input, pattern))
            {
                MessageBox.Show("IP is invalid!", "IP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }

            ConnectToServer(input);
        }

        private void ConnectToServer(string serverIp)
        {
            try
            {
                _client = new TcpClient();
                _client.Connect(serverIp, _port);
                _stream = _client.GetStream();
                ctx_StatusText.Text = $"Server: {serverIp} (Connected successfully)";

                BeginReceive();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server: " + ex.Message, "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void BeginReceive()
        {
            try
            {
                byte[] buffer = new byte[1024];
                _stream.BeginRead(buffer, 0, buffer.Length, ReceiveCallback, buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting receive: " + ex.Message);
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                int bytesRead = _stream.EndRead(ar);
                if (bytesRead > 0)
                {
                    byte[] buffer = (byte[])ar.AsyncState;
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    Invoke(new Action(() =>
                    {
                        message.Replace("*x*", "|");
                        lsb_MessageBox.Items.Add($"[{message.Split('|')[1]}] {message.Split('|')[0]} ({DateTime.Now})");
                    }));

                    BeginReceive();
                }
                else
                {
                    // TODO: Handle disconnection
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error receiving message: " + ex.Message);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectFromServer();
        }

        private void DisconnectFromServer()
        {
            try
            {
                _stream?.Close();
                _client?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error disconnecting from server: " + ex.Message);
            }
        }

        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                string message = txt_MessageBox.Text;
                message.Replace("|", "*x*");
                byte[] buffer = Encoding.UTF8.GetBytes($"{message}|{Environment.MachineName}");
                _stream.Write(buffer, 0, buffer.Length);
                txt_MessageBox.Clear();

                lsb_MessageBox.Items.Add($"[{Environment.MachineName}] {message} ({DateTime.Now})");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message);
            }
        }

        private void txt_MessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_SendMessage.PerformClick();
            }
        }
    }
}
