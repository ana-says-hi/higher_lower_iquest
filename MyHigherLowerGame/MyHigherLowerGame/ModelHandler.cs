using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHigherLowerGame
{
    static class ModelHandler
    {
        static private List<Question> allQuestions = new List<Question>();
        static private List<Persons> allPersons = new List<Persons>(); 

        static public void _initData()
        {
            _initPersons();
            _initQuestions();
        }
        static private void _initQuestions()
        {
            string path = "Questions.txt";

            using ( StreamReader sr = File.OpenText(path))
            {
                string s;
                
                while ((s = sr.ReadLine()) != null)
                {
                    Question q = new Question();
                    string[] line = s.Split('*');

                    q.Id = Int32.Parse(line[0]);
                    q.Text = line[1];
                    q.correctAnswer = Int32.Parse(line[2]);

                    allQuestions.Add(q);
                }
            }  
        }

        static private void _initPersons()
        {
            string path = "Persons.txt";
      
            using (StreamReader sr = File.OpenText(path))
            {

                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Persons p = new Persons();
                    string[] line = s.Split('*');

                    p.Id = Int32.Parse(line[0]);
                    p.firstName = line[1];
                    p.lastName = line[2];
                    p.sex = line[3];
                    p.age = Int32.Parse(line[4]);
                    p.account = new Account(line[5], line[6]);

                    allPersons.Add(p);
                }
            }
        }
        static public void _createAcount(Persons person)
        {
            bool exists = false;
            foreach (Persons p in allPersons)
            {
                if (p.account.userName.Equals(person.account.userName))
                {
                    exists = true;
                }
            }

            if (exists)
            {
                MessageDial messageDial = new MessageDial("", 2);
                messageDial.ShowDialog();
            }
            else
            {
                allPersons.Add(person);
                _savePerson();
                MessageDial messageDial = new MessageDial("", 1);
                messageDial.ShowDialog();
            }
        }

        static private void _savePerson()
        {
            string path = "Persons.txt";

            using (StreamWriter sw = File.CreateText(path))
            {
                foreach(Persons p in allPersons)
                {
                    string line = "";

                    line += p.Id + "*" + p.firstName + "*" + p.lastName + "*"
                        + p.sex + "*" + p.age.ToString() + "*" + p.account.userName
                        + "*" + p.account.passWord;

                    sw.WriteLine(line);
                }
            }
        }

        static public Question _getQuestionById(int id)
        {
            foreach(Question q in allQuestions)
            {
                if (q.Id == id)
                    return q;
            }

            return new Question();
        }

        static public Persons _searchPerson(string userName, string passWord)
        {
            Persons pers = new Persons();
            pers.Id = 0;
            foreach (Persons p in allPersons)
            {
                if (p.account.userName.Equals(userName)
                    && p.account.passWord.Equals(passWord))
                {
                    return p;
                }
            }
            return pers;
        }

        static public int _getNumberOfQuestions()
        {
            return allQuestions.Count();
        }

        static public int _getNumberOfPersons()
        {
            return allPersons.Count();
        }

        
    }
}
