namespace Neutrasoft_Scholar.Forms.TeacherPortal
{
    partial class TeacherSchedule
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlMyAccount = new System.Windows.Forms.Panel();
            this.llbMyAccount = new System.Windows.Forms.LinkLabel();
            this.pnlLoginHistory = new System.Windows.Forms.Panel();
            this.llbLoginHistory = new System.Windows.Forms.LinkLabel();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.llbExit = new System.Windows.Forms.LinkLabel();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblTeacherAccess = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNavigationBarHolder = new System.Windows.Forms.Panel();
            this.pnlNavigationBar = new System.Windows.Forms.Panel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnGradebook = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.dgvTeacherSchedule = new System.Windows.Forms.DataGridView();
            this.StudentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.pnlMyAccount.SuspendLayout();
            this.pnlLoginHistory.SuspendLayout();
            this.pnlExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNavigationBarHolder.SuspendLayout();
            this.pnlNavigationBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.pnlMyAccount);
            this.pnlTop.Controls.Add(this.pnlLoginHistory);
            this.pnlTop.Controls.Add(this.pnlExit);
            this.pnlTop.Controls.Add(this.lblTeacherName);
            this.pnlTop.Controls.Add(this.lblTeacherAccess);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Location = new System.Drawing.Point(-2, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1166, 151);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlMyAccount
            // 
            this.pnlMyAccount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMyAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMyAccount.Controls.Add(this.llbMyAccount);
            this.pnlMyAccount.Location = new System.Drawing.Point(945, 0);
            this.pnlMyAccount.Name = "pnlMyAccount";
            this.pnlMyAccount.Size = new System.Drawing.Size(160, 29);
            this.pnlMyAccount.TabIndex = 5;
            // 
            // llbMyAccount
            // 
            this.llbMyAccount.AutoSize = true;
            this.llbMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbMyAccount.Location = new System.Drawing.Point(23, 7);
            this.llbMyAccount.Name = "llbMyAccount";
            this.llbMyAccount.Size = new System.Drawing.Size(114, 20);
            this.llbMyAccount.TabIndex = 1;
            this.llbMyAccount.TabStop = true;
            this.llbMyAccount.Text = "MY ACCOUNT";
            this.llbMyAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbMyAccount_LinkClicked);
            // 
            // pnlLoginHistory
            // 
            this.pnlLoginHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLoginHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLoginHistory.Controls.Add(this.llbLoginHistory);
            this.pnlLoginHistory.Location = new System.Drawing.Point(798, 0);
            this.pnlLoginHistory.Name = "pnlLoginHistory";
            this.pnlLoginHistory.Size = new System.Drawing.Size(150, 29);
            this.pnlLoginHistory.TabIndex = 4;
            // 
            // llbLoginHistory
            // 
            this.llbLoginHistory.AutoSize = true;
            this.llbLoginHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLoginHistory.Location = new System.Drawing.Point(5, 7);
            this.llbLoginHistory.Name = "llbLoginHistory";
            this.llbLoginHistory.Size = new System.Drawing.Size(135, 20);
            this.llbLoginHistory.TabIndex = 1;
            this.llbLoginHistory.TabStop = true;
            this.llbLoginHistory.Text = "LOGIN HISTORY";
            this.llbLoginHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLoginHistory_LinkClicked);
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExit.Controls.Add(this.llbExit);
            this.pnlExit.Location = new System.Drawing.Point(1102, 0);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(63, 29);
            this.pnlExit.TabIndex = 4;
            // 
            // llbExit
            // 
            this.llbExit.AutoSize = true;
            this.llbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbExit.Location = new System.Drawing.Point(8, 7);
            this.llbExit.Name = "llbExit";
            this.llbExit.Size = new System.Drawing.Size(45, 20);
            this.llbExit.TabIndex = 2;
            this.llbExit.TabStop = true;
            this.llbExit.Text = "EXIT";
            this.llbExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbExit_LinkClicked);
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherName.Location = new System.Drawing.Point(189, 95);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(310, 24);
            this.lblTeacherName.TabIndex = 2;
            this.lblTeacherName.Text = "{FirstName MiddleName LastName}";
            // 
            // lblTeacherAccess
            // 
            this.lblTeacherAccess.AutoSize = true;
            this.lblTeacherAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherAccess.Location = new System.Drawing.Point(189, 24);
            this.lblTeacherAccess.Name = "lblTeacherAccess";
            this.lblTeacherAccess.Size = new System.Drawing.Size(148, 24);
            this.lblTeacherAccess.TabIndex = 1;
            this.lblTeacherAccess.Text = "Teacher Access";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Neutrasoft_Scholar.Properties.Resources.Neutrasoft_Scholar_Image_Smaller;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlNavigationBarHolder
            // 
            this.pnlNavigationBarHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNavigationBarHolder.Controls.Add(this.pnlNavigationBar);
            this.pnlNavigationBarHolder.Location = new System.Drawing.Point(-1, 150);
            this.pnlNavigationBarHolder.Name = "pnlNavigationBarHolder";
            this.pnlNavigationBarHolder.Size = new System.Drawing.Size(212, 655);
            this.pnlNavigationBarHolder.TabIndex = 1;
            // 
            // pnlNavigationBar
            // 
            this.pnlNavigationBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNavigationBar.Controls.Add(this.btnSchedule);
            this.pnlNavigationBar.Controls.Add(this.btnAttendance);
            this.pnlNavigationBar.Controls.Add(this.btnGradebook);
            this.pnlNavigationBar.Controls.Add(this.btnHome);
            this.pnlNavigationBar.Location = new System.Drawing.Point(35, 7);
            this.pnlNavigationBar.Name = "pnlNavigationBar";
            this.pnlNavigationBar.Size = new System.Drawing.Size(137, 212);
            this.pnlNavigationBar.TabIndex = 0;
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Location = new System.Drawing.Point(-1, 155);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(137, 55);
            this.btnSchedule.TabIndex = 5;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Location = new System.Drawing.Point(-1, 103);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(137, 55);
            this.btnAttendance.TabIndex = 4;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnGradebook
            // 
            this.btnGradebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradebook.Location = new System.Drawing.Point(-1, 51);
            this.btnGradebook.Name = "btnGradebook";
            this.btnGradebook.Size = new System.Drawing.Size(137, 55);
            this.btnGradebook.TabIndex = 3;
            this.btnGradebook.Text = "Gradebook";
            this.btnGradebook.UseVisualStyleBackColor = true;
            this.btnGradebook.Click += new System.EventHandler(this.btnGradebook_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(-1, -1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(137, 55);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Items.AddRange(new object[] {
            "<Select Period>",
            "Period 1",
            "Period 2",
            "Period 3",
            "Period 4",
            "Period 5",
            "Period 6",
            "Period 7"});
            this.cmbPeriod.Location = new System.Drawing.Point(218, 158);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbPeriod.Size = new System.Drawing.Size(937, 28);
            this.cmbPeriod.TabIndex = 2;
            this.cmbPeriod.SelectedIndexChanged += new System.EventHandler(this.cmbPeriod_SelectedIndexChanged);
            // 
            // dgvTeacherSchedule
            // 
            this.dgvTeacherSchedule.AllowUserToAddRows = false;
            this.dgvTeacherSchedule.AllowUserToDeleteRows = false;
            this.dgvTeacherSchedule.AllowUserToResizeColumns = false;
            this.dgvTeacherSchedule.AllowUserToResizeRows = false;
            this.dgvTeacherSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentColumn,
            this.GenderColumn});
            this.dgvTeacherSchedule.Location = new System.Drawing.Point(218, 192);
            this.dgvTeacherSchedule.Name = "dgvTeacherSchedule";
            this.dgvTeacherSchedule.ReadOnly = true;
            this.dgvTeacherSchedule.RowHeadersVisible = false;
            this.dgvTeacherSchedule.Size = new System.Drawing.Size(933, 587);
            this.dgvTeacherSchedule.TabIndex = 3;
            this.dgvTeacherSchedule.Visible = false;
            // 
            // StudentColumn
            // 
            this.StudentColumn.HeaderText = "Student";
            this.StudentColumn.Name = "StudentColumn";
            this.StudentColumn.ReadOnly = true;
            this.StudentColumn.Width = 465;
            // 
            // GenderColumn
            // 
            this.GenderColumn.HeaderText = "Gender";
            this.GenderColumn.Name = "GenderColumn";
            this.GenderColumn.ReadOnly = true;
            this.GenderColumn.Width = 465;
            // 
            // TeacherSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 802);
            this.Controls.Add(this.dgvTeacherSchedule);
            this.Controls.Add(this.cmbPeriod);
            this.Controls.Add(this.pnlNavigationBarHolder);
            this.Controls.Add(this.pnlTop);
            this.Name = "TeacherSchedule";
            this.Text = "Neutrasoft Scholar: Teacher Schedule";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMyAccount.ResumeLayout(false);
            this.pnlMyAccount.PerformLayout();
            this.pnlLoginHistory.ResumeLayout(false);
            this.pnlLoginHistory.PerformLayout();
            this.pnlExit.ResumeLayout(false);
            this.pnlExit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNavigationBarHolder.ResumeLayout(false);
            this.pnlNavigationBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblTeacherAccess;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.LinkLabel llbExit;
        private System.Windows.Forms.Panel pnlNavigationBarHolder;
        private System.Windows.Forms.Panel pnlNavigationBar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlMyAccount;
        private System.Windows.Forms.LinkLabel llbMyAccount;
        private System.Windows.Forms.Panel pnlLoginHistory;
        private System.Windows.Forms.LinkLabel llbLoginHistory;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnGradebook;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.ComboBox cmbPeriod;
        private System.Windows.Forms.DataGridView dgvTeacherSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColumn;
    }
}