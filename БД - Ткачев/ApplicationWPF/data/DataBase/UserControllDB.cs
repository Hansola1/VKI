using System.Data;
using Microsoft.Data.SqlClient; 
using System.Windows;
using data.Model;

namespace data.DataBase
{
    public class UserControllDB : DBControll
    {
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
                    MessageBox.Show("Регистрация успешна");
                }
            }
            catch
            {
                MessageBox.Show("Пользователь не добавлен");
                Application.Current.Shutdown(); //mainWindow.Close(); не понимаю почему не работает?
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

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string GetLoginUser(string id)
        {
            Connection();
            string query = "SELECT * FROM Users WHERE ID = @ID";

            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@ID", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        return name;
                    }
                }
            }
            return " ";
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

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            return id;
                        }
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
