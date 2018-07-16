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
    public partial class TeacherAttendance : Form
    {
        public WindowManager manager;

        public TeacherAttendance(WindowManager parentManager)
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
    }
}

