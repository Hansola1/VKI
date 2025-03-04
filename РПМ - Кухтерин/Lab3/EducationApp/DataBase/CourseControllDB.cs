using data.DataBase;
using EducationApp.Model;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows;

namespace EducationApp.DataBase
{
    class CourseControllDB : DBControll
    {
        public void AddCourse(string title, int teacherID, string time, string maxStudents, string classRoom)
        {
            Connection();
            Convert.ToInt32(maxStudents);
            string query = "INSERT INTO Courses (titleCourse, teacherID, time, maxStudents, class) VALUES (@titleCourse, @teacherID, @time, @maxStudents, @class)";

            try
            {
                using (SqlCommand command = new(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@titleCourse", title);
                    command.Parameters.AddWithValue("@teacherID", teacherID);
                    command.Parameters.AddWithValue("@time", time);
                    command.Parameters.AddWithValue("@maxStudents", maxStudents);
                    command.Parameters.AddWithValue("@class", classRoom);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Курс не добавлен: {ex.Message}");
            }
        }

        public int GetTeacherID(string nameTeacher)
        {
            Connection();
            string query = "SELECT id FROM Users WHERE name = @name";
            int teacherID = -1;

            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@name", nameTeacher);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        teacherID = reader.GetInt32(0);
                    }
                }
            }
            return teacherID;
        }

        public bool CourseExists(string courseTitle)
        {
            Connection();
            string query = "SELECT COUNT(*) FROM Courses WHERE titleCourse = @titleCourse";

            using (SqlCommand command = new(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@titleCourse", courseTitle);
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public List<Courses> GetCourses()
        {
            Connection();
            List<Courses> coursesList = new List<Courses>();
            string query = "SELECT id, titleCourse, teacherID, time, maxStudents, class FROM Courses";

            using (SqlCommand command = new(query, sqlConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        coursesList.Add(new Courses
                        {
                            TitleCourse = reader["titleCourse"].ToString(),
                            TeacherID = Convert.ToInt32(reader["teacherID"]),
                            Time = reader["time"].ToString(),
                            MaxStudents = Convert.ToInt32(reader["maxStudents"]),
                            ClassRoom = reader["class"].ToString()
                        });
                    }
                }
            }
            return coursesList;
        }

        public List<Requestes> GetRequestCourse()
        {
            Connection();
            List<Requestes> requestCourseList = new List<Requestes>();
            string query = "SELECT StudentName, ApplicationDate, Status FROM ListRequest";

            using (SqlCommand command = new(query, sqlConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        requestCourseList.Add(new Requestes
                        {
                            StudentName = reader["StudentName"].ToString(),
                            DateRequest = reader["ApplicationDate"].ToString(),
                            Status = reader["Status"].ToString(),
                        });
                    }
                }
            }
            return requestCourseList;
        }

        public void AddStudentToCourse(int studentID, int courseID)
        {
            Connection();
            string query = "INSERT INTO CourseEnrollments (courseID, studentID) VALUES (@courseID, @studentID)";

            try
            {
                using (SqlCommand command = new(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@courseID", courseID);
                    command.Parameters.AddWithValue("@studentID", studentID);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось добавить студента на курс: {ex.Message}");
            }
        }
    }
}
