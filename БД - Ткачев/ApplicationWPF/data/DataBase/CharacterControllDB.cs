using System.Data;
using Microsoft.Data.SqlClient; //using System.Data.SqlClient; устарел, никогда не использовать!!!
using System.Windows;
using data.Model;
using data.Views.Pages;

namespace data.DataBase
{
    public class CharacterControllDB : DBControll
    {
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
                finally
                {
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        public List<Characters> GetUserCharacters(int? userID)
        {
            Connection();
            List<Characters> characters = new List<Characters>();
            string query = "SELECT species, name, level, class FROM Characters WHERE userID = @userID";

            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@userID", userID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        characters.Add(new Characters
                        {
                            Species = reader["species"].ToString(),
                            Name = reader["name"].ToString(),
                            Level = Convert.ToInt32(reader["level"]),
                            Class = reader["class"].ToString()
                        });
                    }
                }
            }
            return characters;
        }


        public List<Characters> GetClassComboBox()
        {
            Connection();
            List<Characters> characters = new List<Characters>();
            string query = "SELECT class FROM Characters";

            using (SqlCommand command = new(query, sqlConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        characters.Add(new Characters
                        {
                            Class = reader["class"].ToString(),
                        });
                    }
                }
            }
            return characters;
        }

        public List<Characters> GetInfoCharacter(string? ClassCharacter)
        {
            Connection();
            List<Characters> characters = new List<Characters>();
            string query = "SELECT species, name, level description FROM Characters WHERE class = @Class";

            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@Class", ClassCharacter);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        characters.Add(new Characters
                        {
                            Species = reader["species"].ToString(),
                            Name = reader["name"].ToString(),
                            Level = Convert.ToInt32(reader["level"]),
                            //Class = reader["class"].ToString(),
                        });
                    }
                }
            }
            return characters;
        }
    }
}
