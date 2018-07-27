using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neutrasoft_Scholar.Forms.TeacherPortal
{
    public partial class TeacherGradebook : Form
    {
        public WindowManager manager;
        private List<Student> students;

        public TeacherGradebook(WindowManager parentManager)
        {
            InitializeComponent();

            manager = parentManager;

            lblTeacherName.Text = manager.ActiveTeacher.FullName;
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
            manager.OpenTeacherHome(this);
        }

        private void btnGradebook_Click(object sender, EventArgs e)
        {
            manager.OpenTeacherGradebook(this);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            manager.OpenTeacherAttendance(this);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            manager.OpenTeacherSchedule(this);
        }

        private void llbAssignments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TeacherGradebookAssignments teacherGradebookAssignments = new TeacherGradebookAssignments(manager.ActiveTeacher, this);
            teacherGradebookAssignments.ShowDialog();
        }

        private void cmbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Make sure "<Select Period>" isn't the new option
            if (cmbPeriod.SelectedIndex != 0)
            {
                //Iterate through every period, check if it was the one selected, passthrough to FillInTable() if it was
                for (int i = 1; i < 8; i++)
                {
                    if (cmbPeriod.SelectedIndex == i)
                    {
                        FillInTable(i);
                    }
                }
            }
            else
            {
                dgvTeacherGradebook.Visible = false;
            }
        }
        private void FillInTable(int period)
        {
            dgvTeacherGradebook.Rows.Clear();
            dgvTeacherGradebook.Refresh();
            students = null;
            students = new List<Student>();

            //Grabs all the student's in the selected period
            string query = String.Format($"SELECT StudentID,Average FROM Grades WHERE TeacherID={manager.ActiveTeacher.TeacherID} AND Period={period}");
            Dictionary<string, List<string>> output = SQLDatabase.ReadFromSQLServer(query, new List<string> { "StudentID", "Average" });

            for (int i = 0; i < output["StudentID"].Count; i++)
            {
                //Constructs a student and average string
                Student student = new Student(int.Parse(output["StudentID"][i]));
                students.Add(student);
                string average = String.Format($"{output["Average"][i]} ({Assignment.GetLetterGrade(int.Parse(output["Average"][i]))})");

                DataGridViewRow row = (DataGridViewRow)dgvTeacherGradebook.RowTemplate.Clone();
                row.CreateCells(dgvTeacherGradebook);
                row.Cells[0].Value = student.FullName;
                row.Cells[1].Value = average;
                row.Height = 35;

                dgvTeacherGradebook.Rows.Add(row);
            }
            dgvTeacherGradebook.Visible = true;
        }

        private void dgvTeacherGradebook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //If a column containing a button is clicked, open assignments breakdown based on row
            if (e.ColumnIndex == 2)
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (e.RowIndex == i)
                    {
                        TeacherGradebookStudentAssignments teacherGradebookStudentAssignments = new TeacherGradebookStudentAssignments(students[i], manager.ActiveTeacher);
                        teacherGradebookStudentAssignments.ShowDialog();
                    }
                }
            }
        }
    }
}

