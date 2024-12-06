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
    public partial class Setup : UserControl
    {
        public event EventHandler btnNextClicked;
        public List<Player> players { get; set; }
        public int NumberOfPlayer { get; set; }
        public Setup()
        {
            InitializeComponent();
        }

        public void btnPlayerClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            try
            {
                NumberOfPlayer = Convert.ToInt32(btn.Text);
                if (NumberOfPlayer < 3)
                {
                    MessageBox.Show("Minimum 3 players required.");
                }
                else
                {
                    players = new List<Player>();
                    for (int i = 0; i < NumberOfPlayer; i++)
                    {
                        players.Add(new Player() { Name = "Player " + (i + 1), Lives = 4 });
                    }

                    // Assign card numbers (1-7) to each player
                    foreach (var player in players)
                    {
                        player.Cards = new List<int> { 1, 2, 3, 4, 5, 6, 7 }; // Initial card set
                    }

                    btnNextClicked?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        Color btndefault;
        public void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btndefault = btn.BackColor;
            btn.BackColor = Color.YellowGreen;
        }

        public void btnMouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = btndefault;
        }
    }
}
