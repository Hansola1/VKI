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
    }
}
