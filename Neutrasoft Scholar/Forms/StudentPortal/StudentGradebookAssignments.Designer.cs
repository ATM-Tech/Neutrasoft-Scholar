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
            this.dgvStudentGradebookAssignments = new OutlookStyleControls.OutlookGrid();
            this.AssignmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvStudentGradebookAssignments.AllowUserToResizeRows = false;
            this.dgvStudentGradebookAssignments.CollapseIcon = global::Neutrasoft_Scholar.Properties.Resources.IconCollapse;
            this.dgvStudentGradebookAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentGradebookAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignmentColumn,
            this.TypeColumn,
            this.GradeColumn});
            this.dgvStudentGradebookAssignments.ExpandIcon = global::Neutrasoft_Scholar.Properties.Resources.IconExpand;
            this.dgvStudentGradebookAssignments.Location = new System.Drawing.Point(0, 0);
            this.dgvStudentGradebookAssignments.Name = "dgvStudentGradebookAssignments";
            this.dgvStudentGradebookAssignments.ReadOnly = true;
            this.dgvStudentGradebookAssignments.RowHeadersVisible = false;
            this.dgvStudentGradebookAssignments.Size = new System.Drawing.Size(644, 723);
            this.dgvStudentGradebookAssignments.TabIndex = 0;
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

        private OutlookStyleControls.OutlookGrid dgvStudentGradebookAssignments;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeColumn;
    }
}