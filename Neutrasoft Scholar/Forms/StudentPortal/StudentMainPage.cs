using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Neutrasoft_Scholar.StudentPortal
{
    public partial class StudentMainPage : Form
    {
        private Student student;
        public StudentMainPage(Student passthroughStudent)
        {
            InitializeComponent();
            this.Text = "Neutrasoft Scholar: Student Home";
            student = passthroughStudent;

            lblStudentName.Text = student.FullName;
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
            MessageBox.Show("This page is already open");
        }

        private void btnGradebook_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
