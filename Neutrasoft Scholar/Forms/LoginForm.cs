using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neutrasoft_Scholar.Forms
{
    public partial class LoginForm : Form
    {
        private WindowManager manager;
        public LoginForm(WindowManager parentManager)
        {
            InitializeComponent();
            manager = parentManager;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string passcode = tbPasscode.Text;
            string table;

            if (rdoTeacher.Checked)
            {
                table = "Teachers";            
                if (attemptLogin(username, passcode, table))
                {
                    manager.ActiveTeacher = new Teacher(username);
                    manager.OpenTeacherHome(this);
                }
            }
            else if (rdoStudent.Checked)
            {
                table = "Students";
                if (attemptLogin(username, passcode, table))
                {
                    manager.ActiveStudent = new Student(username);
                    manager.OpenStudentHome(this);
                }
            }
            else
            {
                lblError.Text = "PLEASE SELECT AN OCCUPATION";
                lblError.Visible = true;
            }
        }
        private bool attemptLogin(string username, string passcode, string table)
        {
            //Creates Query and passes it to the ReadSQLServer Method, stores result in output
            string query = "SELECT Username,Passcode " +
                "FROM " + table +
                " WHERE Username='" + username + "'";
            Dictionary<string, List<string>> output = null;
            try
            {
                output = SQLDatabase.ReadFromSQLServer(query, new List<string> { "Username", "Passcode" });
            }
            catch (SQLDatabase.InvalidColumnException e)
            {
                MessageBox.Show("You submitted an invalid query or invalid columns in you SQL Server database request \nDetails: " + e.Message + "\n" + e.StackTrace);
                return false;
            }
            catch (Exception e)
            {

                MessageBox.Show("An error has occured, please restart the program and try again \nDetails: " + e.Message + "\n" + e.StackTrace);
                return false;
            }


            //Checks if nothing was returned
            if (!output["Username"].Any() || !output["Passcode"].Any())
            {
                sendInvalidAccountDetailsError();
                return false;
            }
            //If statements below are redundant, as the If statement above will return if the username or password is blank
            //It is left here for more readabillity
            else if (String.Equals(output["Username"][0], username, StringComparison.OrdinalIgnoreCase))
            {
                if (String.Equals(output["Passcode"][0], passcode))
                {
                    lblError.Text = "LOGIN SUCCESSFUL";
                    lblError.Visible = true;
                    return true;
                }
                else
                {
                    sendInvalidAccountDetailsError();
                    return false;
                }

            }
            sendInvalidAccountDetailsError();
            return false;
        }
        private void sendInvalidAccountDetailsError()
        {
            lblError.Text = "INVALID ACCOUNT DETAILS";
            lblError.Visible = true;
        }
    }
}
