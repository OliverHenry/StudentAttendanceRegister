using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceRegister
{
    public partial class CoordinatorMenu : Form
    {
        public CoordinatorMenu()
        {
            InitializeComponent();
        }

        private void CoordinatorMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void createStudentButton_Click(object sender, EventArgs e)
        {
            CreateUser cu = new CreateUser();
            cu.Show();
        }

        private void assignCoursesButton_Click(object sender, EventArgs e)
        {
            UserCourses uc = new UserCourses();
            uc.Show();
        }

        private void addAttendanceButton_Click(object sender, EventArgs e)
        {
            Attendance at = new Attendance();
            at.Show();
        }

        private void viewAttendanceButton_Click(object sender, EventArgs e)
        {
            AttendanceView av = new AttendanceView();
            av.Show();
        }

    }
}
