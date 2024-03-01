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
    public partial class ScoreBoard : Form
    {
        public ScoreBoard()
        {
            InitializeComponent();
            Game.createScoreBoard();

            int i = 0;
            winnerNameLabel.Text = Game.connectedPlayers[i].createBoardString() 
                + "   " + Game.connectedPlayers[i].getScore();
            i++;

            playerList.Text += Game.connectedPlayers[i].createBoardString()
                + "   " + Game.connectedPlayers[i].getScore() + "\n\n";
            i++;

            for(i = 2; i < Game.numberOfPlayers; i++)
            {
                playerList.Text += Game.connectedPlayers[i].createBoardString()
                    + "   " + Game.connectedPlayers[i].getScore() + "\n\n";
            }

            this.winnerRowWidth = this.winnerNameLabel.Width + this.winnerLabel.Width + padding;

            this.MinimumSize = new System.Drawing.Size(Math.Max(winnerRowWidth, this.playerList.Width) 
                + 2 * (2 * padding + this.finishButton.Width),
                this.Height);

            this.replaceItems();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScoreBoard_Resize(object sender, EventArgs e)
        {
            this.replaceItems();
        }
    }
}
