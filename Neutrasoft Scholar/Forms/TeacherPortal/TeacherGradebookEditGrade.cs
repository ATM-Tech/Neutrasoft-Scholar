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
    public partial class TeacherGradebookEditGrade : Form
    {
        private int teacherID;
        private int studentID;
        private int assignmentID;
        public List<Assignment> assignments;
        public TeacherGradebookEditGrade(int teacherID, int studentID, int assignmentID, List<Assignment> assignments)
        {
            InitializeComponent();
            this.teacherID = teacherID;
            this.studentID = studentID;
            this.assignmentID = assignmentID;
            this.assignments = assignments;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int gradeint;
            //Checks if text is an integer
            if (int.TryParse(txtGrade.Text, out gradeint) == true)
            {
                //Checks if it is negative
                if (gradeint > 0)
                {
                    //Confirms if they want to submit
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to submit this grade?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Grab student's assignments' grades
                        string query = String.Format("SELECT AssignmentGrades FROM Grades WHERE TeacherID={0} AND StudentID={1}", teacherID, studentID);
                        Dictionary<string, List<string>> output = SQLDatabase.ReadFromSQLServer(query, new List<string> { "AssignmentGrades" });

                        List<string> assignmentGrades = output["AssignmentGrades"][0].Split(',').ToList();

                        assignmentGrades[assignmentID] = txtGrade.Text;

                        string newGrades = assignmentGrades[0];
                        for (int i = 1; i < assignmentGrades.Count; i++)
                        {
                            newGrades += String.Format($",{assignmentGrades[i]}");
                        }


                        //Grabs all of a teacher's students' grades
                        string updateQuery = String.Format($"UPDATE Grades SET AssignmentGrades='{newGrades}' WHERE TeacherID={teacherID} AND StudentID={studentID}");
                        SQLDatabase.WriteToSQLServer(updateQuery);

                        decimal average = Assignment.CalculateAverage(assignments);

                        string averageUpdateQuery = String.Format($"UPDATE Grades SET Average={average} WHERE TeacherID={teacherID} AND StudentID={studentID}");
                        SQLDatabase.WriteToSQLServer(averageUpdateQuery);

                        MessageBox.Show("Grade Submitted.");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please submit a positive number");
                }
               
            }
            else
            {
                MessageBox.Show("Please submit an positive integer");
            }
            
        }
    }
}
