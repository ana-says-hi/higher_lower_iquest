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
    public partial class Round : Form
    {
        enum AnswerPosibilities
        {
            muchLower,
            lower,
            higher,
            muchHigher,
            unknown
        }

        private Question currentQuestion;
        private int givenAnswer;
        private int currentPlayer;
        private AnswerPosibilities buttonAnswer;
        private int remainedTime;

        public Round()
        {
            InitializeComponent();

            initializeForm();
        }

        private void initializeForm()
        {
            setCurrentRound();

            setStartingPlayer();

            initializeScore();

            writeRoundTitle();

            writeCurrentPlayer();

            writeQuestion();

            enableStarterButtons();

            setStartAnswer();

            startRoundTime();

            this.replaceItems();
        }

        private void initializeScore()
        {
            playerList.Text = "";

            for(int i = 0; i < Game.numberOfPlayers; i++)
            {
                playerList.Text += (i + 1).ToString() + ")   "
                    + Game.connectedPlayers[i].getUserName()
                    + ":     " + Game.connectedPlayers[i].getScore() 
                    + " Points\n\n";
            }
        }
        private void enableStarterButtons()
        {
            muchLowerButton.Hide();
            lowerButton.Hide();
            higherButton.Hide();
            muchHigherButton.Hide();
            player1AnswerLabel.Hide();

            confirmButton.Show();
            answerNumericUpDown.Show();
        }

        private void enableOtherButtons()
        {
            if(givenAnswer > 20)
            {
                muchLowerButton.Show();
            }
            if(givenAnswer > 0)
            {
                lowerButton.Show();
            }
            if(givenAnswer < 100)
            {
                higherButton.Show();
            }
            if(givenAnswer < 80)
            {
                muchHigherButton.Show();
            }

            player1AnswerLabel.Text = Game.connectedPlayers[Game.playerOrder[Game.currentRound, currentPlayer-1]]
                   .getUserName() + " said ";

            if (givenAnswer != -1)
            {
                player1AnswerLabel.Text += " " + givenAnswer.ToString();
            }
            else
            {
                givenAnswer = 0;
                player1AnswerLabel.Text += " 0";
            }

            player1AnswerLabel.Show();

            confirmButton.Hide();
            answerNumericUpDown.Hide();
            this.replaceItems();
        }

        private void verifyAnswer()
        {
            if(currentPlayer == 0)
            {
                if(givenAnswer != -1)
                {
                    int givenAns = givenAnswer;
                    int correctAnsw = currentQuestion.correctAnswer;
                    int points = 0;

                    if (givenAns > correctAnsw)
                    {
                        (givenAns, correctAnsw) = (correctAnsw, givenAns);  //swap
                    }
                    if (correctAnsw - givenAns <= Game.percentErrorAcceptance) 
                    {
                        points = (Game.percentErrorAcceptance - (correctAnsw - givenAns)) * (Game.maxPoints / Game.percentErrorAcceptance);
                        Game.connectedPlayers[Game.playerOrder[Game.currentRound, currentPlayer]].addPoints(points);
                    }
                }
                return;
            }

            switch (buttonAnswer)
            {
                case AnswerPosibilities.muchLower:
                    if (currentQuestion.correctAnswer < (givenAnswer -20)) 
                    {
                        Game.connectedPlayers[Game.playerOrder[Game.currentRound,currentPlayer]].addPoints(200);
                    }
                    break;
                case AnswerPosibilities.lower:
                    if (currentQuestion.correctAnswer < givenAnswer)
                    {
                        Game.connectedPlayers[Game.playerOrder[Game.currentRound,currentPlayer]].addPoints(100);
                    }
                    break;
                case AnswerPosibilities.higher:
                    if (currentQuestion.correctAnswer > givenAnswer)
                    {
                        Game.connectedPlayers[Game.playerOrder[Game.currentRound,currentPlayer]].addPoints(100);
                    }
                    break;
                case AnswerPosibilities.muchHigher:
                    if (currentQuestion.correctAnswer > (givenAnswer + 20))
                    {
                        Game.connectedPlayers[Game.playerOrder[Game.currentRound,currentPlayer]].addPoints(200);
                    }
                    break;
            }
        }

        private bool endOfRound()
        {
            return currentPlayer == Game.numberOfPlayers ? true : false;
        }

        private bool endOfGame()
        {
            return Game.currentRound == Game.numberOfPlayers - 1 ? true : false;
        }

        private void nextPlayer()
        {
            verifyAnswer();
            currentPlayer++;

            if (endOfRound())
            {
                if (endOfGame())
                {
                    this.Close();
                    ScoreBoard scoreBoard = new ScoreBoard();
                    scoreBoard.Show();
                }
                else
                {
                    MessageDial corectAnswerDial = new MessageDial(currentQuestion.correctAnswer.ToString(),5);
                    timer.Stop();
                    corectAnswerDial.ShowDialog();
                    initializeForm();
                }
            }
            else
            {
                initTime();
                writeCurrentPlayer();
            }
        }

        private void isTimeOver()
        {
            if (remainedTime == 0)
            {
                remainedTime = Game.roundTime;
               
                if(currentPlayer == 0)
                {
                    enableOtherButtons();
                }

                nextPlayer();
            }
        }

        private void writeCurrentPlayer()
        {
            if(currentPlayer == 0)
            {
                playerNameLabel.Text = Game.connectedPlayers[Game.playerOrder[Game.currentRound, currentPlayer]]
                   .getUserName() + " must give the %";
            }
            else
            {
                playerNameLabel.Text = Game.connectedPlayers[Game.playerOrder[Game.currentRound, currentPlayer]]
                    .getUserName() + " must answer";
            }
        }

        private void writeRoundTitle()
        {
            this.Text = "Round " + (Game.currentRound + 1).ToString();
            titleLabel.Text = "Round " + (Game.currentRound + 1).ToString();
        }

        private void writeQuestion()
        {
            getQuestion();
            questionTextLabel.Text = currentQuestion.Text;
        }

        private void getQuestion()
        {
            currentQuestion = new Question();
            currentQuestion = Game.selectedQuestions[Game.currentRound];
        }


        private void startRoundTime()
        {
            initTime();
            timer.Start();
        }

        private void initTime()
        {
            remainedTime = Game.roundTime;
            timeLabel.Text = remainedTime.ToString();
        }

        private void setStartAnswer()
        {
            givenAnswer = -1;
            buttonAnswer = AnswerPosibilities.unknown;
        }

        private void setCurrentRound()
        {
            Game.currentRound++;
        }

        private void setStartingPlayer()
        {
            currentPlayer = 0;
        }

        private void muchLowerButton_Click(object sender, EventArgs e)
        {
            buttonAnswer = AnswerPosibilities.muchLower;
            nextPlayer();
        }

        private void lowerButton_Click(object sender, EventArgs e)
        {
            buttonAnswer = AnswerPosibilities.lower;
            nextPlayer();
        }

        private void higherButton_Click(object sender, EventArgs e)
        {
            buttonAnswer = AnswerPosibilities.higher;
            nextPlayer();
        }

        private void muchHigherButton_Click(object sender, EventArgs e)
        {
            buttonAnswer = AnswerPosibilities.muchHigher;
            nextPlayer();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            givenAnswer = (int)answerNumericUpDown.Value;
            verifyAnswer();
            currentPlayer++;
            writeCurrentPlayer();
            enableOtherButtons();
            initTime();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            remainedTime--;
            timeLabel.Text = remainedTime.ToString();
            isTimeOver();
        }

        private void Round_Resize(object sender, EventArgs e)
        {
            this.replaceItems();
        }
    }
}
