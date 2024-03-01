using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHigherLowerGame
{
    class Player
    {
        private Persons person;
        private int score;

        public string createBoardString()
        {
            string s = "";
            s = person.account.userName + " (" + person.firstName + " " + person.lastName + ")";
            return s;
        }
        public string getUserName()
        {
            return person.account.userName;
        }
        public void addPoints(int p)
        {
            this.score += p;
        }

        public int getScore()
        {
            return score;
        }

        public void resetScore()
        {
            score = 0;
        }

        public int getId()
        {
            return (int)this.person.Id;
        }

        public Player(Persons newPerson)
        {
            this.person = newPerson;
            this.score = 0;
        }

        public Player()
        {
            this.person = new Persons();
            this.person.Id = 0;
            this.score = 0;
        }
    }
}
