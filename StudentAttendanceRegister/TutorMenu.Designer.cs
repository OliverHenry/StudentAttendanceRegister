namespace StudentAttendanceRegister
{
    partial class TutorMenu
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
            this.addAttendanceButton = new System.Windows.Forms.Button();
            this.viewAttendanceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addAttendanceButton
            // 
            this.addAttendanceButton.Location = new System.Drawing.Point(12, 133);
            this.addAttendanceButton.Name = "addAttendanceButton";
            this.addAttendanceButton.Size = new System.Drawing.Size(280, 50);
            this.addAttendanceButton.TabIndex = 3;
            this.addAttendanceButton.Text = "Attendance Register";
            this.addAttendanceButton.UseVisualStyleBackColor = true;
            this.addAttendanceButton.Click += new System.EventHandler(this.addAttendanceButton_Click);
            // 
            // viewAttendanceButton
            // 
            this.viewAttendanceButton.Location = new System.Drawing.Point(12, 214);
            this.viewAttendanceButton.Name = "viewAttendanceButton";
            this.viewAttendanceButton.Size = new System.Drawing.Size(280, 50);
            this.viewAttendanceButton.TabIndex = 4;
            this.viewAttendanceButton.Text = "View Attendance";
            this.viewAttendanceButton.UseVisualStyleBackColor = true;
            this.viewAttendanceButton.Click += new System.EventHandler(this.viewAttendanceButton_Click);
            // 
            // TutorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.viewAttendanceButton);
            this.Controls.Add(this.addAttendanceButton);
            this.MaximizeBox = false;
            this.Name = "TutorMenu";
            this.Text = "Tutor Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TutorMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addAttendanceButton;
        private System.Windows.Forms.Button viewAttendanceButton;

    }
}