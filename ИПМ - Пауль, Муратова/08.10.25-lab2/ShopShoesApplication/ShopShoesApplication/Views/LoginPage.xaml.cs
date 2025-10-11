using Microsoft.EntityFrameworkCore;
using ShopShoesApplication.DataControl;
using System.Windows;
using System.Windows.Controls;

namespace ShopShoesApplication.Views
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            try
            {
                using (var db = new ApplicationContext())
                {
                    var user = db.User.Include(r => r.Role).FirstOrDefault(u => u.Login == login && u.Password == password);

                    if (user != null)
                    {
                        if (user.Role.Name == "Администратор")
                        {
                            ///...
                        }
                        else if (user.Role.Name == "Менеджер")
                        {
                            ///...
                        }
                        else
                        {
                            Session.CurrentUser = user;
                            Session.Visit = false;

                            MessageBox.Show($"Вы вошли как клиент!");
                            MainFrame.Navigate(new ProductsPage());
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Данные не прошли валидацию");
            }
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new RegistrationPage());
        }

        private void Visit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Вы вошли как гость!");
            Session.Visit = true;

            MainFrame.Navigate(new ProductsPage());
        }
    }
}
