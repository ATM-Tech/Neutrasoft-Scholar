namespace Neutrasoft_Scholar.Forms.TeacherPortal
{
    partial class TeacherGradebookStudentAssignments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTeacherGradebookStudentAssignments = new OutlookStyleControls.OutlookGrid();
            this.AssignmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditGradeColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AssignmentIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherGradebookStudentAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeacherGradebookStudentAssignments
            // 
            this.dgvTeacherGradebookStudentAssignments.AllowUserToAddRows = false;
            this.dgvTeacherGradebookStudentAssignments.AllowUserToDeleteRows = false;
            this.dgvTeacherGradebookStudentAssignments.AllowUserToResizeColumns = false;
            this.dgvTeacherGradebookStudentAssignments.AllowUserToResizeRows = false;
            this.dgvTeacherGradebookStudentAssignments.CollapseIcon = global::Neutrasoft_Scholar.Properties.Resources.IconCollapse;
            this.dgvTeacherGradebookStudentAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherGradebookStudentAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignmentColumn,
            this.TypeColumn,
            this.GradeColumn,
            this.EditGradeColumn,
            this.AssignmentIDColumn});
            this.dgvTeacherGradebookStudentAssignments.ExpandIcon = global::Neutrasoft_Scholar.Properties.Resources.IconExpand;
            this.dgvTeacherGradebookStudentAssignments.Location = new System.Drawing.Point(-1, 0);
            this.dgvTeacherGradebookStudentAssignments.Name = "dgvTeacherGradebookStudentAssignments";
            this.dgvTeacherGradebookStudentAssignments.ReadOnly = true;
            this.dgvTeacherGradebookStudentAssignments.RowHeadersVisible = false;
            this.dgvTeacherGradebookStudentAssignments.Size = new System.Drawing.Size(761, 723);
            this.dgvTeacherGradebookStudentAssignments.TabIndex = 1;
            this.dgvTeacherGradebookStudentAssignments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacherGradebookStudentAssignments_CellContentClick);
            // 
            // AssignmentColumn
            // 
            this.AssignmentColumn.HeaderText = "Assignment";
            this.AssignmentColumn.Name = "AssignmentColumn";
            this.AssignmentColumn.ReadOnly = true;
            this.AssignmentColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AssignmentColumn.Width = 400;
            // 
            // TypeColumn
            // 
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            this.TypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GradeColumn
            // 
            this.GradeColumn.HeaderText = "Grade";
            this.GradeColumn.Name = "GradeColumn";
            this.GradeColumn.ReadOnly = true;
            this.GradeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GradeColumn.Width = 140;
            // 
            // EditGradeColumn
            // 
            this.EditGradeColumn.HeaderText = "Edit Grade";
            this.EditGradeColumn.Name = "EditGradeColumn";
            this.EditGradeColumn.ReadOnly = true;
            this.EditGradeColumn.Text = "Edit Grade";
            this.EditGradeColumn.UseColumnTextForButtonValue = true;
            this.EditGradeColumn.Width = 117;
            // 
            // AssignmentIDColumn
            // 
            this.AssignmentIDColumn.HeaderText = "AssignmentID";
            this.AssignmentIDColumn.Name = "AssignmentIDColumn";
            this.AssignmentIDColumn.ReadOnly = true;
            this.AssignmentIDColumn.Visible = false;
            // 
            // TeacherGradebookStudentAssignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 723);
            this.Controls.Add(this.dgvTeacherGradebookStudentAssignments);
            this.Name = "TeacherGradebookStudentAssignments";
            this.Text = "TeacherGradebookStudentAssignments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherGradebookStudentAssignments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OutlookStyleControls.OutlookGrid dgvTeacherGradebookStudentAssignments;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditGradeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentIDColumn;
    }
}