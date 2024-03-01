using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHigherLowerGame
{
    class Persons
    {
        public int Id;
        public string firstName;
        public string lastName;
        public string sex;
        public int age;
        public Account account;

        public void addAccount(string u, string p)
        {
            account = new Account(u, p);
        }

        public Persons()
        {
            Id = 0;
        }
    }
}
