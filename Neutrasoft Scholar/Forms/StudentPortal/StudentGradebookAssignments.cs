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
    public partial class StudentGradebookAssignments : Form
    {
        private Teacher teacher;
        private Student student;
        public StudentGradebookAssignments(Teacher senderTeacher, Student senderStudent)
        {
            InitializeComponent();
            teacher = senderTeacher;
            student = senderStudent;

            FillInTable();

        }

        private void FillInTable()
        {
            Dictionary<string, List<Assignment>> assignments = Assignment.GetStudentAssignments(teacher, student);

            foreach (Assignment assignment in assignments["Daily"])
            {
                DataGridViewRow row = (DataGridViewRow)dgvStudentGradebookAssignments.RowTemplate.Clone();
                row.CreateCells(dgvStudentGradebookAssignments);
                row.Cells[0].Value = assignment.Name;
                row.Cells[1].Value = assignment.Type;
                row.Cells[2].Value = assignment.Grade;
                row.Height = 50;

                //Adds row to table
                dgvStudentGradebookAssignments.Rows.Add(row);
            }
            foreach (Assignment assignment in assignments["Quiz"])
            {
                DataGridViewRow row = (DataGridViewRow)dgvStudentGradebookAssignments.RowTemplate.Clone();
                row.CreateCells(dgvStudentGradebookAssignments);
                row.Cells[0].Value = assignment.Name;
                row.Cells[1].Value = assignment.Type;
                row.Cells[2].Value = assignment.Grade;
                row.Height = 50;

                //Adds row to table
                dgvStudentGradebookAssignments.Rows.Add(row);
            }
            foreach (Assignment assignment in assignments["Test"])
            {
                DataGridViewRow row = (DataGridViewRow)dgvStudentGradebookAssignments.RowTemplate.Clone();
                row.CreateCells(dgvStudentGradebookAssignments);
                row.Cells[0].Value = assignment.Name;
                row.Cells[1].Value = assignment.Type;
                row.Cells[2].Value = assignment.Grade;
                row.Height = 50;

                //Adds row to table
                dgvStudentGradebookAssignments.Rows.Add(row);
            }
            
        }
    }
}
