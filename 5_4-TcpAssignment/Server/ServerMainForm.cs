using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerMainForm : Form
    {
        private readonly TcpListener listener;
        private TcpClient? connection;

        public ServerMainForm()
        {
            InitializeComponent();
            listener = new TcpListener(IPAddress.Loopback, 9999);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                listener.Start();
                Receive();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private async void Receive()
        {
            try
            {
                connection = await listener.AcceptTcpClientAsync();
            }
            catch (Exception exception)
            { 
                MessageBox.Show(exception.Message);
                return;
            }

            if (connection != null)
            {
                await HearOutConnection();
            }
        }

        /*
         * Listens to and incoming connection until it disconnects.
         */
        private async Task HearOutConnection()
        {
            marioPicBox.Visible = true;
            while (connection.Connected)
            {
                // Sets connection to null and listens for new connection if client is disconnected.

                byte[] inBuffer = new byte[1024];
                await InStream(connection.GetStream(), inBuffer);

                Direction direction = (Direction) BitConverter.ToInt32(inBuffer, 0);

                bool marioHitTheWall = MoveMario(direction);
                if (marioHitTheWall)
                {
                    // Send back request to disable button in client.
                    byte[] outBuffer = BitConverter.GetBytes((int) direction);
                    await OutStream(connection.GetStream(), outBuffer);
                }
            }
            
            marioPicBox.Visible = false;
            
            // Set connection to null and start listening for new connection upon client disconnect.
            connection = null;
            Receive();
        }

        /*
         * Takes a stream and a byte buffer parameter. Reads from network stream and puts data into buffer.
         */
        private async Task InStream(Stream stream, byte[] buffer)
        {
            try
            {
                await stream.ReadAsync(buffer, 0, buffer.Length);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        
        /*
         * Takes a stream and a byte buffer parameter. Reads buffer and sends through network stream.
         */
        private async Task OutStream(Stream stream, byte[] buffer)
        {
            try
            {
                await stream.WriteAsync(buffer, 0, buffer.Length);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /*
         * Moves mario sprite.
         * Returns true if mario is outside of the server window.
         */
        private bool MoveMario(Direction direction)
        {
            int moveAmount = 10;
            
            switch (direction)
            {
                case Direction.Up:
                    if (marioPicBox.Top - moveAmount > 0)
                    {
                        marioPicBox.Top -= moveAmount;
                        return false;
                    }

                    return true; 
                case Direction.Left:
                    if (marioPicBox.Left - moveAmount > 0)
                    {
                        marioPicBox.Left -= moveAmount;
                        return false;
                    }
                    
                    return true;
                case Direction.Right:
                    if (marioPicBox.Right + moveAmount < this.Width)
                    {
                        marioPicBox.Left += moveAmount;
                        return false;
                    }
                    
                    return true;
                case Direction.Down:
                    if (marioPicBox.Bottom + moveAmount < this.Height)
                    {
                        marioPicBox.Top += moveAmount;
                        return false;
                    }
                    
                    return true;
                default:
                    return false;
            }
        }
    }
}