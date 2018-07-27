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
    public partial class TeacherGradebookNewAssignment : Form
    {
        private Teacher teacher;
        private TeacherGradebookAssignments caller;
        public TeacherGradebookNewAssignment(Teacher senderTeacher, TeacherGradebookAssignments sender)
        {
            InitializeComponent();
            cmbType.SelectedIndex = 0;
            teacher = senderTeacher;
            caller = sender;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Confirms if they want to submit
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to create this assignment?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Grab teacher's assignments
                string teacherAssignmentsQuery = String.Format("SELECT Assignments,AssignmentTypes FROM Teachers WHERE TeacherID={0}", teacher.TeacherID);
                Dictionary<string, List<string>> teacherAssignmentsOutput = SQLDatabase.ReadFromSQLServer(teacherAssignmentsQuery, new List<string> { "Assignments", "AssignmentTypes" });

                //Appends new assignment type and name
                string newAssignmentNames = teacherAssignmentsOutput["Assignments"][0] + "," + txtName.Text;
                string newAssignmentTypes = teacherAssignmentsOutput["AssignmentTypes"][0] + "," + cmbType.Text;

                //Updates database
                string updateTeacherAssignmentNamesQuery = String.Format($"UPDATE Teachers SET Assignments='{newAssignmentNames}' WHERE TeacherID={teacher.TeacherID}");
                SQLDatabase.WriteToSQLServer(updateTeacherAssignmentNamesQuery);
                string updateTeacherAssignmentTypesQuery = String.Format($"UPDATE Teachers SET AssignmentTypes='{newAssignmentTypes}' WHERE TeacherID={teacher.TeacherID}");
                SQLDatabase.WriteToSQLServer(updateTeacherAssignmentTypesQuery);


                //Grabs all of a teacher's students' grades
                string studentGradesQuery = String.Format($"SELECT AssignmentGrades,StudentID FROM Grades WHERE TeacherID={teacher.TeacherID}");
                Dictionary<string, List<string>> studentGradesOutput = SQLDatabase.ReadFromSQLServer(studentGradesQuery, new List<string> { "AssignmentGrades", "StudentID" });
                //Loops through each student and appends -1(No Grade) to their grade string for the class
                for (int i = 0; i < studentGradesOutput["AssignmentGrades"].Count; i++)
                {
                    string newGrades = studentGradesOutput["AssignmentGrades"][i] + ",-1";
                    string updateStudentAssignmentsQuery = String.Format($"UPDATE Grades SET AssignmentGrades='{newGrades}' WHERE StudentID={studentGradesOutput["StudentID"][i]} AND TeacherID={teacher.TeacherID}");
                    SQLDatabase.WriteToSQLServer(updateStudentAssignmentsQuery);

                }

                MessageBox.Show("Assignment Created.");
                this.Close();
            }
        }
    }
}
