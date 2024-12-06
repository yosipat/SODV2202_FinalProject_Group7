namespace SODV2202_FinalProject_Group7
{
    partial class Home
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
            btnStart = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.MidnightBlue;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = SystemColors.Menu;
            btnStart.Image = Properties.Resources.play;
            btnStart.Location = new Point(552, 453);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(199, 62);
            btnStart.TabIndex = 1;
            btnStart.Text = "  START";
            btnStart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkBlue;
            pictureBox1.Image = Properties.Resources.shark;
            pictureBox1.Location = new Point(601, 267);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkBlue;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(603, 373);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(97, 32);
            label3.TabIndex = 13;
            label3.Text = "Get Bit!";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.DarkBlue;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(1280, 860);
            label4.TabIndex = 14;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(btnStart);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Name = "Home";
            Size = new Size(1280, 860);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnStart;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
    }
}
