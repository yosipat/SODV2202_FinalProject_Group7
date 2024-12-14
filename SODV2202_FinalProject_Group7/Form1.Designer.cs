namespace SODV2202_FinalProject_Group7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            homePage = new Home();
            howToPlayPage = new HowToPlay();
            leaderBoardPage = new LeaderBoard();
            setupPage = new Setup();
            gamePage = new Game();
            SuspendLayout();
            // 
            // homePage
            // 
            homePage.Location = new Point(0, 0);
            homePage.Name = "homePage";
            homePage.Size = new Size(1280, 850);
            homePage.TabIndex = 0;
            // 
            // howToPlayPage
            // 
            howToPlayPage.BackColor = Color.DarkBlue;
            howToPlayPage.Location = new Point(0, 0);
            howToPlayPage.Name = "howToPlayPage";
            howToPlayPage.Size = new Size(1280, 850);
            howToPlayPage.TabIndex = 2;
            // 
            // leaderBoardPage
            // 
            leaderBoardPage.BackColor = Color.DarkBlue;
            leaderBoardPage.Location = new Point(0, 0);
            leaderBoardPage.Name = "leaderBoardPage";
            leaderBoardPage.Rank = null;
            leaderBoardPage.Size = new Size(1280, 850);
            leaderBoardPage.TabIndex = 3;
            // 
            // setupPage
            // 
            setupPage.BackColor = Color.DarkBlue;
            setupPage.Location = new Point(0, 0);
            setupPage.Name = "setupPage";
            setupPage.NumberOfPlayer = 0;
            setupPage.players = null;
            setupPage.Size = new Size(1280, 850);
            setupPage.TabIndex = 4;
            // 
            // gamePage
            // 
            gamePage.BackColor = Color.LightSteelBlue;
            gamePage.Location = new Point(0, 0);
            gamePage.Name = "gamePage";
            gamePage.players = null;
            gamePage.Size = new Size(1280, 850);
            gamePage.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 794);
            Controls.Add(gamePage);
            Controls.Add(setupPage);
            Controls.Add(leaderBoardPage);
            Controls.Add(howToPlayPage);
            Controls.Add(homePage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Get Bit";
            ResumeLayout(false);
        }

        #endregion

        private Home homePage;
        private Game gamePage;
        private HowToPlay howToPlayPage;
        private LeaderBoard leaderBoardPage;
        private Setup setupPage;
    }
}
