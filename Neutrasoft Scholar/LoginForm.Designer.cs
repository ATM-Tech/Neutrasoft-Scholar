namespace Neutrasoft_Scholar
{
    partial class LoginForm
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
            this.scholarImageBox = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passcodeLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passcodeTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.roleRadioButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.teacherRadioButton = new System.Windows.Forms.RadioButton();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.scholarImageBox)).BeginInit();
            this.roleRadioButtonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // scholarImageBox
            // 
            this.scholarImageBox.BackgroundImage = global::Neutrasoft_Scholar.Properties.Resources.Neutrasoft_Scholar_Image;
            this.scholarImageBox.Location = new System.Drawing.Point(128, 12);
            this.scholarImageBox.Name = "scholarImageBox";
            this.scholarImageBox.Size = new System.Drawing.Size(192, 192);
            this.scholarImageBox.TabIndex = 0;
            this.scholarImageBox.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(46, 343);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(102, 24);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // passcodeLabel
            // 
            this.passcodeLabel.AutoSize = true;
            this.passcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passcodeLabel.Location = new System.Drawing.Point(50, 398);
            this.passcodeLabel.Name = "passcodeLabel";
            this.passcodeLabel.Size = new System.Drawing.Size(98, 24);
            this.passcodeLabel.TabIndex = 2;
            this.passcodeLabel.Text = "Passcode:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(154, 348);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(261, 20);
            this.usernameTextBox.TabIndex = 3;
            // 
            // passcodeTextBox
            // 
            this.passcodeTextBox.Location = new System.Drawing.Point(154, 403);
            this.passcodeTextBox.Name = "passcodeTextBox";
            this.passcodeTextBox.PasswordChar = '*';
            this.passcodeTextBox.Size = new System.Drawing.Size(261, 20);
            this.passcodeTextBox.TabIndex = 4;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 252);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 29);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(50, 512);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(365, 57);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // roleRadioButtonGroupBox
            // 
            this.roleRadioButtonGroupBox.Controls.Add(this.studentRadioButton);
            this.roleRadioButtonGroupBox.Controls.Add(this.teacherRadioButton);
            this.roleRadioButtonGroupBox.Location = new System.Drawing.Point(50, 441);
            this.roleRadioButtonGroupBox.Name = "roleRadioButtonGroupBox";
            this.roleRadioButtonGroupBox.Size = new System.Drawing.Size(365, 53);
            this.roleRadioButtonGroupBox.TabIndex = 7;
            this.roleRadioButtonGroupBox.TabStop = false;
            // 
            // teacherRadioButton
            // 
            this.teacherRadioButton.AutoSize = true;
            this.teacherRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherRadioButton.Location = new System.Drawing.Point(31, 19);
            this.teacherRadioButton.Name = "teacherRadioButton";
            this.teacherRadioButton.Size = new System.Drawing.Size(99, 28);
            this.teacherRadioButton.TabIndex = 0;
            this.teacherRadioButton.TabStop = true;
            this.teacherRadioButton.Text = "Teacher";
            this.teacherRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRadioButton.Location = new System.Drawing.Point(202, 19);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(92, 28);
            this.studentRadioButton.TabIndex = 1;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 619);
            this.Controls.Add(this.roleRadioButtonGroupBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.passcodeTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passcodeLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.scholarImageBox);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.scholarImageBox)).EndInit();
            this.roleRadioButtonGroupBox.ResumeLayout(false);
            this.roleRadioButtonGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox scholarImageBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passcodeLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passcodeTextBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.GroupBox roleRadioButtonGroupBox;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.RadioButton teacherRadioButton;
    }
}