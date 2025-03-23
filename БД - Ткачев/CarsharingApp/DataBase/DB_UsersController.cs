using data.DataBase;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows;
using CarsharingApp.Model;

namespace CarsharingApp.DataBase
{
    public class DB_UsersController : DBControl
    {
        public void AddUser(string login, string password, string lastname, string firstName, string surname, string phone, string email)
        {
            Connection();
            string query = "INSERT INTO users (login, password, lastName, firstName, surname, telephone, email) VALUES ( @login, @password, @lastName, @firstName, @surname, @telephone, @email)";

            try
            {
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastname);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@telephone", phone);
                    command.Parameters.AddWithValue("@email", email);

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Регистрация не успешна: " + ex.Message);
            }
        }
        public User GetUser(string login)
        {
            Connection();
            string query = "SELECT lastName, firstName, surname, telephone, email FROM users WHERE login = @login";

            try
            {
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                LastName = reader["lastName"].ToString(),
                                FirstName = reader["firstName"].ToString(),
                                Surname = reader["surname"].ToString(),
                                Phone = reader["telephone"].ToString(),
                                Email = reader["email"].ToString()
                            };
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
            return null;
        }

        public bool dateVerification(string login, string password)
        {
            Connection();
            string query = "SELECT * FROM users WHERE login = @login AND password = @password";

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

        public int? GetUserID(string login)
        {
            Connection();
            string query = "SELECT ID FROM users WHERE login = @login";

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