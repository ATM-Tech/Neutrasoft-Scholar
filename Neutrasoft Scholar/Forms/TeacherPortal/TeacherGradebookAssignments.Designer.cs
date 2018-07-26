namespace Neutrasoft_Scholar.Forms.TeacherPortal
{
    partial class TeacherGradebookAssignments
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
            this.dgvTeacherGradebookAssignments = new OutlookStyleControls.OutlookGrid();
            this.AssignmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewAssignment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherGradebookAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeacherGradebookAssignments
            // 
            this.dgvTeacherGradebookAssignments.AllowUserToAddRows = false;
            this.dgvTeacherGradebookAssignments.AllowUserToDeleteRows = false;
            this.dgvTeacherGradebookAssignments.AllowUserToResizeColumns = false;
            this.dgvTeacherGradebookAssignments.AllowUserToResizeRows = false;
            this.dgvTeacherGradebookAssignments.CollapseIcon = global::Neutrasoft_Scholar.Properties.Resources.IconCollapse;
            this.dgvTeacherGradebookAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherGradebookAssignments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignmentColumn,
            this.TypeColumn});
            this.dgvTeacherGradebookAssignments.ExpandIcon = global::Neutrasoft_Scholar.Properties.Resources.IconExpand;
            this.dgvTeacherGradebookAssignments.Location = new System.Drawing.Point(0, 0);
            this.dgvTeacherGradebookAssignments.Name = "dgvTeacherGradebookAssignments";
            this.dgvTeacherGradebookAssignments.ReadOnly = true;
            this.dgvTeacherGradebookAssignments.RowHeadersVisible = false;
            this.dgvTeacherGradebookAssignments.Size = new System.Drawing.Size(644, 698);
            this.dgvTeacherGradebookAssignments.TabIndex = 1;
            // 
            // AssignmentColumn
            // 
            this.AssignmentColumn.HeaderText = "Assignment";
            this.AssignmentColumn.Name = "AssignmentColumn";
            this.AssignmentColumn.ReadOnly = true;
            this.AssignmentColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AssignmentColumn.Width = 500;
            // 
            // TypeColumn
            // 
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            this.TypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TypeColumn.Width = 140;
            // 
            // btnNewAssignment
            // 
            this.btnNewAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAssignment.Location = new System.Drawing.Point(0, 697);
            this.btnNewAssignment.Name = "btnNewAssignment";
            this.btnNewAssignment.Size = new System.Drawing.Size(640, 56);
            this.btnNewAssignment.TabIndex = 2;
            this.btnNewAssignment.Text = "Add New Assignment";
            this.btnNewAssignment.UseVisualStyleBackColor = true;
            this.btnNewAssignment.Click += new System.EventHandler(this.btnNewAssignment_Click);
            // 
            // TeacherGradebookAssignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 751);
            this.Controls.Add(this.btnNewAssignment);
            this.Controls.Add(this.dgvTeacherGradebookAssignments);
            this.Name = "TeacherGradebookAssignments";
            this.Text = "TeacherGradebookAssignments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherGradebookAssignments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OutlookStyleControls.OutlookGrid dgvTeacherGradebookAssignments;
        private System.Windows.Forms.Button btnNewAssignment;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
    }
}