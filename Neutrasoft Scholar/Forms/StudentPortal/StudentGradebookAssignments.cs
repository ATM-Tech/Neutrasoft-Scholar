﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OutlookStyleControls;

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
            //Grabs a student's asignments
            Dictionary<string, List<Assignment>> assignments = Assignment.GetStudentAssignments(teacher, student);

            //Creates a row for eacher assignment
            foreach (KeyValuePair<string, List<Assignment>> assignmentPair in assignments)
            {
                foreach (Assignment assignment in assignmentPair.Value)
                {
                    OutlookGridRow row = new OutlookGridRow();
                    row.CreateCells(dgvStudentGradebookAssignments, assignment.Name, assignment.Type, assignment.Grade);
                    dgvStudentGradebookAssignments.Rows.Add(row);
                }
            }

            //Sets grouping based on assignment type
            dgvStudentGradebookAssignments.GroupTemplate.Column = dgvStudentGradebookAssignments.Columns["TypeColumn"];
            dgvStudentGradebookAssignments.GroupTemplate.Height = 25;
            dgvStudentGradebookAssignments.Sort(dgvStudentGradebookAssignments.Columns["TypeColumn"], ListSortDirection.Ascending);

            //Adds additional height to non-grouping rows
            foreach (OutlookGridRow row in dgvStudentGradebookAssignments.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    row.Height = 35;
                    row.DefaultCellStyle.BackColor = Color.Beige;
                }
            }

            dgvStudentGradebookAssignments.Refresh();
        }
    }
}