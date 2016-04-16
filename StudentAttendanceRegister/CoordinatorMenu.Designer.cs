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
            this.SuspendLayout();
            // 
            // createStudentButton
            // 
            this.createStudentButton.Location = new System.Drawing.Point(84, 75);
            this.createStudentButton.Name = "createStudentButton";
            this.createStudentButton.Size = new System.Drawing.Size(120, 50);
            this.createStudentButton.TabIndex = 0;
            this.createStudentButton.Text = "Create Student";
            this.createStudentButton.UseVisualStyleBackColor = true;
            this.createStudentButton.Click += new System.EventHandler(this.createStudentButton_Click);
            // 
            // assignCoursesButton
            // 
            this.assignCoursesButton.Location = new System.Drawing.Point(84, 147);
            this.assignCoursesButton.Name = "assignCoursesButton";
            this.assignCoursesButton.Size = new System.Drawing.Size(120, 50);
            this.assignCoursesButton.TabIndex = 1;
            this.assignCoursesButton.Text = "Assign Course";
            this.assignCoursesButton.UseVisualStyleBackColor = true;
            this.assignCoursesButton.Click += new System.EventHandler(this.assignCoursesButton_Click);
            // 
            // CoordinatorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
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
    }
}