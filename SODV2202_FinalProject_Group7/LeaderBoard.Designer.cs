﻿namespace SODV2202_FinalProject_Group7
{
    partial class LeaderBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnRestart = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(731, 457);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 0;
            label1.Text = "leader board";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.MidnightBlue;
            btnRestart.FlatAppearance.BorderSize = 0;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.ForeColor = SystemColors.Menu;
            btnRestart.Image = Properties.Resources.home;
            btnRestart.Location = new Point(1352, 42);
            btnRestart.Margin = new Padding(4, 4, 4, 4);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(220, 70);
            btnRestart.TabIndex = 21;
            btnRestart.Text = "Restart Game";
            btnRestart.TextAlign = ContentAlignment.MiddleRight;
            btnRestart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkBlue;
            pictureBox1.Image = Properties.Resources.shark;
            pictureBox1.Location = new Point(30, 36);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkBlue;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(116, 54);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(129, 45);
            label2.TabIndex = 18;
            label2.Text = "Get Bit!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.DarkBlue;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(1664, 151);
            label4.TabIndex = 19;
            // 
            // LeaderBoard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRestart);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "LeaderBoard";
            Size = new Size(1664, 1088);
            Load += LeaderBoard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRestart;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
    }
}
