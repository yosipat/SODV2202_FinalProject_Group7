using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SODV2202_FinalProject_Group7
{
    public partial class Game : UserControl
    {
        public event EventHandler gameEnded;
        public List<Player> players { get; set; }
        public class GamePlay
        {
            public List<Player> Players { get; set; }
            public int Round { get; set; }
            public List<Player> Eliminated { get; set; }
            public List<Player> Board { get; set; }
        }


        GamePlay gamePlay = new GamePlay();
        private int currentPlayerIndex = 0;
        private string currentPlayerName = "";

        public List<string> Rank = new List<string>();

        public Game()
        {
            InitializeComponent();
        }

        public void gameInitial()
        {
            gamePlay.Players = players;
            gamePlay.Round = 0;
            gamePlay.Eliminated = new List<Player>();
            gamePlay.Board = new List<Player>();

            Rank.Clear(); // clear items in Listview of Rank

            foreach (Player p in players)
            {
                gamePlay.Board.Add(p); // add player to game board
            }

            ShowBoard(); // show initial board
            gameTurn(); // start game
        }


        public void gameTurn()
        {
            currentPlayerName = gamePlay.Players[currentPlayerIndex].Name;
            label2.Text = $"Round {gamePlay.Round}\nIt's {currentPlayerName} turn !";

            if (gamePlay.Players[currentPlayerIndex].Cards.Count() == 2) // check if each players remain 2 cards left
            {
                foreach (Button button in Controls.OfType<Button>())
                {
                    button.Enabled = true;
                }
                gamePlay.Players[currentPlayerIndex].Cards = new List<int> { 1, 2, 3, 4, 5, 6, 7 }; // reset card deck to default
            }
            else
            {
                foreach (Button button in Controls.OfType<Button>())
                {
                    int card = Convert.ToInt32(button.Text);
                    button.Enabled = (gamePlay.Players[currentPlayerIndex].Cards.Contains(card)) ? true : false; // disable button was clicked by each player
                }
            }
        }

        public void btnCardsClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            int pickCard = Convert.ToInt32(btn.Text); // read number of card from text on button 


            gamePlay.Players[currentPlayerIndex].Cards.Remove(pickCard); // remove card which player clicked from card deck
            gamePlay.Players[currentPlayerIndex].PickCard = pickCard; // set number of card which player clicked as current picks


            // check if all player choose their card.
            if (currentPlayerIndex == gamePlay.Players.Count - 1)
            {
                SharkAction();
            }
            else
            {
                currentPlayerIndex++; // next player turn
                gameTurn();
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

        private void SharkAction()
        {
            // order player by card picking
            var board = gamePlay.Players.OrderBy(p => p.PickCard).Select(p => new { p.Name, p.PickCard }).ToList();
            List<Player> orderBoard = gamePlay.Players.OrderBy(p => p.PickCard).ToList();

            if (gamePlay.Round == 0) // round 0 - arrange the player's position and shark can't bite
            {
                gamePlay.Board.Clear();
                foreach (Player p in orderBoard)
                {
                    gamePlay.Board.Add(p);
                }

                MessageBox.Show("Positions were arranged.");
            }
            else
            {
                var result = new List<Player>(gamePlay.Board);

                foreach (Player p in orderBoard)
                {
                    int value = p.PickCard;
                    Player key = p;

                    // search for number of player that have the same card number
                    var n = orderBoard.Where(x => x.PickCard == value).Count();
                    if (n > 1) // if player found the same card number with other player
                    {
                        // do nothing - player will be stay in the same position. 
                    }
                    else
                    {
                        result.Remove(p); // remove player from list
                        result.Add(p); // add player again to list and player's position will move to the last of list
                    }
                }

                gamePlay.Board = result; // position in game board was changed

                Player playerLose = gamePlay.Board.First();
                playerLose.Lives--;

                
                if (playerLose.Lives == 0 || gamePlay.Players.Count == 2)
                {
                    gamePlay.Players.Remove(playerLose);
                    gamePlay.Eliminated.Add(playerLose);
                    gamePlay.Board.Remove(playerLose);

                    Rank.Add(playerLose.Name);
                }

                MessageBox.Show(playerLose.Name + " get bit.");

            }

            if (gamePlay.Players.Count() == 1) // if only 1 player remain in the game
            {
                Rank.Add(gamePlay.Players[0].Name);
                gameEnd();
            }
            else
            {
                ShowBoard(); // update game board
                gamePlay.Round++;
                currentPlayerIndex = 0;
                gameTurn();
            }
        }


        private void ShowBoard()
        {

            ImageList imgList = new ImageList();
            imgList.Images.Add(Image.FromFile(@"img/shark.png"));
            imgList.Images.Add(Image.FromFile(@"img/dive1.png"));
            imgList.Images.Add(Image.FromFile(@"img/dive2.png"));
            imgList.Images.Add(Image.FromFile(@"img/dive3.png"));
            imgList.Images.Add(Image.FromFile(@"img/dive4.png"));
            imgList.Images.Add(Image.FromFile(@"img/dive5.png"));
            imgList.Images.Add(Image.FromFile(@"img/dive6.png"));
            imgList.ImageSize = new Size(100, 100);

            listView1.LargeImageList = imgList;
            listView1.Clear();

            listView1.Items.Add("Shark", 0);
            foreach (var b in gamePlay.Board)
            {
                listView1.Items.Add($"{b.Name}\nLives ({b.Lives})", Convert.ToInt32(b.Name.Substring(b.Name.Length - 1, 1)));
            }

            var w = listView1.GetItemRect(1).Width * (gamePlay.Board.Count() + 1) + gamePlay.Board.Count() + 1;
            var h = listView1.GetItemRect(1).Height + 10;

            listView1.Size = new Size(w, h);
            listView1.Location = new Point((this.ClientSize.Width - w) / 2, (this.ClientSize.Height - 157) / 2 - 40);
        }


        public void gameEnd()
        {
            gameEnded.Invoke(this, EventArgs.Empty);
        }

      

        private void imgExit_Click(object sender, EventArgs e)
        {
            Rank.Clear();
            gameEnd();
        }
    }
}
