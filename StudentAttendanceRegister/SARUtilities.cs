using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace StudentAttendanceRegister
{
    class SARUtilities
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

        public string CalculateMD5Hash(string input)
        {

            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }

    }
}
