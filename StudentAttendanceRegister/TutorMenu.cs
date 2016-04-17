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
    public partial class TutorMenu : Form
    {
        public TutorMenu()
        {
            InitializeComponent();
        }

        private void TutorMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
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
