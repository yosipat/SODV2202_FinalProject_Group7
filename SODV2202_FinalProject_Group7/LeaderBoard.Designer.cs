namespace SODV2202_FinalProject_Group7
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderBoard));
            lblTitle = new Label();
            btnRestart = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            imageList1 = new ImageList(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Menu;
            lblTitle.Location = new Point(572, 131);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 38);
            lblTitle.TabIndex = 0;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.MidnightBlue;
            btnRestart.FlatAppearance.BorderSize = 0;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.ForeColor = SystemColors.Menu;
            btnRestart.Image = Properties.Resources.home;
            btnRestart.Location = new Point(1040, 33);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(169, 55);
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
            pictureBox1.Location = new Point(23, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
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
            label2.Location = new Point(89, 42);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(97, 32);
            label2.TabIndex = 18;
            label2.Text = "Get Bit!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.DarkBlue;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(1280, 118);
            label4.TabIndex = 19;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "dive1.png");
            imageList1.Images.SetKeyName(1, "dive2.png");
            imageList1.Images.SetKeyName(2, "dive3.png");
            imageList1.Images.SetKeyName(3, "dive4.png");
            imageList1.Images.SetKeyName(4, "dive5.png");
            imageList1.Images.SetKeyName(5, "dive6.png");
            // 
            // label1
            // 
            label1.BackColor = Color.DarkBlue;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(449, 120);
            label1.Name = "label1";
            label1.Size = new Size(360, 48);
            label1.TabIndex = 23;
            label1.Text = "Leaderboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LeaderBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            Controls.Add(label1);
            Controls.Add(btnRestart);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(lblTitle);
            Name = "LeaderBoard";
            Size = new Size(1280, 850);
            Load += LeaderBoard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnRestart;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
        private ImageList imageList1;
        private Label label1;
    }
}
