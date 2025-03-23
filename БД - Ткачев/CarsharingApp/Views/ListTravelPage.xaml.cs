using CarsharingApp.DataBase;
using CarsharingApp.Model;
using System.Windows;
using System.Windows.Controls;

namespace CarsharingApp.Views
{

    public partial class ListTravelPage : Page
    {
        private DB_UsersController dbUsers = new();
        private DB_TripsController dbTrips = new();
        public ListTravelPage()
        {
            InitializeComponent();
            loadUser();
            loadTrips();
        }

        private void loadUser()
        {
            string login = UserSession.CurrentUserLogin;
            User user = dbUsers.GetUser(login);

            if (user != null)
            {
                FirstName_TextBox.Text = user.FirstName;
                LastName_TextBox.Text = user.LastName;
                Surname_TextBox.Text = user.Surname;
                Phone_TextBox.Text = user.Phone;
                Email_TextBox.Text = user.Email;
            }
            else
            {
                MessageBox.Show("Ошибка загрузки данных пользователя.");
            }
        }

        private void loadTrips()
        {
            List<Trips> trips = dbTrips.GetTrips();
            Trips_ListView.ItemsSource = trips;
        }

        private void Booking_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new BookingPage());
        }
    }
}
