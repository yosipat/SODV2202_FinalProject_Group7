using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            // Clear the existing items
            lstRankings.Items.Clear();

            // Add each ranked player to the ListBox
            int position = 1;
            foreach (var player in Rank)
            {
                lstRankings.Items.Add($"{position}. {player}");
                position++;
            }
        }


        private void LeaderBoard_Load(object sender, EventArgs e)
        {

        }
    }
}




