using data.DataBase;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows;
using CarsharingApp.Model;

namespace CarsharingApp.DataBase
{
    public class DB_TripsController : DBControl
    {
        public List<Trips> GetTrips()
        {
            Connection();
            string query = "SELECT transportid, userid, startdt, duration, costvalue, ispaid FROM trips";
            List<Trips> tripsList = new List<Trips>();

            try
            {
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tripsList.Add(new Trips
                            {
                                TransportId = Convert.ToInt32(reader["transportid"]),
                                UserId = Convert.ToInt32(reader["userid"]),
                                Startdt = reader["startdt"].ToString(),
                                Duration = Convert.ToInt32(reader["duration"]),
                                CostValue = Convert.ToDouble(reader["costvalue"]),
                                IsPaid = Convert.ToBoolean(reader["ispaid"])
                            });
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка загрузки поездок: " + ex.Message);
            }
            return tripsList;
        }

        public void AddBooking(int transportId, int? userId, string startDate, int duration, double costvalue)
        {
            Connection();
            string query = "INSERT INTO trips (transportid, userid, startdt, duration, costvalue, ispaid) " +
                "VALUES (@transportId, @userId, @startdt, @duration, @costvalue, 0)"; // 0 - стоимость по умолчанию, 0 - не оплачено

            try
            {
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@transportId", transportId);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@startdt", startDate);
                    command.Parameters.AddWithValue("@duration", duration);
                    command.Parameters.AddWithValue("@costvalue", costvalue);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Бронирование успешно!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка при бронировании: " + ex.Message);
            }
        }
    }
}
