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
    public partial class StudentMenu : Form
    {
        SARUtilities dbUtils = new SARUtilities();
        LoginForm logF = new LoginForm();

        LoginForm previousForm;
        public StudentMenu(LoginForm incomingForm)
        {
            previousForm = incomingForm;
            InitializeComponent();
        }

        private void StudentMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {
            string[] courses = dbUtils.getListFromDB("SELECT c.code course_code FROM user_courses uc JOIN courses c on c.Id = uc.course_id JOIN users u on u.Id = uc.user_id and u.login_id = '"+previousForm.userLogin+"';");
            dbUtils.populateComboBox(courses, courseCodeComboBox);
        }

        private void courseCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["DBConnection"]);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT r.name room, st.name session_type, a.attendance_date FROM attendance a JOIN users u on u.id = a.user_id and u.login_id = '" + previousForm.userLogin + "' JOIN sessions s on s.Id = a.session_id JOIN session_types st on st.Id = s.session_type_id JOIN courses c on s.course_id = c.id AND c.code = '" + courseCodeComboBox.Text + "' JOIN rooms r on r.Id = s.room_id ORDER BY a.attendance_date DESC;", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
