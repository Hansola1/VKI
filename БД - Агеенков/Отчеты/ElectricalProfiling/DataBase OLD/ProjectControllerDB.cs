using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows;
using data.DataBase;
using ElectricalProfiling.Model;
using Azure.Core;

namespace ElectricalProfiling.DataBase
{
    class ProjectControllerDB: DBControll
    {
        public void AddProject(string name, string customer_id, string start_date, string end_date)
        {
            Connection();
            string query = "INSERT INTO Project (name, customer_id, start_date, end_date) VALUES (@name, @customer_id, @start_date, @end_date)";

            try
            {
                using (SqlCommand command = new(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@customer_id", Convert.ToInt32(customer_id));
                    command.Parameters.AddWithValue("@start_date", start_date);
                    command.Parameters.AddWithValue("@end_date", end_date);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Проект не добавлен: {ex.Message}");
            }
        }

        public List<Projects> GetProject()
        {
            Connection();
            List<Projects> ListProjects = new List<Projects>();
            string query = "SELECT name, customer_id, start_date, end_date FROM Project";

            using (SqlCommand command = new(query, sqlConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListProjects.Add(new Projects
                        {
                            Name = reader["name"].ToString(),
                            Customer_id = reader["customer_id"].ToString(),
                            Start_date = reader["start_date"].ToString(),
                            End_date = reader["end_date"].ToString()
                        });
                    }
                }
            }
            return ListProjects;
        }

        public void EditProject(string name, string start_date, string end_date)
        {
            Connection();

            int? ID = GetProjectID(name);
            if (ID != null)
            {
                string query = "UPDATE Project SET \"name\" = @name, \"start_date\" = @start_date, \"end_date\" = @end_date WHERE \"ID\" = @ID";

                using (SqlCommand command = new(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@start_date", start_date);
                    command.Parameters.AddWithValue("@end_date", end_date);
                    command.ExecuteNonQuery();
                }
            }
        }

        public int? GetProjectID(string name)
        {
            Connection();
            string query = "SELECT \"ID\" FROM Project WHERE \"name\" = @name";

            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@name", name);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }
            }
            return null;
        }

        public void DeleteProject(string name)
        {
            Connection();
            int? ID = GetProjectID(name);

            if (ID != null)
            {
                string query = "DELETE FROM Project WHERE \"ID\" = @ID";

                using (SqlCommand command = new(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
