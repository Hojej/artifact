using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Threading;
using System.Net.Sockets;
using System.Text;

namespace Artifact
{
    public partial class Form1 : Form
    {
        private int tcpPort;
        private String tcpHost;

        public TcpListener serverSocket;
        public TcpClient clientSocket;



        private string selectedFileName = "";
        private bool displayPic = false;

        public Form1()
        {
            InitializeComponent();
            init();
            pbairplane.Hide();

        }

        private void init()
        {
            Picbox.Controls.Add(pbairplane);
            pbairplane.Image = Image.FromFile("C:\\Users\\hooje\\Desktop\\New folder\\artifact-master\\artifact-master\\Artifact\\Artifact\\Airplane.png");
            pbairplane.SizeMode = PictureBoxSizeMode.AutoSize;
            pbairplane.Location = new Point(200, 200);
            pbairplane.BackColor = Color.Transparent;
        }



        private void btnLoadCPI_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Database files (*.bin, *.bin)|*.bin;*.bin";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = openFileDialog1.FileName;
                lblTest.Name = selectedFileName;
                lblTest.Text = selectedFileName;
                Picbox.Image = Image.FromFile("C:\\Users\\hooje\\Desktop\\New folder\\artifact-master\\artifact-master\\Artifact\\Artifact\\gate.jpg");
            }
        }

        private void btnShowHide(object sender, EventArgs e)
        {
            if (!displayPic)
            {
                pbairplane.Show();
            }
            else
            {
                pbairplane.Hide();
            }
            displayPic = !displayPic;
        }


        //start artefact
        private void button1_Click(object sender, EventArgs e)
        {
            //initTCPServer();
            InActivateButton(1);
        }

        private void initTCPServer()
        {
            /*serverSocket = new TcpListener(8122);
            clientSocket = default(TcpClient);
            serverSocket.Start();
            Console.WriteLine(" >> " + "Server Started");
            clientSocket = serverSocket.AcceptTcpClient();
            doChat();*/
        }

        private void doChat()
        {
            string clNo = "123";
            int requestCount = 0;
            byte[] bytesFrom = new byte[10025];
            string dataFromClient = null;
            Byte[] sendBytes = null;
            string serverResponse = null;
            string rCount = null;
            requestCount = 0;

            while ((true))
            {
                try
                {
                    requestCount = requestCount + 1;
                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                    dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    Console.WriteLine(" >> " + "From client-" + clNo + dataFromClient);

                    rCount = Convert.ToString(requestCount);
                    serverResponse = "Server to clinet(" + clNo + ") " + rCount;
                    sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                    networkStream.Flush();
                    Console.WriteLine(" >> " + serverResponse);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" >> " + ex.ToString());
                }
            }
        }
    }
}