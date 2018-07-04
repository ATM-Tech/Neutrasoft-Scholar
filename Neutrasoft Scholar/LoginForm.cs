using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neutrasoft_Scholar
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string passcode = passcodeTextBox.Text;
            string table;

            if (teacherRadioButton.Checked)
            {
                table = "Teachers";            
                if (attemptLogin(username, passcode, table))
                {

                }
            }
            else if (studentRadioButton.Checked)
            {
                table = "Students";
                if (attemptLogin(username, passcode, table))
                {

                }
            }
            else
            {
                errorLabel.Text = "PLEASE SELECT AN OCCUPATION";
                errorLabel.Visible = true;
            }
        }
        private bool attemptLogin(string username, string passcode, string table)
        {
            //Creates Query and passes it to the ReadSQLServer Method, stores result in output
            string query = "SELECT Username,Passcode " +
                "FROM " + table +
                " WHERE Username='" + username + "'";
            Dictionary<string, List<string>> output = SQLDatabase.ReadFromSQLServer(query, new List<string> {"Username","Passcode"});


            //Checks if nothing was returned
            if (!output["Username"].Any() || !output["Passcode"].Any())
            {
                errorLabel.Text = "INVALID ACCOUNT DETAILS";
                errorLabel.Visible = true;
                return false;
            }
            //If statements below are redundant, as the If statement above will return if the username or password is blank
            //It is left here for more readabillity
            else if (output["Username"][0] == username)
            {
                if (output["Passcode"][0] == passcode)
                {
                    errorLabel.Text = "LOGIN SUCCESSFUL";
                    errorLabel.Visible = true;
                    return true;
                }
                else
                {
                    errorLabel.Text = "INVALID ACCOUNT DETAILS";
                    errorLabel.Visible = true;
                    return true;
                }

            }
            return false;
        }
    }
}
