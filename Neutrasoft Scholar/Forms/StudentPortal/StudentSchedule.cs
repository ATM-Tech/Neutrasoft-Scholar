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
    public partial class StudentSchedule : Form
    {
        public WindowManager manager;

        public StudentSchedule(WindowManager parentManager)
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

            string query = String.Format("SELECT Period,TeacherID FROM Grades WHERE StudentID={0} ORDER BY Period", manager.ActiveStudent.StudentID);
            Dictionary<string, List<string>> output = SQLDatabase.ReadFromSQLServer(query, new List<string> { "Period", "TeacherID" });
            for (int i = 0; i < 7; i++)
            {
                Teacher teacher = new Teacher(int.Parse(output["TeacherID"][i]));

                string period = "Period " + (i + 1);
                string teacherName = teacher.Pronoun + teacher.FullNameWithoutMiddleName;

                
                DataGridViewRow row = (DataGridViewRow)dgvStudentSchedule.RowTemplate.Clone();
                row.CreateCells(dgvStudentSchedule);
                row.Cells[0].Value = period;
                row.Cells[1].Value = teacherName;
                row.Cells[2].Value = teacher.Subject;
                row.Cells[3].Value = teacher.RoomNumber;
                row.Height = 75;

                dgvStudentSchedule.Rows.Add(row);
            }
        }
    }
}
