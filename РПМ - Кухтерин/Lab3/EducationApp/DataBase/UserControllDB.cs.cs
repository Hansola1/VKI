using data.DataBase;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows;
using EducationApp.Model;
using EducationApp.Models;

namespace EducationApp.DataBase
{
    class UserControllDB : DBControll
    {
        public bool dateVerification(string login, string password)
        {
            Connection();
            string query = "SELECT * FROM Users WHERE login = @login AND password = @password";

            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
        }

        public void AddUser(string name, string login, string password, int roleID)
        {
            Connection();
            string query = "INSERT INTO Users (name, login, password, roleID) VALUES (@name, @login, @password, @roleID)";

            try
            {
                using (SqlCommand command = new(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@roleID", roleID);

                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                MessageBox.Show("Пользователь не добавлен");
                Application.Current.Shutdown();
            }
        }

        private int CalculatorRoleStatistics(string role)
        {
            Connection();
            int teacherCount = 0;
            int studentCount = 0;

            if (role == "student")
            {
                string studentQuery = "SELECT COUNT(*) FROM Users WHERE roleID = '3'";
                using (SqlCommand command = new(studentQuery, sqlConnection))
                {
                    studentCount = (int)command.ExecuteScalar();
                }
                return studentCount;
            }
            else if(role == "teacher")
            {
                string teacherQuery = "SELECT COUNT(*) FROM Users WHERE roleID = '2'";
                using (SqlCommand command = new(teacherQuery, sqlConnection))
                {
                    teacherCount = (int)command.ExecuteScalar();
                }
                return teacherCount;
            }
            return 0;
        }

        public List<Statistics> GetStatisticsRole()
        {
            List<Statistics> statisticsList = new List<Statistics>();

            int studentCount = CalculatorRoleStatistics("student");
            int teacherCount = CalculatorRoleStatistics("teacher");

            statisticsList.Add(new Statistics
            {
                TotalCount = studentCount + teacherCount, 
                StudentCount = studentCount,
                TeacherCount = teacherCount
            });

            return statisticsList;
        }
    }
}
