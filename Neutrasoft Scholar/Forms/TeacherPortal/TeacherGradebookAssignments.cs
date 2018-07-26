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
    public partial class TeacherGradebookAssignments : Form
    {
        private Teacher teacher;
        public TeacherGradebook parent;
        public TeacherGradebookAssignments(Teacher senderTeacher, TeacherGradebook caller)
        {
            InitializeComponent();
            teacher = senderTeacher;
            parent = caller;

            FillInTable();

        }
        public void FillInTable()
        {
            //Clears Old rows
            dgvTeacherGradebookAssignments.Rows.Clear();
            dgvTeacherGradebookAssignments.Refresh();
            

            //Grabs a teacher's asignments
            Dictionary<string, List<Assignment>> assignments = Assignment.GetTeacherAssignments(teacher);

            //Creates a row for each assignment
            foreach (KeyValuePair<string, List<Assignment>> assignmentPair in assignments)
            {
                foreach (Assignment assignment in assignmentPair.Value)
                {
                    OutlookGridRow row = new OutlookGridRow();
                    row.CreateCells(dgvTeacherGradebookAssignments, assignment.Name, assignment.Type);
                    dgvTeacherGradebookAssignments.Rows.Add(row);
                }
            }

            //Sets grouping based on assignment type
            dgvTeacherGradebookAssignments.GroupTemplate.Column = dgvTeacherGradebookAssignments.Columns["TypeColumn"];
            dgvTeacherGradebookAssignments.GroupTemplate.Height = 25;
            dgvTeacherGradebookAssignments.Sort(dgvTeacherGradebookAssignments.Columns["TypeColumn"], ListSortDirection.Ascending);

            //Adds additional height to non-grouping rows
            foreach (OutlookGridRow row in dgvTeacherGradebookAssignments.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    row.Height = 35;
                    row.DefaultCellStyle.BackColor = Color.Beige;
                }
            }

        }

        private void btnNewAssignment_Click(object sender, EventArgs e)
        {
            TeacherGradebookNewAssignment teacherGradebookNewAssignment = new TeacherGradebookNewAssignment(teacher, this);
            teacherGradebookNewAssignment.ShowDialog();
            this.Close();
        }
    }
}
