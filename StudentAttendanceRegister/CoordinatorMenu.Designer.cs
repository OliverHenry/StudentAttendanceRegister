namespace StudentAttendanceRegister
{
    partial class CoordinatorMenu
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
            this.createStudentButton = new System.Windows.Forms.Button();
            this.assignCoursesButton = new System.Windows.Forms.Button();
            this.addAttendanceButton = new System.Windows.Forms.Button();
            this.viewAttendanceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createStudentButton
            // 
            this.createStudentButton.Location = new System.Drawing.Point(12, 75);
            this.createStudentButton.Name = "createStudentButton";
            this.createStudentButton.Size = new System.Drawing.Size(280, 50);
            this.createStudentButton.TabIndex = 0;
            this.createStudentButton.Text = "Create Student";
            this.createStudentButton.UseVisualStyleBackColor = true;
            this.createStudentButton.Click += new System.EventHandler(this.createStudentButton_Click);
            // 
            // assignCoursesButton
            // 
            this.assignCoursesButton.Location = new System.Drawing.Point(12, 131);
            this.assignCoursesButton.Name = "assignCoursesButton";
            this.assignCoursesButton.Size = new System.Drawing.Size(280, 50);
            this.assignCoursesButton.TabIndex = 1;
            this.assignCoursesButton.Text = "Assign Course";
            this.assignCoursesButton.UseVisualStyleBackColor = true;
            this.assignCoursesButton.Click += new System.EventHandler(this.assignCoursesButton_Click);
            // 
            // addAttendanceButton
            // 
            this.addAttendanceButton.Location = new System.Drawing.Point(12, 187);
            this.addAttendanceButton.Name = "addAttendanceButton";
            this.addAttendanceButton.Size = new System.Drawing.Size(280, 50);
            this.addAttendanceButton.TabIndex = 2;
            this.addAttendanceButton.Text = "Attendance Register";
            this.addAttendanceButton.UseVisualStyleBackColor = true;
            this.addAttendanceButton.Click += new System.EventHandler(this.addAttendanceButton_Click);
            // 
            // viewAttendanceButton
            // 
            this.viewAttendanceButton.Location = new System.Drawing.Point(12, 243);
            this.viewAttendanceButton.Name = "viewAttendanceButton";
            this.viewAttendanceButton.Size = new System.Drawing.Size(280, 50);
            this.viewAttendanceButton.TabIndex = 3;
            this.viewAttendanceButton.Text = "View Attendance";
            this.viewAttendanceButton.UseVisualStyleBackColor = true;
            this.viewAttendanceButton.Click += new System.EventHandler(this.viewAttendanceButton_Click);
            // 
            // CoordinatorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.viewAttendanceButton);
            this.Controls.Add(this.addAttendanceButton);
            this.Controls.Add(this.assignCoursesButton);
            this.Controls.Add(this.createStudentButton);
            this.MaximizeBox = false;
            this.Name = "CoordinatorMenu";
            this.Text = "Coordinator Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CoordinatorMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createStudentButton;
        private System.Windows.Forms.Button assignCoursesButton;
        private System.Windows.Forms.Button addAttendanceButton;
        private System.Windows.Forms.Button viewAttendanceButton;
    }
}