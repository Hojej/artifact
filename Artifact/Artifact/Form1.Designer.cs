﻿namespace Artifact
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoadCPI = new System.Windows.Forms.Button();
            this.IPInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PortInput = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Picbox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.pbairplane = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbairplane)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Artifact";
            this.button1.UseVisualStyleBackColor = true;
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
            // IPInput
            // 
            this.IPInput.Location = new System.Drawing.Point(81, 19);
            this.IPInput.Name = "IPInput";
            this.IPInput.Size = new System.Drawing.Size(100, 20);
            this.IPInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Adress:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port number:";
            // 
            // PortInput
            // 
            this.PortInput.Location = new System.Drawing.Point(81, 52);
            this.PortInput.Name = "PortInput";
            this.PortInput.Size = new System.Drawing.Size(100, 20);
            this.PortInput.TabIndex = 4;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(275, 554);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(257, 44);
            this.button4.TabIndex = 7;
            this.button4.Text = "Disconnect";
            this.button4.UseVisualStyleBackColor = true;
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
            this.groupBox2.Controls.Add(this.lblTest);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.IPInput);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.PortInput);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 519);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
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
            // pbairplane
            // 
            this.pbairplane.Location = new System.Drawing.Point(205, 267);
            this.pbairplane.Name = "pbairplane";
            this.pbairplane.Size = new System.Drawing.Size(345, 135);
            this.pbairplane.TabIndex = 1;
            this.pbairplane.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 663);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLoadCPI);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Radar Artifact";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbairplane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoadCPI;
        private System.Windows.Forms.TextBox IPInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PortInput;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.PictureBox Picbox;
        private System.Windows.Forms.PictureBox pbairplane;
    }
}

