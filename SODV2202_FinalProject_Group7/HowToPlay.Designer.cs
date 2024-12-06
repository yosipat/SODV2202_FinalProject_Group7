namespace SODV2202_FinalProject_Group7
{
    partial class HowToPlay
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
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            btnGo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(579, 333);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "howtoplay";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MidnightBlue;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = SystemColors.Menu;
            btnBack.Image = Properties.Resources.back;
            btnBack.Location = new Point(89, 712);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(169, 55);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkBlue;
            pictureBox1.Image = Properties.Resources.shark;
            pictureBox1.Location = new Point(23, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
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
            label2.TabIndex = 14;
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
            label4.TabIndex = 15;
            // 
            // btnGo
            // 
            btnGo.BackColor = Color.MidnightBlue;
            btnGo.FlatStyle = FlatStyle.Flat;
            btnGo.ForeColor = SystemColors.Menu;
            btnGo.Image = Properties.Resources.go;
            btnGo.Location = new Point(1016, 712);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(169, 55);
            btnGo.TabIndex = 18;
            btnGo.Text = "Let's Go";
            btnGo.TextAlign = ContentAlignment.MiddleRight;
            btnGo.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGo.UseVisualStyleBackColor = false;
            btnGo.Click += btnGo_Click;
            // 
            // HowToPlay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            Controls.Add(btnGo);
            Controls.Add(btnBack);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "HowToPlay";
            Size = new Size(1280, 850);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBack;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
        private Button btnGo;
    }
}
