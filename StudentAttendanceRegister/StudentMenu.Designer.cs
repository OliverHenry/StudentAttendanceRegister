namespace StudentAttendanceRegister
{
    partial class StudentMenu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // courseCodeComboBox
            // 
            this.courseCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseCodeComboBox.FormattingEnabled = true;
            this.courseCodeComboBox.Location = new System.Drawing.Point(129, 12);
            this.courseCodeComboBox.Name = "courseCodeComboBox";
            this.courseCodeComboBox.Size = new System.Drawing.Size(163, 21);
            this.courseCodeComboBox.TabIndex = 0;
            this.courseCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.courseCodeComboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(296, 390);
            this.dataGridView1.TabIndex = 1;
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel.Location = new System.Drawing.Point(13, 12);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(110, 20);
            this.courseLabel.TabIndex = 2;
            this.courseLabel.Text = "Course Code: ";
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.courseCodeComboBox);
            this.Name = "StudentMenu";
            this.Text = "Student Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentMenu_FormClosed);
            this.Load += new System.EventHandler(this.StudentMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox courseCodeComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label courseLabel;
    }
}