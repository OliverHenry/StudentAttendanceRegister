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
    public partial class CreateUser : Form
    {
        SARUtilities dbUtils = new SARUtilities();
        public CreateUser()
        {
            InitializeComponent();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {

            int numValue;
            if (!Int32.TryParse(idTextBox.Text, out numValue) || idTextBox.Text == "" || loginIdTextBox.Text == "" || firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || userTypesComboBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["DBConnection"]))
                {
                    SqlCommand insCommand = new SqlCommand("INSERT INTO USERS (ID, LOGIN_ID, FIRST_NAME, LAST_NAME, DATE_OF_BIRTH, USER_TYPE_ID, PASSWORD_HASH) VALUES(@user_id, @login_id, @first_name, @last_name, @dob, (SELECT ID FROM USER_TYPES WHERE NAME = @user_type), @password_hash);", connection);
                    insCommand.Parameters.AddWithValue("@user_id", numValue);
                    insCommand.Parameters.AddWithValue("@login_id", loginIdTextBox.Text);
                    insCommand.Parameters.AddWithValue("@first_name", firstNameTextBox.Text);
                    insCommand.Parameters.AddWithValue("@last_name", lastNameTextBox.Text);
                    insCommand.Parameters.AddWithValue("@dob", dobTimePicker.Value.ToString("dd-MMM-yyyy"));
                    insCommand.Parameters.AddWithValue("@user_type", userTypesComboBox.Text);
                    insCommand.Parameters.AddWithValue("@password_hash", dbUtils.CalculateMD5Hash(passwordTextBox.Text));

                    try
                    {
                        connection.Open();
                        try
                        {
                            insCommand.ExecuteNonQuery();
                            MessageBox.Show("User created");
                            // Reset form values
                            idTextBox.Text = "";
                            loginIdTextBox.Text = "";
                            firstNameTextBox.Text = "";
                            lastNameTextBox.Text = "";
                            userTypesComboBox.Text = "";
                            passwordTextBox.Text = "";
                            dobTimePicker.Value = new DateTime(1990, 01, 01);


                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            MessageBox.Show(ex.Message);
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
}
