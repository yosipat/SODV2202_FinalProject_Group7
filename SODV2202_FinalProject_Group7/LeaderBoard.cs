using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            UpdateLeaderBoard();
        }

        private void UpdateLeaderBoard()
        {
            // Clear previous leaderboard entries (including button and labels)
            this.Controls.Clear();

            // Add a label for the header (Leaderboard title)
            Label labelHeader = new Label
            {
                Text = "Leaderboard",
                Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(600, 50),
                AutoSize = true
            };
            this.Controls.Add(labelHeader);

            // Sort the Rank list by score in descending order
            var sortedRank = Rank.OrderByDescending(player => player.Score).ToList();

            // Set the starting position for the first label
            int yPosition = 160;

            // Loop through the sorted list and add each player to the leaderboard
            foreach (var player in sortedRank)
            {
                Label playerLabel = new Label
                {
                    Text = $"{player.Name} - {player.Score}",
                    Location = new Point(600, yPosition),
                    Font = new Font("Arial", 14),
                    ForeColor = Color.White,
                    AutoSize = true
                };

                // Add player label to the form
                this.Controls.Add(playerLabel);

                // Increment Y position for the next player
                yPosition += 40;
            }

            // Add the Restart button to the UI
            btnRestart.Location = new Point(1352, 42);
            this.Controls.Add(btnRestart);
        }

        // Method to handle the form load event (if necessary)


        private void LeaderBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
