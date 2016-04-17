using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentAttendanceRegister
{
    public partial class Attendance : Form
    {
        
        DatabaseUtilities dbUtils = new DatabaseUtilities();

        public Attendance()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            string[] courses = dbUtils.getListFromDB("SELECT code FROM courses;");
            dbUtils.populateComboBox(courses, courseCodeComboBox);
        }

        private void courseCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] sessions = dbUtils.getListFromDB("SELECT st.name+' ('+r.name+')'FROM sessions s JOIN session_types st ON s.session_type_id = st.Id JOIN rooms r ON s.room_id = r.Id JOIN courses c ON s.course_id = c.Id AND c.code = '" + courseCodeComboBox.Text+ "';");
            dbUtils.populateComboBox(sessions, sessionComboBox, true);

            string[] students = dbUtils.getListFromDB("SELECT u.first_name+' '+u.last_name+''FROM user_courses uc JOIN courses c ON uc.course_id = c.Id JOIN users u ON uc.user_id = u.Id AND c.code = '" + courseCodeComboBox.Text + "';");
            dbUtils.populateComboBox(students, studentComboBox, true);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            studentComboBox.Text = "";
            studentIDTextBox.Text = "";
            studentComboBox.Visible = true;
            studentIDTextBox.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            studentComboBox.Text = "";
            studentIDTextBox.Text = "";
            studentComboBox.Visible = false;
            studentIDTextBox.Visible = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (courseCodeComboBox.Text == "" || sessionComboBox.Text == "" || studentComboBox.Text == "" )
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                string success_msg = "Attendance record added";
                if (listRadioBtn.Checked)
                {
                    dbUtils.insertIntoDB("INSERT INTO attendance (user_id, session_id, attendance_date) SELECT u.id user_id, s.id session_id, '" + dateTimePicker1.Value.ToString("dd-MMM-yyyy") + "' FROM users u CROSS JOIN sessions s JOIN session_types st on st.Id = s.session_type_id join rooms r on r.Id = s.room_id JOIN courses c on c.Id = s.course_id WHERE u.first_name +' '+u.last_name = '" + studentComboBox.Text + "' AND st.name+' ('+r.name+')' = '" + sessionComboBox.Text + "' and c.CODE = '" + courseCodeComboBox.Text + "';", success_msg);
                }
                else
                {
                    string sid;
                    string[] sid_check = dbUtils.getListFromDB("SELECT COUNT(1) FROM users where id = '" + studentIDTextBox.Text + "'");
                    try
                    {
                        sid = sid_check[0];
                    }
                    catch (IndexOutOfRangeException idx_e)
                    {
                        sid = "0";
                    }
                    if (sid == "1")
                    {
                        dbUtils.insertIntoDB("INSERT INTO attendance (user_id, session_id, attendance_date) SELECT u.id user_id, s.id session_id, '" + dateTimePicker1.Value.ToString("dd-MMM-yyyy") + "' FROM users u CROSS JOIN sessions s JOIN session_types st on st.Id = s.session_type_id join rooms r on r.Id = s.room_id JOIN courses c on c.Id = s.course_id WHERE u.id = '" + studentIDTextBox.Text + "' AND st.name+' ('+r.name+')' = '" + sessionComboBox.Text + "' and c.CODE = '" + courseCodeComboBox.Text + "';", success_msg);
                    }
                    else
                    {
                        MessageBox.Show("User with that SID not found");
                    }

                }
            }
        }
    }
}
