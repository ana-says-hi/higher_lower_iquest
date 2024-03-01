using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHigherLowerGame
{
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
            startButton.Enabled = false;
            this.replaceItems();
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.ShowDialog();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (allFilled().Equals("true"))
            {
                Persons newPerson = new Persons();

                newPerson = ModelHandler._searchPerson(userNameTextBox.Text, passWordTextBox.Text);

                if(newPerson.Id != 0)
                {
                    Player newPlayer = new Player(newPerson);
                    bool good = Game.addPlayer(newPlayer);
                    if (good)
                    {
                        playerList.Text += Game.numberOfPlayers.ToString() 
                            + ")  "
                            + newPlayer.createBoardString()
                            + "\n\n";

                        userNameTextBox.Text = "";
                        passWordTextBox.Text = "";

                        if (Game.numberOfPlayers >= 2)
                        {
                            startButton.Enabled = true;
                        }

                        if (Game.numberOfPlayers == 8)
                        {
                            logInButton.Enabled = false;
                        }
                    }
                    else
                    {
                        userNameTextBox.Text = "";
                        passWordTextBox.Text = "";

                        MessageDial messageDial = new MessageDial("", 4);
                        messageDial.ShowDialog();
                    }
                }
                else
                {
                    MessageDial messageDial = new MessageDial("", 3);  
                    messageDial.ShowDialog();
                }
            }
            else
            {
                MessageDial messageDial = new MessageDial(allFilled(), 0); // types are explained at 
                messageDial.ShowDialog();                                  // MessageDial constructor
            }
        }

        private string allFilled()
        {
            string answer = "";

            if (string.IsNullOrEmpty(userNameTextBox.Text)
                || string.IsNullOrWhiteSpace(userNameTextBox.Text))
            {
                answer += "User*";
            }
            if (string.IsNullOrEmpty(passWordTextBox.Text)
                || string.IsNullOrWhiteSpace(passWordTextBox.Text))
            {
                answer += "Pass*";
            }
            return answer.Equals("") ? "true" : answer;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Game.prepareGame();

            Round firstRound = new Round();
            firstRound.Show();
        }

        private void clearPlayers_Click(object sender, EventArgs e)
        {
            Game.numberOfPlayers = 0;
            Game.connectedPlayers = new Player[8];
            playerList.Text = "";
            startButton.Enabled = false;
            logInButton.Enabled = true;
        }

        private void resetScoreButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Game.numberOfPlayers; i++) 
            {
                Game.connectedPlayers[i].resetScore();
            }
        }

        private void Lobby_Resize(object sender, EventArgs e)
        {
            this.replaceItems();
        }
    }
}
