namespace SODV2202_FinalProject_Group7
{
    partial class Setup
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(489, 180);
            label1.Name = "label1";
            label1.Size = new Size(302, 45);
            label1.TabIndex = 0;
            label1.Text = "How many players?";
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Menu;
            button1.Image = Properties.Resources.dive3;
            button1.Location = new Point(246, 335);
            button1.Name = "button1";
            button1.Size = new Size(165, 200);
            button1.TabIndex = 3;
            button1.Text = "3";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnPlayerClicked;
            button1.MouseEnter += btnMouseEnter;
            button1.MouseLeave += btnMouseLeave;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Menu;
            button2.Image = Properties.Resources.dive4;
            button2.Location = new Point(456, 335);
            button2.Name = "button2";
            button2.Size = new Size(165, 200);
            button2.TabIndex = 4;
            button2.Text = "4";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnPlayerClicked;
            button2.MouseEnter += btnMouseEnter;
            button2.MouseLeave += btnMouseLeave;
            // 
            // button3
            // 
            button3.BackColor = Color.MidnightBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button3.ForeColor = SystemColors.Menu;
            button3.Image = Properties.Resources.dive5;
            button3.Location = new Point(666, 335);
            button3.Name = "button3";
            button3.Size = new Size(165, 200);
            button3.TabIndex = 5;
            button3.Text = "5";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnPlayerClicked;
            button3.MouseEnter += btnMouseEnter;
            button3.MouseLeave += btnMouseLeave;
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button4.ForeColor = SystemColors.Menu;
            button4.Image = Properties.Resources.dive6;
            button4.Location = new Point(876, 335);
            button4.Name = "button4";
            button4.Size = new Size(165, 200);
            button4.TabIndex = 6;
            button4.Text = "6";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnPlayerClicked;
            button4.MouseEnter += btnMouseEnter;
            button4.MouseLeave += btnMouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkBlue;
            pictureBox1.Image = Properties.Resources.shark;
            pictureBox1.Location = new Point(23, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
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
            label2.TabIndex = 13;
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
            label4.TabIndex = 16;
            // 
            // Setup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "Setup";
            Size = new Size(1280, 850);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
    }
}
