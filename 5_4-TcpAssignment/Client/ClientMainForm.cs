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

namespace Client
{
    public partial class ClientMainForm : Form
    {
        private readonly TcpClient client = new TcpClient();
        
        public ClientMainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                await client.ConnectAsync(IPAddress.Loopback, 9999);
                if (client.Connected)
                {
                    connectionStatusTbx.Text = "Connected";
                    connectionStatusTbx.ForeColor = Color.Green;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        
        private async void SendMoveSignal(Direction direction)
        {
            byte[] outBuffer = BitConverter.GetBytes((int) direction);
            await client.GetStream().WriteAsync(outBuffer, 0, outBuffer.Length);

            byte[] inBuffer = new byte[1024];
            await client.GetStream().ReadAsync(inBuffer, 0, inBuffer.Length);

            // Disables button depending on which wall was hit.
            Direction wallHit = (Direction) BitConverter.ToInt32(inBuffer, 0);
            switch (wallHit)
            {
                case Direction.Up:
                    moveUpButton.Enabled = false;
                    break;
                case Direction.Left:
                    moveLeftButton.Enabled = false;
                    break;
                case Direction.Right:
                    moveRightButton.Enabled = false;
                    break;
                case Direction.Down:
                    moveDownButton.Enabled = false;
                    break;
            }
            
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            if (!client.Connected) return;
            SendMoveSignal(Direction.Up);
            moveDownButton.Enabled = true;
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            if (!client.Connected) return;
            SendMoveSignal(Direction.Left);
            moveRightButton.Enabled = true;
        }

        private void moveRightButton_Click(object sender, EventArgs e)
        {
            if (!client.Connected) return;
            SendMoveSignal(Direction.Right);
            moveLeftButton.Enabled = true;
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            if (!client.Connected) return;
            SendMoveSignal(Direction.Down);
            moveUpButton.Enabled = true;
        }
    }
}