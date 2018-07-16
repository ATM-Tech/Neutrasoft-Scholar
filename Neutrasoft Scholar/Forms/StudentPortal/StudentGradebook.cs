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

        public StudentGradebook(WindowManager parentManager)
        {
            InitializeComponent();

            manager = parentManager;

            lblStudentName.Text = manager.ActiveStudent.FullName;
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
    }
}
