using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHigherLowerGame
{
    static class Game
    {
        public static int numberOfPlayers;
        public static int currentRound;
        public static Player[] connectedPlayers = new Player[8];
        public static Question[] selectedQuestions = new Question[8];
        public static int[,] playerOrder = new int[8,8];
        public static int roundTime = 15;
        public static int percentErrorAcceptance = 15;
        public static int maxPoints = 300;

        private static int numberOfQuestions = ModelHandler._getNumberOfQuestions();

        public static void prepareGame()
        {
            currentRound = -1;
            getQuestions();
            createPlayerOrder();
        }
        public static bool addPlayer(Player newPlayer)
        {
            if (!alreadyEntered(newPlayer.getId()))
            {
                connectedPlayers[numberOfPlayers] = newPlayer;
                numberOfPlayers++;

                return true;
            }

            return false;
        }
        
        public static void createScoreBoard()
        {
            sortPlayersByScore();
        }

        private static void getQuestions()
        {
            Random rand = new Random();
            int[] v = new int[8];

            for(int i = 0; i < numberOfPlayers; i++)
            {
                bool alreadyTaken = true;

                while(alreadyTaken)
                {
                    v[i] = rand.Next(0, numberOfQuestions);
                    alreadyTaken = false;

                    for(int j = 0; j < i; j++)
                    {
                        if(v[j] == v[i])
                        {
                            alreadyTaken = true;
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < numberOfPlayers; i++)
            {
                selectedQuestions[i] = ModelHandler._getQuestionById(v[i]);
            }
        }

        private static void createPlayerOrder()
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                for (int j = 0; j < numberOfPlayers; j++)
                {
                    playerOrder[i,j] = (i + j) % numberOfPlayers;
                }
            }
        }

        private static void sortPlayersByScore()
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                for (int j = i; j < numberOfPlayers; j++)
                {
                    if(connectedPlayers[i].getScore() < connectedPlayers[j].getScore())
                    {
                        Player aux = new Player();

                        aux = connectedPlayers[i];
                        connectedPlayers[i] = connectedPlayers[j];
                        connectedPlayers[j] = aux;
                    }
                }
            }
        }

        private static bool alreadyEntered(int playerId)
        {
            for(int i = 0; i < numberOfPlayers; i++)
            {
                if (connectedPlayers[i].getId() == playerId)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
