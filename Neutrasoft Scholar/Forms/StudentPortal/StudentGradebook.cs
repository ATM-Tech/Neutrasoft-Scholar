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
    public partial class StudentGradebook : Form
    {
        public WindowManager manager;
        private Teacher[] teachers;

        public StudentGradebook(WindowManager parentManager)
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
            //Grabs all the periods and correlated TeacherIDs related to the Active Student
            string query = String.Format("SELECT Period,TeacherID FROM Grades WHERE StudentID={0} ORDER BY Period", manager.ActiveStudent.StudentID);
            Dictionary<string, List<string>> output = SQLDatabase.ReadFromSQLServer(query, new List<string> { "Period", "TeacherID" });

            //Initializes teacher list
            teachers = new Teacher[7];

            for (int i = 0; i < 7; i++)
            {
                //Constructs a Teacher for each period
                Teacher teacher = new Teacher(int.Parse(output["TeacherID"][i]));

                teachers[i] = teacher;

                //Finds averages
                string averageQuery = String.Format("SELECT Average from Grades WHERE StudentID={0} AND TeacherID={1}", manager.ActiveStudent.StudentID, teacher.TeacherID);
                int average = int.Parse(SQLDatabase.ReadFromSQLServer(averageQuery, new List<string> { "Average" })["Average"][0]);

                string period = "Period " + (i + 1);
                string teacherName = teacher.Pronoun + teacher.FullNameWithoutMiddleName;

                //Creates a row and fills the cells in with data relating to the columns. Also sets height
                DataGridViewRow row = (DataGridViewRow)dgvStudentGradebook.RowTemplate.Clone();
                row.CreateCells(dgvStudentGradebook);
                row.Cells[0].Value = period;
                row.Cells[1].Value = teacherName;
                row.Cells[2].Value = teacher.Subject;
                row.Cells[3].Value = average;
                row.Height = 75;

                //Adds row to table
                dgvStudentGradebook.Rows.Add(row);
            }
        }

        private void dgvStudentGradebook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //If a column containing a button is clicked, open assignments breakdown based on row
            if (e.ColumnIndex == 4)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (e.RowIndex == i)
                    {
                        StudentGradebookAssignments studentGradebookAssignments = new StudentGradebookAssignments(teachers[i], manager.ActiveStudent);
                        studentGradebookAssignments.ShowDialog();
                    }
                }
            }
        }
    }
}
