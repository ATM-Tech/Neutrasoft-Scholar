namespace Neutrasoft_Scholar.Forms.StudentPortal
{
    partial class StudentGradebookAssignments
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
            this.dgvStudentGradebookAssignments = new System.Windows.Forms.DataGridView();
            this.AssignmentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentGradebookAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentGradebookAssignments
            // 
            this.dgvStudentGradebookAssignments.AllowUserToAddRows = false;
            this.dgvStudentGradebookAssignments.AllowUserToDeleteRows = false;
            this.dgvStudentGradebookAssignments.AllowUserToResizeColumns = false;
            this.dgvStudentGradebookAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentGradebookAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignmentNameColumn,
            this.TypeColumn,
            this.GradeColumn});
            this.dgvStudentGradebookAssignments.Location = new System.Drawing.Point(-1, 1);
            this.dgvStudentGradebookAssignments.Name = "dgvStudentGradebookAssignments";
            this.dgvStudentGradebookAssignments.ReadOnly = true;
            this.dgvStudentGradebookAssignments.RowHeadersVisible = false;
            this.dgvStudentGradebookAssignments.Size = new System.Drawing.Size(646, 723);
            this.dgvStudentGradebookAssignments.TabIndex = 0;
            // 
            // AssignmentNameColumn
            // 
            this.AssignmentNameColumn.HeaderText = "Assignment";
            this.AssignmentNameColumn.Name = "AssignmentNameColumn";
            this.AssignmentNameColumn.ReadOnly = true;
            this.AssignmentNameColumn.Width = 400;
            // 
            // TypeColumn
            // 
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            // 
            // GradeColumn
            // 
            this.GradeColumn.HeaderText = "Grade";
            this.GradeColumn.Name = "GradeColumn";
            this.GradeColumn.ReadOnly = true;
            this.GradeColumn.Width = 142;
            // 
            // StudentGradebookAssignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 721);
            this.Controls.Add(this.dgvStudentGradebookAssignments);
            this.Name = "StudentGradebookAssignments";
            this.Text = "StudentGradebookAssignments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentGradebookAssignments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentGradebookAssignments;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeColumn;
    }
}