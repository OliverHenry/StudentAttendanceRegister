namespace StudentAttendanceRegister
{
    partial class Attendance
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
            this.courseCodeComboBox = new System.Windows.Forms.ComboBox();
            this.sessionComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentIDRadioBtn = new System.Windows.Forms.RadioButton();
            this.listRadioBtn = new System.Windows.Forms.RadioButton();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseCodeComboBox
            // 
            this.courseCodeComboBox.FormattingEnabled = true;
            this.courseCodeComboBox.Location = new System.Drawing.Point(65, 43);
            this.courseCodeComboBox.Name = "courseCodeComboBox";
            this.courseCodeComboBox.Size = new System.Drawing.Size(121, 21);
            this.courseCodeComboBox.TabIndex = 0;
            this.courseCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.courseCodeComboBox_SelectedIndexChanged);
            // 
            // sessionComboBox
            // 
            this.sessionComboBox.FormattingEnabled = true;
            this.sessionComboBox.Location = new System.Drawing.Point(65, 101);
            this.sessionComboBox.Name = "sessionComboBox";
            this.sessionComboBox.Size = new System.Drawing.Size(121, 21);
            this.sessionComboBox.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(190, 336);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Add";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentIDRadioBtn);
            this.groupBox1.Controls.Add(this.listRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(13, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 68);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Input";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // studentIDRadioBtn
            // 
            this.studentIDRadioBtn.AutoSize = true;
            this.studentIDRadioBtn.Location = new System.Drawing.Point(17, 45);
            this.studentIDRadioBtn.Name = "studentIDRadioBtn";
            this.studentIDRadioBtn.Size = new System.Drawing.Size(70, 17);
            this.studentIDRadioBtn.TabIndex = 1;
            this.studentIDRadioBtn.Text = "Input SID";
            this.studentIDRadioBtn.UseVisualStyleBackColor = true;
            this.studentIDRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // listRadioBtn
            // 
            this.listRadioBtn.AutoSize = true;
            this.listRadioBtn.Checked = true;
            this.listRadioBtn.Location = new System.Drawing.Point(17, 20);
            this.listRadioBtn.Name = "listRadioBtn";
            this.listRadioBtn.Size = new System.Drawing.Size(93, 17);
            this.listRadioBtn.TabIndex = 0;
            this.listRadioBtn.TabStop = true;
            this.listRadioBtn.Text = "Select from list";
            this.listRadioBtn.UseVisualStyleBackColor = true;
            this.listRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(133, 271);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(121, 21);
            this.studentComboBox.TabIndex = 5;
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(133, 271);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.studentIDTextBox.TabIndex = 6;
            this.studentIDTextBox.Visible = false;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.studentComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sessionComboBox);
            this.Controls.Add(this.courseCodeComboBox);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox courseCodeComboBox;
        private System.Windows.Forms.ComboBox sessionComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton studentIDRadioBtn;
        private System.Windows.Forms.RadioButton listRadioBtn;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.TextBox studentIDTextBox;
    }
}