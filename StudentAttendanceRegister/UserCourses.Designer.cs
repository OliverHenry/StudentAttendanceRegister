namespace StudentAttendanceRegister
{
    partial class UserCourses
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
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.addToCourseButton = new System.Windows.Forms.Button();
            this.coursesComboBox = new System.Windows.Forms.ComboBox();
            this.tempCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentComboBox
            // 
            this.studentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(82, 81);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(210, 28);
            this.studentComboBox.TabIndex = 0;
            this.studentComboBox.SelectedIndexChanged += new System.EventHandler(this.studentComboBox_SelectedIndexChanged);
            // 
            // addToCourseButton
            // 
            this.addToCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCourseButton.Location = new System.Drawing.Point(12, 229);
            this.addToCourseButton.Name = "addToCourseButton";
            this.addToCourseButton.Size = new System.Drawing.Size(280, 55);
            this.addToCourseButton.TabIndex = 3;
            this.addToCourseButton.Text = "Add to Course";
            this.addToCourseButton.UseVisualStyleBackColor = true;
            this.addToCourseButton.Click += new System.EventHandler(this.addToCourseButton_Click);
            // 
            // coursesComboBox
            // 
            this.coursesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coursesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesComboBox.FormattingEnabled = true;
            this.coursesComboBox.Location = new System.Drawing.Point(82, 129);
            this.coursesComboBox.Name = "coursesComboBox";
            this.coursesComboBox.Size = new System.Drawing.Size(210, 28);
            this.coursesComboBox.TabIndex = 5;
            // 
            // tempCheckBox
            // 
            this.tempCheckBox.AutoSize = true;
            this.tempCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempCheckBox.Location = new System.Drawing.Point(102, 174);
            this.tempCheckBox.Name = "tempCheckBox";
            this.tempCheckBox.Size = new System.Drawing.Size(99, 22);
            this.tempCheckBox.TabIndex = 6;
            this.tempCheckBox.Text = "Temporary";
            this.tempCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Course";
            // 
            // UserCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tempCheckBox);
            this.Controls.Add(this.coursesComboBox);
            this.Controls.Add(this.addToCourseButton);
            this.Controls.Add(this.studentComboBox);
            this.Name = "UserCourses";
            this.Text = "User Courses";
            this.Load += new System.EventHandler(this.UserCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.Button addToCourseButton;
        private System.Windows.Forms.ComboBox coursesComboBox;
        private System.Windows.Forms.CheckBox tempCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}