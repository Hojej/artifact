namespace Artifact
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startbtn = new System.Windows.Forms.Button();
            this.btnLoadCPI = new System.Windows.Forms.Button();
            this.tcphost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcpport = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.disconnectbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbairplane = new System.Windows.Forms.PictureBox();
            this.Picbox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.udpCport = new System.Windows.Forms.TextBox();
            this.udpcln = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.udpsHport = new System.Windows.Forms.TextBox();
            this.udphost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbairplane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(12, 604);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(257, 47);
            this.startbtn.TabIndex = 0;
            this.startbtn.Text = "Start Artifact";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoadCPI
            // 
            this.btnLoadCPI.Location = new System.Drawing.Point(275, 604);
            this.btnLoadCPI.Name = "btnLoadCPI";
            this.btnLoadCPI.Size = new System.Drawing.Size(257, 47);
            this.btnLoadCPI.TabIndex = 1;
            this.btnLoadCPI.Text = "Load CPI";
            this.btnLoadCPI.UseVisualStyleBackColor = true;
            this.btnLoadCPI.Click += new System.EventHandler(this.btnLoadCPI_Click);
            // 
            // tcphost
            // 
            this.tcphost.Location = new System.Drawing.Point(58, 19);
            this.tcphost.Name = "tcphost";
            this.tcphost.Size = new System.Drawing.Size(100, 20);
            this.tcphost.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TCP-Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TCP-Port";
            // 
            // tcpport
            // 
            this.tcpport.Location = new System.Drawing.Point(58, 52);
            this.tcpport.Name = "tcpport";
            this.tcpport.Size = new System.Drawing.Size(100, 20);
            this.tcpport.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 554);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "Show/Hide Object";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnShowHide);
            // 
            // disconnectbtn
            // 
            this.disconnectbtn.Location = new System.Drawing.Point(275, 554);
            this.disconnectbtn.Name = "disconnectbtn";
            this.disconnectbtn.Size = new System.Drawing.Size(257, 44);
            this.disconnectbtn.TabIndex = 7;
            this.disconnectbtn.Text = "Disconnect";
            this.disconnectbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbairplane);
            this.groupBox1.Controls.Add(this.Picbox);
            this.groupBox1.Location = new System.Drawing.Point(558, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 638);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
            // 
            // pbairplane
            // 
            this.pbairplane.Location = new System.Drawing.Point(205, 267);
            this.pbairplane.Name = "pbairplane";
            this.pbairplane.Size = new System.Drawing.Size(345, 135);
            this.pbairplane.TabIndex = 1;
            this.pbairplane.TabStop = false;
            // 
            // Picbox
            // 
            this.Picbox.Location = new System.Drawing.Point(3, 16);
            this.Picbox.Name = "Picbox";
            this.Picbox.Size = new System.Drawing.Size(686, 616);
            this.Picbox.TabIndex = 0;
            this.Picbox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.udpCport);
            this.groupBox2.Controls.Add(this.udpcln);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.udpsHport);
            this.groupBox2.Controls.Add(this.udphost);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblTest);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tcphost);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tcpport);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 519);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INPUT";
            // 
            // udpCport
            // 
            this.udpCport.Location = new System.Drawing.Point(413, 52);
            this.udpCport.Name = "udpCport";
            this.udpCport.Size = new System.Drawing.Size(100, 20);
            this.udpCport.TabIndex = 14;
            // 
            // udpcln
            // 
            this.udpcln.Location = new System.Drawing.Point(413, 19);
            this.udpcln.Name = "udpcln";
            this.udpcln.Size = new System.Drawing.Size(100, 20);
            this.udpcln.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "UDP-Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "UDP-Cln";
            // 
            // udpsHport
            // 
            this.udpsHport.Location = new System.Drawing.Point(228, 52);
            this.udpsHport.Name = "udpsHport";
            this.udpsHport.Size = new System.Drawing.Size(100, 20);
            this.udpsHport.TabIndex = 10;
            // 
            // udphost
            // 
            this.udphost.Location = new System.Drawing.Point(228, 19);
            this.udphost.Name = "udphost";
            this.udphost.Size = new System.Drawing.Size(100, 20);
            this.udphost.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "UDP-Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "UDP-Host";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(11, 148);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(39, 13);
            this.lblTest.TabIndex = 6;
            this.lblTest.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 663);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.disconnectbtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLoadCPI);
            this.Controls.Add(this.startbtn);
            this.Name = "Form1";
            this.Text = "Radar Artifact";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbairplane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        public void InActivateButton(int caseSwitch)
        {
            System.Windows.Forms.Button btn;
            switch (caseSwitch)
            {
                case 1:
                    btn = startbtn;
                    break;
                case 2:
                    btn = disconnectbtn;
                    break;
                default:
                    btn = btnLoadCPI;
                    break;
            }
            btn.Enabled = false;
        }

        public void ActivateButton(System.Windows.Forms.Button btn)
        {
            btn.Enabled = true;
        }

        #endregion

        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button btnLoadCPI;
        private System.Windows.Forms.TextBox tcphost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tcpport;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button disconnectbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.PictureBox Picbox;
        private System.Windows.Forms.PictureBox pbairplane;
        private System.Windows.Forms.TextBox udpCport;
        private System.Windows.Forms.TextBox udpcln;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox udpsHport;
        private System.Windows.Forms.TextBox udphost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

