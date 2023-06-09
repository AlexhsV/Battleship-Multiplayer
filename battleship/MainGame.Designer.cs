﻿namespace battleship
{
    partial class MainGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.buttonStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxPlayer2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShip5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShip3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShip4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShip2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.timer_Pull = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.pictureBoxEnterName = new System.Windows.Forms.PictureBox();
            this.pictureBoxAudio = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnterName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAudio)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Image = ((System.Drawing.Image)(resources.GetObject("buttonStart.Image")));
            this.buttonStart.Location = new System.Drawing.Point(549, 23);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(266, 71);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBoxPlayer2);
            this.panel1.Controls.Add(this.pictureBoxPlayer1);
            this.panel1.Controls.Add(this.pictureBoxShip5);
            this.panel1.Controls.Add(this.pictureBoxShip3);
            this.panel1.Controls.Add(this.pictureBoxShip4);
            this.panel1.Controls.Add(this.pictureBoxShip2);
            this.panel1.Location = new System.Drawing.Point(68, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 550);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxPlayer2
            // 
            this.pictureBoxPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPlayer2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayer2.Image")));
            this.pictureBoxPlayer2.Location = new System.Drawing.Point(669, 42);
            this.pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            this.pictureBoxPlayer2.Size = new System.Drawing.Size(400, 547);
            this.pictureBoxPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayer2.TabIndex = 7;
            this.pictureBoxPlayer2.TabStop = false;
            this.pictureBoxPlayer2.Click += new System.EventHandler(this.pictureBoxPlayer2_Click);
            this.pictureBoxPlayer2.MouseEnter += new System.EventHandler(this.pictureBoxPlayer2_MouseEnter);
            this.pictureBoxPlayer2.MouseLeave += new System.EventHandler(this.pictureBoxPlayer2_MouseLeave);
            // 
            // pictureBoxPlayer1
            // 
            this.pictureBoxPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPlayer1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayer1.Image")));
            this.pictureBoxPlayer1.Location = new System.Drawing.Point(228, 55);
            this.pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            this.pictureBoxPlayer1.Size = new System.Drawing.Size(378, 530);
            this.pictureBoxPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayer1.TabIndex = 8;
            this.pictureBoxPlayer1.TabStop = false;
            this.pictureBoxPlayer1.Click += new System.EventHandler(this.pictureBoxPlayer1_Click);
            this.pictureBoxPlayer1.MouseEnter += new System.EventHandler(this.pictureBoxPlayer1_MouseEnter);
            this.pictureBoxPlayer1.MouseLeave += new System.EventHandler(this.pictureBoxPlayer1_MouseLeave);
            // 
            // pictureBoxShip5
            // 
            this.pictureBoxShip5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShip5.Image")));
            this.pictureBoxShip5.Location = new System.Drawing.Point(857, 103);
            this.pictureBoxShip5.Name = "pictureBoxShip5";
            this.pictureBoxShip5.Size = new System.Drawing.Size(240, 30);
            this.pictureBoxShip5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShip5.TabIndex = 7;
            this.pictureBoxShip5.TabStop = false;
            this.pictureBoxShip5.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShip5_MouseDoubleClick);
            this.pictureBoxShip5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShip5_MouseDown);
            this.pictureBoxShip5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShip5_MouseMove);
            // 
            // pictureBoxShip3
            // 
            this.pictureBoxShip3.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxShip3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShip3.Image")));
            this.pictureBoxShip3.Location = new System.Drawing.Point(996, 214);
            this.pictureBoxShip3.Name = "pictureBoxShip3";
            this.pictureBoxShip3.Size = new System.Drawing.Size(135, 31);
            this.pictureBoxShip3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxShip3.TabIndex = 5;
            this.pictureBoxShip3.TabStop = false;
            this.pictureBoxShip3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShip3_MouseDoubleClick);
            this.pictureBoxShip3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShip3_MouseDown);
            this.pictureBoxShip3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShip3_MouseMove);
            // 
            // pictureBoxShip4
            // 
            this.pictureBoxShip4.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxShip4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShip4.Image")));
            this.pictureBoxShip4.Location = new System.Drawing.Point(947, 152);
            this.pictureBoxShip4.Name = "pictureBoxShip4";
            this.pictureBoxShip4.Size = new System.Drawing.Size(200, 40);
            this.pictureBoxShip4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxShip4.TabIndex = 4;
            this.pictureBoxShip4.TabStop = false;
            this.pictureBoxShip4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShip4_MouseDoubleClick);
            this.pictureBoxShip4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShip4_MouseDown);
            this.pictureBoxShip4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShip4_MouseMove);
            // 
            // pictureBoxShip2
            // 
            this.pictureBoxShip2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxShip2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShip2.Image")));
            this.pictureBoxShip2.Location = new System.Drawing.Point(1036, 273);
            this.pictureBoxShip2.Name = "pictureBoxShip2";
            this.pictureBoxShip2.Size = new System.Drawing.Size(81, 27);
            this.pictureBoxShip2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxShip2.TabIndex = 6;
            this.pictureBoxShip2.TabStop = false;
            this.pictureBoxShip2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShip2_MouseDoubleClick);
            this.pictureBoxShip2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShip2_MouseDown);
            this.pictureBoxShip2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShip2_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(734, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 550);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 55);
            this.label1.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(596, 174);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(152, 31);
            this.textBoxName.TabIndex = 5;
            // 
            // timer_Pull
            // 
            this.timer_Pull.Enabled = true;
            this.timer_Pull.Interval = 1000;
            this.timer_Pull.Tick += new System.EventHandler(this.timer_Pull_Tick);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTimer.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.ForeColor = System.Drawing.Color.Black;
            this.labelTimer.Location = new System.Drawing.Point(1072, 23);
            this.labelTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(243, 39);
            this.labelTimer.TabIndex = 7;
            this.labelTimer.Text = "Time elapsed: 0";
            // 
            // pictureBoxEnterName
            // 
            this.pictureBoxEnterName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnterName.BackgroundImage")));
            this.pictureBoxEnterName.Location = new System.Drawing.Point(382, 23);
            this.pictureBoxEnterName.Name = "pictureBoxEnterName";
            this.pictureBoxEnterName.Size = new System.Drawing.Size(638, 82);
            this.pictureBoxEnterName.TabIndex = 11;
            this.pictureBoxEnterName.TabStop = false;
            // 
            // pictureBoxAudio
            // 
            this.pictureBoxAudio.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAudio.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAudio.Image")));
            this.pictureBoxAudio.Location = new System.Drawing.Point(12, 8);
            this.pictureBoxAudio.Name = "pictureBoxAudio";
            this.pictureBoxAudio.Size = new System.Drawing.Size(82, 86);
            this.pictureBoxAudio.TabIndex = 15;
            this.pictureBoxAudio.TabStop = false;
            this.pictureBoxAudio.Click += new System.EventHandler(this.pictureBoxAudio_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 801);
            this.Controls.Add(this.pictureBoxAudio);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.pictureBoxEnterName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "battleship";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGame_FormClosing);
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnterName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAudio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxShip4;
        private System.Windows.Forms.PictureBox pictureBoxShip3;
        private System.Windows.Forms.PictureBox pictureBoxShip2;
        private System.Windows.Forms.PictureBox pictureBoxShip5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
        private System.Windows.Forms.Timer timer_Pull;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.PictureBox pictureBoxEnterName;
        private System.Windows.Forms.PictureBox pictureBoxAudio;
    }
}