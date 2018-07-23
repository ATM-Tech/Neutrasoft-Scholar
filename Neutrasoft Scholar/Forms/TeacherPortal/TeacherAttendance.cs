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
        private List<Student> studentList;
        private List<string> attendanceList;

        public TeacherAttendance(WindowManager parentManager)
        {
            InitializeComponent();

            manager = parentManager;

            lblTeacherName.Text = manager.ActiveTeacher.FullName;
            //Sets date label to the format "DayOfTheWeek, NameOfMonth DayNumber, YearNumber" of the current date
            string dateString = String.Format("{0:dddd, MMMM dd, yyyy}", DateTime.Now);
            lblDate.Text = "Attendance for " + dateString + ":";


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

        private void dgvTeacherAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Make sure that only one checkbox is checked
            //If a cell contatining a checkbox was clicked
            if (e.RowIndex >= 0 && e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                //If the clicked checkbox is currently unchecked 
                if (Convert.ToInt16(dgvTeacherAttendance.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == 0)
                {
                    //Uncheck all other checkboxes
                    if (e.ColumnIndex == 1)
                    {
                        dgvTeacherAttendance.Rows[e.RowIndex].Cells[2].Value = 0;
                        dgvTeacherAttendance.Rows[e.RowIndex].Cells[3].Value = 0;
                    }
                    else if (e.ColumnIndex == 2)
                    {
                        dgvTeacherAttendance.Rows[e.RowIndex].Cells[1].Value = 0;
                        dgvTeacherAttendance.Rows[e.RowIndex].Cells[3].Value = 0;
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        dgvTeacherAttendance.Rows[e.RowIndex].Cells[1].Value = 0;
                        dgvTeacherAttendance.Rows[e.RowIndex].Cells[2].Value = 0;
                    }
                }
                //Recheck box if unchecked
                else
                {
                    if (e.ColumnIndex == 1)
                    {
                        dgvTeacherAttendance.Rows[e.RowIndex].Cells[2].Value = 1;
                    }
                    else if (e.ColumnIndex == 2)
                    {
                        dgvTeacherAttendance.Rows[e.RowIndex].Cells[1].Value = 1;
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        dgvTeacherAttendance.Rows[e.RowIndex].Cells[1].Value = 1;
                    }
                }
            }
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
                        //If the period's attendance wasn't already selected.
                        if (NotSubmitted(i))
                        {
                            FillInTable(i);
                            break;
                        }

                    }
                }
            }
        }
        private void FillInTable(int period)
        {
            //Clears old data from the table and reset studentList
            dgvTeacherAttendance.Rows.Clear();
            dgvTeacherAttendance.Refresh();
            studentList = null;
            studentList = new List<Student>();

            string query = String.Format("SELECT StudentID FROM Grades WHERE TeacherID={0} AND Period={1}", manager.ActiveTeacher.TeacherID, period);
            Dictionary<string, List<string>> output = SQLDatabase.ReadFromSQLServer(query, new List<string> { "StudentID" });
            foreach (string studentIDString in output["StudentID"])
            {
                //Creates a student for each StudentID
                Student student = new Student(int.Parse(studentIDString));

                studentList.Add(student);

                //Creates a row and fills the cells in with data relating to the columns. Also sets height. Checks 'Present?' by default
                DataGridViewRow row = (DataGridViewRow)dgvTeacherAttendance.RowTemplate.Clone();
                row.CreateCells(dgvTeacherAttendance);
                row.Cells[0].Value = student.FullName;
                row.Cells[1].Value = 1;
                row.Height = 25;

                //Adds row to table
                dgvTeacherAttendance.Rows.Add(row);
                dgvTeacherAttendance.Visible = true;
                btnSubmit.Visible = true;
            }
        }

        private Boolean NotSubmitted(int period)
        {
            //Query all attendance records for the current period and date
            string attendanceQuery = String.Format("SELECT StudentID FROM Attendance WHERE Date='{0}' AND Period={1}", DateTime.Now.ToString("yyyy-MM-dd"), period);
            Dictionary<string, List<string>> attendanceOutput = SQLDatabase.ReadFromSQLServer(attendanceQuery, new List<string> { "StudentID" });
            if (!attendanceOutput["StudentID"].Any())
            {
                //Return true if no attendance records are found
                return true;
            }
            else
            {
                //Querys for the teacher's students of the period
                string studentsQuery = String.Format("SELECT StudentID FROM Grades WHERE TeacherID={0} AND Period={1}", manager.ActiveTeacher.TeacherID, period);
                Dictionary<string, List<string>> studentsOutput = SQLDatabase.ReadFromSQLServer(studentsQuery, new List<string> { "StudentID" });
                //Checks if teacher's students match the attendance records.
                foreach (string classStudentIDString in studentsOutput["StudentID"])
                {
                    foreach (string attendanceStudentIDString in attendanceOutput["StudentID"])
                    {
                        if (classStudentIDString == attendanceStudentIDString)
                        {
                            MessageBox.Show("Attendance for this class has already been submitted today");
                            cmbPeriod.SelectedIndex = 0;
                            dgvTeacherAttendance.Visible = false;
                            btnSubmit.Visible = false;
                            return false;
                        }
                    }
                }
                return true;
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string query = "";
            attendanceList = new List<string>();
            //Iterates through rows and add attendance state to list
            foreach (DataGridViewRow row in dgvTeacherAttendance.Rows)
            {
                if (Convert.ToBoolean(row.Cells[1].Value))
                {
                    attendanceList.Add("Present");
                }
                else if (Convert.ToBoolean(row.Cells[2].Value))
                {
                    attendanceList.Add("Tardy");
                }
                else if (Convert.ToBoolean(row.Cells[3].Value))
                {
                    attendanceList.Add("Absent");
                }
                else
                {
                    MessageBox.Show("You did not select an attendance state for all students");
                    return;
                }
            }

            for (int i = 0; i < studentList.Count; i++)
            {
                //Builds insert query with StudentID and the Attendance states from attendanceList
                query += String.Format("INSERT INTO Attendance (StudentID,Date,Period,Attendance,Excused) values ({0},getdate(),{1},'{2}',0);", studentList[i].StudentID, cmbPeriod.SelectedIndex, attendanceList[i]);
            }

            //Runs query
            SQLDatabase.WriteToSQLServer(query);

            MessageBox.Show("Attendance Logged");
            cmbPeriod.SelectedIndex = 0;
            dgvTeacherAttendance.Visible = false;
            btnSubmit.Visible = false;
        }

    }

}

