using System.Windows.Forms;

namespace SODV2202_FinalProject_Group7
{
    public partial class Form1 : Form
    {
        public List<Player> players { get; set; }
        public Form1()
        {
            InitializeComponent();
            homePagerun(null,null);

            homePage.btnStartClicked += setupPagerun;
            setupPage.btnNextClicked += howToPlayPagerun;
            howToPlayPage.btnGoClicked += gamePagerun;
            howToPlayPage.btnBackClicked += setupPagerun;
            gamePage.gameEnded += leaderBoardPagerun;
            leaderBoardPage.btnRestartClicked += homePagerun;

        }

        public void homePagerun(object sender, EventArgs e)
        {
            homePage.Visible = true;
            setupPage.Visible = false;
            howToPlayPage.Visible = false;  
            gamePage.Visible = false;
            leaderBoardPage.Visible = false;
        }

        public void setupPagerun(object sender, EventArgs e)
        {
            homePage.Visible = false;
            setupPage.Visible = true;
            howToPlayPage.Visible = false;
            gamePage.Visible = false;
            leaderBoardPage.Visible = false;
        }

        public void howToPlayPagerun(object sender, EventArgs e)
        {

            players = setupPage.players; // get players from setup page
            howToPlayPage.Show();

            homePage.Visible = false;
            setupPage.Visible = false;
            howToPlayPage.Visible = true;
            gamePage.Visible = false;
            leaderBoardPage.Visible = false;
        }

        public void gamePagerun(object sender, EventArgs e)
        {
            gamePage.players = setupPage.players; // get players from setup page
            gamePage.gameInitial();

            homePage.Visible = false;
            setupPage.Visible = false;
            howToPlayPage.Visible = false;
            gamePage.Visible = true;
            leaderBoardPage.Visible = false;
        }


        public void leaderBoardPagerun(object sender, EventArgs e)
        {
            // Copy the Rank list from the gamePage
            leaderBoardPage.Rank = new List<string>(gamePage.Rank);

            // Populate the leaderboard
            leaderBoardPage.ShowRankings();

            // Show the leaderboard page
            homePage.Visible = false;
            setupPage.Visible = false;
            howToPlayPage.Visible = false;
            gamePage.Visible = false;
            leaderBoardPage.Visible = true;
        }
    }
}
