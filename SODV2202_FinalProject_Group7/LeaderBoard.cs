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
        public LeaderBoard()
        {
            InitializeComponent();

        }

        private void btnRestart_Click_1(object sender, EventArgs e)
        {
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
            imgList.ImageSize = new Size(60,60);



            ImageList imgRank=new ImageList();
            imgRank.Images.Clear();
            imgRank.Images.Add(Image.FromFile(@"img/1.png"));
            imgRank.Images.Add(Image.FromFile(@"img/2.png"));
            imgRank.ImageSize = new Size(60,60);

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
                    pictureBox.Location = new Point(243, 235 + (position * 80));
                    pictureBox.BackColor = bgColor;

                    this.Controls.Add(pictureBox);
                }

                PictureBox playerBox = new PictureBox();
                playerBox.SizeMode = PictureBoxSizeMode.AutoSize;
                playerBox.Image = imgList.Images[Convert.ToInt32(playerName.Substring(playerName.Length - 1, 1))];
                playerBox.Location = new Point(303, 235 + (position * 80));
                playerBox.BackColor = bgColor;

                this.Controls.Add(playerBox);

                Label lbPlayer= new Label();
                lbPlayer.Text = playerName;
                lbPlayer.Font = new Font("Segoe UI Semibold", 10);
                lbPlayer.Location = new Point(384, 235 + (position * 80));
                lbPlayer.BackColor = bgColor;
                lbPlayer.ForeColor = fontColor;
                lbPlayer.Size = new Size(400, 60);
                lbPlayer.TextAlign = ContentAlignment.MiddleLeft;

                this.Controls.Add(lbPlayer);

                Label lb = new Label();
                lb.Size = new Size(1280, 60);
                lb.Location = new Point(0, 235 + (position * 80));
                lb.BackColor = bgColor;

                this.Controls.Add(lb);



                //// Select an image for the player based on the position
                //int imageIndex = position - 1;  // This assumes the images correspond to the position (1 = image 0, 2 = image 1, etc.)

                //// Ensure the image index is valid (within bounds of imageList1)
                //if (imageIndex >= 0 && imageIndex < imageList1.Images.Count)
                //{
                //    // Create a ListViewItem with the player's name and corresponding image index
                //    //ListViewItem item = new ListViewItem($"{position}. {playerName}", imageIndex);

                //    // Add the item to the ListView
                //    //lstRankings.Items.Add(item);


                //    // Create a ListViewItem with the player's name and corresponding image index

                //}
                //else
                //{
                //    // If the image index is out of bounds, show an error (optional)
                //    MessageBox.Show($"Invalid image index for {playerName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

                position++;
            }
        }

       


        private void LeaderBoard_Load(object sender, EventArgs e)
        {

        }

        private void lstRankings_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}




