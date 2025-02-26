using data.DataBase;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows;

namespace EducationApp.DataBase
{
    class UserControllDB : DBControll
    {
        public bool dateVerification(string login, string password)
        {
            Connection();
            string query = "SELECT * FROM Users WHERE login = @login AND password = @password";

            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
        }

        public void AddUser(string name, string login, string password, int roleID)
        {
            Connection();
            string query = "INSERT INTO Users (name, login, password, roleID) VALUES (@name, @login, @password, @roleID)";

            try
            {
                using (SqlCommand command = new(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@roleID", roleID);

                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                MessageBox.Show("Пользователь не добавлен");
                Application.Current.Shutdown();
            }
        }
    }
}
