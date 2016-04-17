using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace StudentAttendanceRegister
{
    class DatabaseUtilities
    {
        public string[] getListFromDB(String sql_code)
        {
            List<string> output_array = new List<string>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["DBConnection"]))
            {
                try
                {
                    connection.Open();
                    try
                    {
                        SqlCommand command = new SqlCommand(sql_code, connection);
                        SqlDataReader ccReader = command.ExecuteReader();
                        while (ccReader.Read())
                        {
                            output_array.Add(String.Format("{0}", ccReader[0]));
                        }
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
            return output_array.ToArray();
        }

        public void populateComboBox(string[] string_array, ComboBox comboBox, bool clearComboBox = false)
        {
            if(clearComboBox)
            { 
                comboBox.Items.Clear(); 
            }
            foreach (string value in string_array)
            {
                comboBox.Items.Add(value);
            }
        }

        public void insertIntoDB(String sql_code, String success_msg)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["DBConnection"]))
            {
                SqlCommand insCommand = new SqlCommand(sql_code, connection);
                try
                {
                    connection.Open();
                    try
                    {
                        insCommand.ExecuteNonQuery();
                        MessageBox.Show(success_msg);
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
