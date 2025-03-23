using CarsharingApp.DataBase;
using CarsharingApp.Model;
using System.Windows;
using System.Windows.Controls;

namespace CarsharingApp.Views
{
    public partial class BookingPage : Page
    {
        private DB_TripsController dbTrips;
        private DB_UsersController dbUsers;
        public BookingPage()
        {
            InitializeComponent();
        }

        private void Booking_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Id_Transport_TextBox.Text, out int transportId))
            {
                MessageBox.Show("Введите корректный ID транспорта.");
                return;
            }

            if (!int.TryParse(Duration_TextBox.Text, out int duration) || duration <= 0)
            {
                MessageBox.Show("Введите корректную длительность поездки.");
                return;
            }

            if (!DateTime.TryParse(StartDate_TextBox.Text, out DateTime startDate))
            {
                MessageBox.Show("Введите корректную дату в формате ГГГГ-ММ-ДД.");
                return;
            }

            if (startDate < DateTime.Now.Date)
            {
                MessageBox.Show("Нельзя забронировать поездку на прошедшую дату.");
                return;
            }
            string userLogin = UserSession.CurrentUserLogin;
            int? userID = dbUsers.GetUserID(userLogin);

            if (!double.TryParse(Result_TextBox.Text.Replace(" ₽", "").Trim(), out double costvalue) || costvalue <= 0)
            {
                MessageBox.Show("Ошибка расчета стоимости. Проверьте введенные данные.");
                return;
            }

            dbTrips.AddBooking(transportId, userID, startDate.ToString("yyyy-MM-dd"), duration, costvalue);
            MessageBox.Show("Бронирование успешно оформлено!");
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListTravelPage());
        }

        private void Calculator_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(Duration_TextBox.Text, out int duration) || duration <= 0)
            {
                MessageBox.Show("Введите корректную длительность поездки.");
                return;
            }

            if (!int.TryParse(Time_TextBox.Text, out int time) || time <= 0)
            {
                MessageBox.Show("Введите корректную стоимость за час.");
                return;
            }

            double totalCost = duration * time;
            Result_TextBox.Text = totalCost.ToString("F2") + " ₽"; // Округляем до 2 знаков
        }
    }
}
