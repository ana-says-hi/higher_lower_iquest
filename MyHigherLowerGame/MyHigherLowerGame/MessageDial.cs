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
    public partial class MessageDial : Form
    {
        
        public MessageDial(string x, int type)                  //0 is for Create Account Error
        {                                                       //1 is for Successfully Created Account
            InitializeComponent();
                                                                //2 is for Username already taken
            switch(type)                                        //3 is for User doesn't exists
            {                                                   //4 is for Player already entered the game
                case 0:                                         //5 is for Correct answer
                    msgLabel.Text = createErrorMessage(x);
                    this.Text = "Error";
                    break;
                case 1:
                    msgLabel.Text = "Account created sucessfully";
                    this.Text = "Message";
                    break;
                case 2:
                    msgLabel.Text = "Username already exists";
                    this.Text = "Alert";
                    break;
                case 3:
                    msgLabel.Text = "This account doesn't exist";
                    this.Text = "Alert";
                    break;
                case 4:
                    msgLabel.Text = "This person already entered the game";
                    this.Text = "Alert";
                    break;
                case 5:
                    msgLabel.Text = "The answer was: " + x;
                    this.Text = "Answer";
                    break;
                default:
                    break;
            }

            this.replaceItems();
        }
        private string createErrorMessage(string error)
        {
            string errorMsg = "Please fill the following boxes:\n";
            var row = error.Split('*');
            int ct = 0, n = row.Length;

            foreach(string e in row)
            {
                switch (e)
                {
                    case "FN":
                        errorMsg += "First Name";
                        ct++;
                        errorMsg += addSeparators(ct, n);
                        break;
                    case "LN":
                        errorMsg += "Last Name";
                        ct++;
                        errorMsg += addSeparators(ct, n);
                        break;
                    case "Age":
                        errorMsg += "Age";
                        ct++;
                        errorMsg += addSeparators(ct, n);
                        break;
                    case "Sex":
                        errorMsg += "Sex";
                        ct++;
                        errorMsg += addSeparators(ct, n);
                        break;
                    case "User":
                        errorMsg += "Username";
                        ct++;
                        errorMsg += addSeparators(ct, n);
                        break;
                    case "Pass":
                        errorMsg += "Password";
                        ct++;
                        errorMsg += addSeparators(ct, n);
                        break;
                }
            }

            return errorMsg;
        }

        private string addSeparators(int x, int y)
        {
            string r = "";

            if (x < y - 1)
            {
                r += ",";
            }

            if (x % 3 == 0)
            {
                r += '\n';
            }

            return r;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MessageDial_Resize(object sender, EventArgs e)
        {
            this.replaceItems();
        }
    }
}
