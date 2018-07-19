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
    public partial class TeacherSchedule : Form
    {
        public WindowManager manager;

        public TeacherSchedule(WindowManager parentManager)
        {
            InitializeComponent();

            manager = parentManager;

            lblTeacherName.Text = manager.ActiveTeacher.FullName;
            cmbPeriod.SelectedIndex = 0;
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
                        break;
                    }
                }
            }
        }

        private void FillInTable(int period)
        {
            //Clears old data from the table
            dgvTeacherSchedule.Rows.Clear();
            dgvTeacherSchedule.Refresh();

            string query = String.Format("SELECT StudentID FROM Grades WHERE TeacherID={0} AND Period={1}", manager.ActiveTeacher.TeacherID, period);
            Dictionary<string, List<string>> output = SQLDatabase.ReadFromSQLServer(query, new List<string> { "StudentID" });
            foreach (string studentIDString in output["StudentID"])
            {
                //Creates a student for each StudentID
                Student student = new Student(int.Parse(studentIDString));

                //Creates a row and fills the cells in with data relating to the columns. Also sets height
                DataGridViewRow row = (DataGridViewRow)dgvTeacherSchedule.RowTemplate.Clone();
                row.CreateCells(dgvTeacherSchedule);
                row.Cells[0].Value = student.FullName;
                row.Cells[1].Value = student.Gender;
                row.Height = 25;

                //Adds row to table
                dgvTeacherSchedule.Rows.Add(row);
                dgvTeacherSchedule.Visible = true;
            }
        }
    }
}

