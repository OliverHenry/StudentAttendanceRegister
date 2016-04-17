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
    public partial class UserCourses : Form
    {
        public UserCourses()
        {
            InitializeComponent();
        }

        private void UserCourses_Load(object sender, EventArgs e)
        {
         
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["DBConnection"]))
            {
                try
                {
                    connection.Open();
                    string userTypeSQL = "SELECT u.id, u.first_name, u.last_name FROM users u JOIN user_types ut ON u.user_type_id = ut.id AND ut.name = 'Student';";
                    SqlCommand userTypeCommand = new SqlCommand(userTypeSQL, connection);
                    SqlDataReader userTypeReader = userTypeCommand.ExecuteReader();

                    try
                    {
                        while (userTypeReader.Read())
                        {
                            studentComboBox.Items.Add(String.Format("({0}) {1} {2}", userTypeReader[0], userTypeReader[1], userTypeReader[2]));
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void studentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.AppSettings["DBConnection"];

            // Provide the query string with a parameter placeholder.
            string queryString = "SELECT code FROM courses;";

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {

                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);


                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string coursesSQL = "SELECT code FROM courses;"; //TODO - Filter out existing courses
                SqlCommand coursesCommand = new SqlCommand(coursesSQL, connection);
                SqlDataReader coursesReader = coursesCommand.ExecuteReader();
                
                try
                {
                    coursesComboBox.Items.Clear();
                    while (coursesReader.Read())
                    {
                        coursesComboBox.Items.Add(String.Format("{0}", coursesReader[0]));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        private void addToCourseButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["DBConnection"]))
            {
                string queryString = "INSERT INTO user_courses (user_id, course_id, temp_user) SELECT u.Id user_id, c.Id course_id, @temp_flag temp FROM users u CROSS JOIN courses c WHERE '('+CAST(u.Id AS VARCHAR(50))+') '+u.first_name+' '+u.last_name = @student AND c.code = @code;";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@student", studentComboBox.Text);
                command.Parameters.AddWithValue("@code", coursesComboBox.Text);
                command.Parameters.AddWithValue("@temp_flag", tempCheckBox.Checked ? 1 : 0);

                //Try to connect to the DB
                try
                {
                    connection.Open();
                    //Try to run the query
                    try
                    {
                        command.ExecuteNonQuery();
                        //Console.WriteLine(studentComboBox.Text);
                        //Console.WriteLine(coursesComboBox.Text);
                        //Console.WriteLine(tempCheckBox.Checked ? 1 : 0);
                        MessageBox.Show("Course assigned");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("Student already assigned");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                catch (Exception connEx)
                {
                    Console.WriteLine(connEx.Message);
                    MessageBox.Show(connEx.Message);
                }
            }

        }
   }
}
