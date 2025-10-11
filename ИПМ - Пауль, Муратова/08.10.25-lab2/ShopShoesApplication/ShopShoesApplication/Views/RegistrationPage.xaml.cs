using ShopShoesApplication.DataControl;
using ShopShoesApplication.Models;
using System.Windows;
using System.Windows.Controls;

namespace ShopShoesApplication.Views
{
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            string surname = SurnameTextBox.Text;
            string name = NameTextBox.Text;
            string lastname = LastnameTextBox.Text;

            try
            {
                using (var db = new ApplicationContext())
                {
                    var userRole = db.Role.FirstOrDefault(r => r.Name == "Авторизированный клиент");
                    var user = new User
                    {
                        RoleId = userRole.Id,
                        Surname = surname,
                        Name = name,
                        Lastname = lastname,
                        Login = login,
                        Password = password,
                    };
                    db.Add(user);
                    db.SaveChanges();

                    MessageBox.Show($"Вы успешно создали аккаунт!");
                    MainFrame.Navigate(new LoginPage());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Данные не прошли валидацию. Подробности {ex}");
            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LoginPage());
        }
    }
}
