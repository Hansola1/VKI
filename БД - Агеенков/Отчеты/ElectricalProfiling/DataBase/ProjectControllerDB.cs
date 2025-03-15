using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows;
using data.DataBase;
using ElectricalProfiling.Model;

namespace ElectricalProfiling.DataBase
{
    class ProjectControllerDB: DBControll
    {
        public void AddProject(string name, string start_date, string end_date)
        {
            Connection();
            string query = "INSERT INTO Project (name, start_date, end_date) VALUES (@name, @start_date, @end_date)";

            try
            {
                using (SqlCommand command = new(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@name", name);
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

      /*  public List<Projects> GetProject()
        {
            Connection();
            List<Projects> ListProjects = new List<Courses>();
            string query = "SELECT id, titleCourse, teacherID, time, maxStudents, class FROM Courses";

            try
            {
                using (SqlCommand command = new(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@start_date", start_date);
                    command.Parameters.AddWithValue("@end_date", end_date);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Проект не добавлен: {ex.Message}");
            }
        }*/
    }
}
