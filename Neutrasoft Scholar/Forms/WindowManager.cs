using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Neutrasoft_Scholar.Forms;

namespace Neutrasoft_Scholar
{
    public partial class WindowManager : Form
    {
        private FormClosedEventHandler formClosedHandler;
        public Student ActiveStudent { get; set; }
        public Teacher ActiveTeacher { get; set; }
        public WindowManager()
        {
            InitializeComponent();
            formClosedHandler = (s, args) => this.Close();

            LoginForm loginForm = new LoginForm(this);
            loginForm.FormClosed += formClosedHandler;
            loginForm.Show();
            this.Hide();
        }
        public void OpenStudentHome(Form caller)
        {

            //Opens student home
            Forms.StudentPortal.StudentHome studentPage = new Forms.StudentPortal.StudentHome(this)
            {
                Location = caller.Location,
                StartPosition = FormStartPosition.Manual
            };
            studentPage.Show();

            //Closes last form
            caller.FormClosed -= formClosedHandler;
            caller.Close();

            studentPage.FormClosed += formClosedHandler;

        }
        public void OpenStudentGradebook(Form caller)
        {

            //Opens student home
            Forms.StudentPortal.StudentGradebook studentPage = new Forms.StudentPortal.StudentGradebook(this)
            {
                Location = caller.Location,
                StartPosition = FormStartPosition.Manual
            };
            studentPage.Show();


            //Closes last form
            caller.FormClosed -= formClosedHandler;
            caller.Close();

            studentPage.FormClosed += formClosedHandler;

        }
        public void OpenStudentAttendance(Form caller)
        {

            //Opens student home
            Forms.StudentPortal.StudentAttendance studentPage = new Forms.StudentPortal.StudentAttendance(this)
            {
                Location = caller.Location,
                StartPosition = FormStartPosition.Manual
            };
            studentPage.Show();


            //Closes last form
            caller.FormClosed -= formClosedHandler;
            caller.Close();

            studentPage.FormClosed += formClosedHandler;

        }
        public void OpenStudentSchedule(Form caller)
        {

            //Opens student home
            Forms.StudentPortal.StudentSchedule studentPage = new Forms.StudentPortal.StudentSchedule(this)
            {
                Location = caller.Location,
                StartPosition = FormStartPosition.Manual
            };
            studentPage.Show();


            //Closes last form
            caller.FormClosed -= formClosedHandler;
            caller.Close();

            studentPage.FormClosed += formClosedHandler;

        }
        public void OpenTeacherHome(Form caller)
        {

            //Opens student home
            Forms.TeacherPortal.TeacherHome teacherPage = new Forms.TeacherPortal.TeacherHome(this)
            {
                Location = caller.Location,
                StartPosition = FormStartPosition.Manual
            };
            teacherPage.Show();

            //Closes last form
            caller.FormClosed -= formClosedHandler;
            caller.Close();

            teacherPage.FormClosed += formClosedHandler;

        }
        public void OpenTeacherGradebook(Form caller)
        {

            //Opens student home
            Forms.TeacherPortal.TeacherGradebook teacherPage = new Forms.TeacherPortal.TeacherGradebook(this)
            {
                Location = caller.Location,
                StartPosition = FormStartPosition.Manual
            };
            teacherPage.Show();

            //Closes last form
            caller.FormClosed -= formClosedHandler;
            caller.Close();

            teacherPage.FormClosed += formClosedHandler;

        }
        public void OpenTeacherAttendance(Form caller)
        {

            //Opens student home
            Forms.TeacherPortal.TeacherAttendance teacherPage = new Forms.TeacherPortal.TeacherAttendance(this)
            {
                Location = caller.Location,
                StartPosition = FormStartPosition.Manual
            };
            teacherPage.Show();

            //Closes last form
            caller.FormClosed -= formClosedHandler;
            caller.Close();

            teacherPage.FormClosed += formClosedHandler;

        }
        public void OpenTeacherSchedule(Form caller)
        {

            //Opens student home
            Forms.TeacherPortal.TeacherSchedule teacherPage = new Forms.TeacherPortal.TeacherSchedule(this)
            {
                Location = caller.Location,
                StartPosition = FormStartPosition.Manual
            };
            teacherPage.Show();

            //Closes last form
            caller.FormClosed -= formClosedHandler;
            caller.Close();

            teacherPage.FormClosed += formClosedHandler;

        }
    }
}
