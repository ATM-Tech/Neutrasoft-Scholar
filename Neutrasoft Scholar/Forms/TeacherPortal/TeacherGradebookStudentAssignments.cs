using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OutlookStyleControls;

namespace Neutrasoft_Scholar.Forms.TeacherPortal
{
    public partial class TeacherGradebookStudentAssignments : Form
    {
        private Student student;
        private Teacher teacher;
        private List<int> assignmentIDs;
        public List<Assignment> assignments;

        public TeacherGradebookStudentAssignments(Student senderStudent, Teacher senderTeacher)
        {
            InitializeComponent();
            student = senderStudent;
            teacher = senderTeacher;

            FillInTable();
        }

        private void FillInTable()
        {
            dgvTeacherGradebookStudentAssignments.Rows.Clear();
            dgvTeacherGradebookStudentAssignments.ClearGroups();
            dgvTeacherGradebookStudentAssignments.Refresh();

            //Grabs a student's asignments
            assignments = Assignment.GetStudentAssignments(teacher, student);

            //Creates a row for each assignment, and initilizes assignment ids
            assignmentIDs = new List<int>();
            int activeAssignmentID = 0;

            foreach (Assignment assignment in assignments)
            {
                OutlookGridRow row = new OutlookGridRow();
                string grade;
                if (assignment.Grade == -1)
                {
                    grade = "No Grade";
                }
                else
                {
                    grade = String.Format($"{assignment.Grade} ({Assignment.GetLetterGrade(assignment.Grade)})");
                }
                DataGridViewButtonCell button = new DataGridViewButtonCell();
                row.CreateCells(dgvTeacherGradebookStudentAssignments, assignment.Name, assignment.Type, grade, button, activeAssignmentID);
                dgvTeacherGradebookStudentAssignments.Rows.Add(row);

                assignmentIDs.Add(activeAssignmentID);
                activeAssignmentID++;
            }

            //Sets grouping based on assignment type
            dgvTeacherGradebookStudentAssignments.GroupTemplate.Column = dgvTeacherGradebookStudentAssignments.Columns["TypeColumn"];
            dgvTeacherGradebookStudentAssignments.GroupTemplate.Height = 25;
            dgvTeacherGradebookStudentAssignments.Sort(dgvTeacherGradebookStudentAssignments.Columns[1], ListSortDirection.Ascending);

            //Adds additional height to non-grouping rows
            foreach (OutlookGridRow row in dgvTeacherGradebookStudentAssignments.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    row.Height = 35;
                    row.DefaultCellStyle.BackColor = Color.Beige;
                    row.Cells[3] = new DataGridViewButtonCell();
                    row.Cells[3].Value = "Edit Grade";
                }

            }

            dgvTeacherGradebookStudentAssignments.Refresh();
        }

        private void dgvTeacherGradebookStudentAssignments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //If a column containing a button is clicked, open assignments breakdown based on row
            if (e.ColumnIndex == 3)
            {
                for (int i = 0; i < assignmentIDs.Count; i++)
                {
                    if (dgvTeacherGradebookStudentAssignments.Rows[e.RowIndex].Cells[4].Value.ToString() == i.ToString())
                    {
                        TeacherGradebookEditGrade teacherGradebookEditGrade = new TeacherGradebookEditGrade(teacher.TeacherID, student.StudentID, i, assignments);
                        teacherGradebookEditGrade.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}
