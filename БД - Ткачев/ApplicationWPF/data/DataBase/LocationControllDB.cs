using data.Model;
using System.Data;
using Microsoft.Data.SqlClient; //using System.Data.SqlClient; устарел, никогда не использовать!!!
using System.Windows;
using data.Views.Pages;

namespace data.DataBase
{
    public class LocationControllDB : DBControll
    {
        public List<Locations> GetInfoLocation(string? Biome)
        {
            Connection();
            List<Locations> locations = new List<Locations>();
            string query = "SELECT biome, level, description FROM Locations WHERE biome = @Biome";

            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@Biome", Biome);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        locations.Add(new Locations
                        {
                            Biome = reader["biome"].ToString(),
                            Level = Convert.ToInt32(reader["level"]),
                            Description = reader["description"].ToString(),
                        });
                    }
                }
            }
            return locations;
        }

        public List<Locations> GetBiomeComboBox()
        {
            Connection();
            List<Locations> locations = new List<Locations>();
            string query = "SELECT biome FROM Locations";

            using (SqlCommand command = new(query, sqlConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        locations.Add(new Locations
                        {
                            Biome = reader["biome"].ToString(),
                        });
                    }
                }
            }
            return locations;
        }

        public int GetLocationID(string biome)
        {
            Connection();
            int dontID = -1;
            string query = "SELECT id FROM Locations WHERE biome = @biome";

            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@biome", biome);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        return id;
                    }
                }
            }
            return dontID; 
        }

        public List<Enemies> GetEnemiesForLocations(int? locationID)
        {
            Connection();
            List<Enemies> enemies = new List<Enemies>();
            string query = "SELECT name, level FROM Enemies WHERE locationID = @locationID";

            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@locationID", locationID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        enemies.Add(new Enemies
                        {
                            Name = reader["name"].ToString(),
                            Level = Convert.ToInt32(reader["level"]),
                        });
                    }
                }
            }
            return enemies;
        }
    }
}
