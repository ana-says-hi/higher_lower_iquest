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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
            this.replaceItems();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Persons person = new Persons();
            
            if (allFilled().Equals("true"))
            {
                person.Id = ModelHandler._getNumberOfPersons() + 1;
                person.firstName = FNTextBox.Text;
                person.lastName = LNTextBox.Text;
                person.age = (int)ageNumericUpDown.Value;
                person.addAccount(userNameTextBox.Text, passWordTextBox.Text);
                string sex = "";

                if (mRadioButton.Checked)
                {
                    person.sex = "Male";
                }
                else if (fRadioButton.Checked)
                {
                    person.sex = "Female";
                }

                ModelHandler._createAcount(person);
                this.Close();
            }
            else
            {
                MessageDial messageDial = new MessageDial(allFilled(),0); // types are explained at 
                messageDial.ShowDialog();                                 // MessageDial constructor
            }
            
        }

        private string allFilled()
        {
            string answer = "";
            
            if (string.IsNullOrEmpty(FNTextBox.Text) 
                || string.IsNullOrWhiteSpace(FNTextBox.Text))
            { 
                answer += "FN*";
            }
            if (string.IsNullOrEmpty(LNTextBox.Text)
                || string.IsNullOrWhiteSpace(LNTextBox.Text))
            {
                answer += "LN*";
            }
            if (string.IsNullOrEmpty(ageNumericUpDown.Text)
                || string.IsNullOrWhiteSpace(ageNumericUpDown.Text)
                || ageNumericUpDown.Value <= 0)
            {
                answer += "Age*";
            }
            if (!fRadioButton.Checked && !mRadioButton.Checked)
            {
                answer += "Sex*";
            }
            if (string.IsNullOrEmpty(userNameTextBox.Text)
                || string.IsNullOrWhiteSpace(userNameTextBox.Text))
            {
                answer += "User*";
            }
            if (string.IsNullOrEmpty(passWordTextBox.Text)
                || string.IsNullOrWhiteSpace(passWordTextBox.Text))
            {
                answer+="Pass*";
            }

            return answer.Equals("") ? "true" : answer;
        }

        private void CreateAccount_Resize(object sender, EventArgs e)
        {
            this.replaceItems();
        }
    }
}
