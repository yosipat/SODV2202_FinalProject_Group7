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

        public void Show()
        {
            // your code

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
            lstRankings.Items.Clear();

            

            // Add images to the imageList1 only once, before the loop starts
            imageList1.Images.Clear();  // Clear previous images if needed
            imageList1.Images.Add(Image.FromFile(@"img/dive1.png"));
            imageList1.Images.Add(Image.FromFile(@"img/dive2.png"));
            imageList1.Images.Add(Image.FromFile(@"img/dive3.png"));
            imageList1.Images.Add(Image.FromFile(@"img/dive4.png"));
            imageList1.Images.Add(Image.FromFile(@"img/dive5.png"));
            imageList1.Images.Add(Image.FromFile(@"img/dive6.png"));

            int position = 1;
            foreach (var playerName in reversedRank)
            {
                // Select an image for the player based on the position
                int imageIndex = position - 1;  // This assumes the images correspond to the position (1 = image 0, 2 = image 1, etc.)

                // Ensure the image index is valid (within bounds of imageList1)
                if (imageIndex >= 0 && imageIndex < imageList1.Images.Count)
                {
                    // Create a ListViewItem with the player's name and corresponding image index
                    ListViewItem item = new ListViewItem($"{position}. {playerName}", imageIndex);

                    // Add the item to the ListView
                    lstRankings.Items.Add(item);
                }
                else
                {
                    // If the image index is out of bounds, show an error (optional)
                    MessageBox.Show($"Invalid image index for {playerName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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




