using Microsoft.Data.SqlClient;
using System.Windows;
using data.DataBase;
using ElectricalProfiling.Model;

namespace ElectricalProfiling.DataBase
{
    //СТАРЫЙ ВАРИАНТ ВЗАИМОДЕЙСТВИЯ С БД. ИСПОЛЬЗУЮ ТОЛЬКО ДЛЯ ПРОЕКТОВ----------------------------------------------------
    class ProjectControllerDB: DBControll
    {
        public void AddProject(string name, string customer, string start_date, string end_date)
        {
            Connection();
            int? customer_id = GetCustomerID(customer);
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

        public int? GetCustomerID(string companyName)
        {
            Connection();
            string query = "SELECT \"ID\" FROM Customer WHERE \"company_name \" = @company_name";

            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@company_name", companyName);
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
                            Customer_id = Convert.ToInt32(reader["customer_id"]),
                            Start_date = (DateTime)reader["start_date"],
                            End_date = (DateTime)reader["end_date"]
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
