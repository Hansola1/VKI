using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;
using data.Views.Pages;

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

        public void AddUser(string name, string login, string password, string email, string age, string sex)
        {
            Connection();
            string query = "INSERT INTO Users (name, login, password, email, age, sex) VALUES (@name, @login, @password, @email, @age, @sex)";

            try
            {
                using (SqlCommand command = new(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@sex", sex);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Пользователь добавлен");
                }
            }
            catch
            {
                MessageBox.Show("Пользователь не добавлен");
                Application.Current.Shutdown(); //mainWindow.Close(); не понимаю почему не работает?
            }
        }

        public string GetLoginUser(string id)
        {
            Connection();
            string query = "SELECT * FROM Users WHERE ID = @ID";

            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@ID", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string name = reader["name"].ToString();
                    return name;
                }
                else
                {
                    return " ";
                }
            }
        }

        public bool dateVerification(string login, string password)
        {
            Connection();
            string query = "SELECT * FROM Users WHERE login = @login AND password = @password";

            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());
                 
                if(count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void AddCharacter(int? userID, string species, string nameCharacter, string level, string classCharacter)
        {
            Connection();    
            string query = "INSERT INTO Characters (userID, species, name, level, class) VALUES (@userID, @species, @name, @level, @class)";

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@userID", userID);
                command.Parameters.AddWithValue("@species", species);
                command.Parameters.AddWithValue("@name", nameCharacter);
                command.Parameters.AddWithValue("@level", Int32.Parse(level)); 
                command.Parameters.AddWithValue("@class", classCharacter);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show($"Персонаж добавлен, обновите таблицу!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении персонажа: {ex.Message}");
                }
            }
        }

        public int? GetCurrentUserID(string login)
        {
            Connection();
            string query = "SELECT id FROM Users WHERE login = @login";

            try
            {
                using (SqlCommand command = new(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@login", login);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        return id;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Пользователь не найден");
            }
            return null;
        }
    }
}
