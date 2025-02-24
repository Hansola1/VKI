using data.Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

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

        public List<Character> GetUserCharacters(int? userID)
        {
            Connection();
            List<Character> characters = new List<Character>();
            string query = "SELECT species, name, level, class FROM Characters WHERE userID = @userID";

            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@userID", userID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        characters.Add(new Character
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
    }
}
