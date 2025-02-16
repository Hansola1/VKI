using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace data.DataBase
{
    public class DBControll
    {
        //private static string connectionString = "Server=DBSRV\\ag2024;Database=BorodinaAV_2207d2 NEW;Trusted_Connection=True";
        private static string connectionString = "Server=DANICHLAPTOP;Database=BorodinaAV_2207d2;Trusted_Connection=True";
        SqlConnection sqlConnection = new(connectionString);

        private void Connection()
        {
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void AddUser(string login, string password, string email, string age, string sex)
        {
            Connection();
            string query = "INSERT INTO Users (login, password, email, age, sex) VALUES (@login, @password, @email, @age, @sex)";

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@sex", sex);

                command.ExecuteNonQuery();
            }
        }

        public string GetLoginUser(string id)
        {
            Connection();
            string query = "SELECT * FROM Users WHERE ID = @ID";

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@ID", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string login = reader["login"].ToString();
                    return login;
                }
                else
                {
                    return " ";
                }
            }
        }
    }
}
