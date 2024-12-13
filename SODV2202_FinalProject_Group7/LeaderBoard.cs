using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SODV2202_FinalProject_Group7
{
    public partial class LeaderBoard : UserControl
    {
        public event EventHandler btnRestartClicked;

        public List<string> Rank { get; set; }

        Panel panel = new Panel();
        public LeaderBoard()
        {
            InitializeComponent();
        
            panel.Location = new System.Drawing.Point(0, 235);
            panel.Name = "Panel1";
            panel.Size = new System.Drawing.Size(1280, 590);
            this.Controls.Add(panel);
        }

        private void btnRestart_Click_1(object sender, EventArgs e)
        {
            Rank.Clear();
            Panel myPanel = this.Controls["Panel1"] as Panel;
            foreach (Control c in myPanel.Controls)
            {
                c.Dispose();
            }
            myPanel.Controls.Clear();

            btnRestartClicked?.Invoke(this, EventArgs.Empty);
        }

        public void ShowRankings()
        {
            if (Rank == null || Rank.Count == 0)
            {
                MessageBox.Show("No rankings available to display.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Reverse the Rank list to display the winner at the top
            var reversedRank = Rank.AsEnumerable().Reverse().ToList();

            // Clear existing items in the ListView
            //lstRankings.Items.Clear();

            ImageList imgList = new ImageList();
            // Add images to the imageList1 only once, before the loop starts
            imgList.Images.Clear();  // Clear previous images if needed
            imgList.Images.Add(Image.FromFile(@"img/dive1.png"));
            imgList.Images.Add(Image.FromFile(@"img/dive2.png"));
            imgList.Images.Add(Image.FromFile(@"img/dive3.png"));
            imgList.Images.Add(Image.FromFile(@"img/dive4.png"));
            imgList.Images.Add(Image.FromFile(@"img/dive5.png"));
            imgList.Images.Add(Image.FromFile(@"img/dive6.png"));
            imgList.ImageSize = new Size(60, 60);



            ImageList imgRank = new ImageList();
            imgRank.Images.Clear();
            imgRank.Images.Add(Image.FromFile(@"img/1.png"));
            imgRank.Images.Add(Image.FromFile(@"img/2.png"));
            imgRank.ImageSize = new Size(60, 60);

            int position = 0;
            Color bgColor = Color.MidnightBlue;
            Color fontColor = Color.AliceBlue;

            foreach (var playerName in reversedRank)
            {

                if (position < 2)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                    pictureBox.Image = imgRank.Images[position];
                    pictureBox.Location = new Point(243, (position * 80));
                    pictureBox.BackColor = bgColor;

                    panel.Controls.Add(pictureBox);
                }

                PictureBox playerBox = new PictureBox();
                playerBox.SizeMode = PictureBoxSizeMode.AutoSize;
                playerBox.Image = imgList.Images[Convert.ToInt32(playerName.Substring(playerName.Length - 1, 1))];
                playerBox.Location = new Point(303, (position * 80));
                playerBox.BackColor = bgColor;

                panel.Controls.Add(playerBox);

                Label lbPlayer = new Label();
                lbPlayer.Text = playerName;
                lbPlayer.Font = new Font("Segoe UI Semibold", 10);
                lbPlayer.Location = new Point(384, (position * 80));
                lbPlayer.BackColor = bgColor;
                lbPlayer.ForeColor = fontColor;
                lbPlayer.Size = new Size(400, 60);
                lbPlayer.TextAlign = ContentAlignment.MiddleLeft;

                panel.Controls.Add(lbPlayer);

                Label lb = new Label();
                lb.Size = new Size(1280, 60);
                lb.Location = new Point(0, (position * 80));
                lb.BackColor = bgColor;

                panel.Controls.Add(lb);

                position++;
            }
        }


    }
}




