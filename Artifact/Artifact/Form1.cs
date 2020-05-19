using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artifact
{
    public partial class Form1 : Form
    {
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
            pbairplane.Image = Image.FromFile("C:\\Users\\hooje\\Documents\\repos\\artifact\\Artifact\\Artifact\\Airplane.png");
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
                Picbox.Image = Image.FromFile("C:\\Users\\hooje\\Documents\\repos\\artifact\\Artifact\\Artifact\\gate.jpg");
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
    }
}
