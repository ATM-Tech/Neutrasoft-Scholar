using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neutrasoft_Scholar.Forms.StudentPortal
{
    public partial class StudentAttendance : Form
    {
        public WindowManager manager;


        public StudentAttendance(WindowManager parentManager)
        {
            InitializeComponent();

            manager = parentManager;

            lblStudentName.Text = manager.ActiveStudent.FullName;

            FillInTable();
        }

        private void llbExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void llbMyAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO Open personal information page
        }

        private void llbLoginHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO Open Login History
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            manager.OpenStudentHome(this);
        }

        private void btnGradebook_Click(object sender, EventArgs e)
        {
            manager.OpenStudentGradebook(this);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            manager.OpenStudentAttendance(this);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            manager.OpenStudentSchedule(this);
        }

        private void FillInTable()
        {
            //Grabs the date, period, attendance state, and excused of all of a student's absences or tardies 
            string query = String.Format("SELECT Date,Period,Attendance,Excused FROM Attendance WHERE (Attendance='Tardy' OR Attendance='Absent') AND StudentID={0} ORDER BY Date DESC", manager.ActiveStudent.StudentID);
            Dictionary<string, List<string>> output = SQLDatabase.ReadFromSQLServer(query, new List<string> { "Date", "Period", "Attendance", "Excused" });
            for (int i = 0; i < output["Attendance"].Count; i++)
            {
                //Turns Excused from False/True to No/Yes
                string readableExcused = "";
                if (output["Excused"][i] == "False")
                {
                    readableExcused = "No";
                }
                else if (output["Excused"][i] == "True")
                {
                    readableExcused = "Yes";
                }

                //Creates a date string of the format "DayOfTheWeek, NameOfMonth DayNumber, YearNumber"
                DateTime dateTime = DateTime.Parse(output["Date"][i]);
                string date = String.Format("{0:dddd, MMMM dd, yyyy}", dateTime);

                //Creates a row and fills the cells in with data relating to the columns. Also sets height
                DataGridViewRow row = (DataGridViewRow)dgvStudentAttendance.RowTemplate.Clone();
                row.CreateCells(dgvStudentAttendance);
                row.Cells[0].Value = date;
                row.Cells[1].Value = output["Period"][i];
                row.Cells[2].Value = output["Attendance"][i];
                row.Cells[3].Value = readableExcused;
                row.Height = 50;

                //Adds row to table
                dgvStudentAttendance.Rows.Add(row);
            }
        }
    }
}
