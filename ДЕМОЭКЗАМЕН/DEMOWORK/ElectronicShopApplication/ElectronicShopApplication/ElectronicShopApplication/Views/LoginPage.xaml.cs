using ElectronicShopApplication.DataControl;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace ElectronicShopApplication.Views
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ToProduct_Click(object sender, RoutedEventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                using(ElectronicShopContext db = new())
                {
                    var user = db.Users.Include(r => r.Role)
                        .FirstOrDefault(u => u.Login == login && u.Password == password);

                    if (user != null)
                    {
                        if (user.Role.RoleName == "Администратор")
                        {
                            MessageBox.Show($"УСПЕШНО: Вы авторизовались с роль администратор!");
                        }
                        else
                        {
                            MessageBox.Show($"УСПЕШНО: Вы авторизовались с роль пользователь!");
                        }
                        Session.User = user;
                        MainFrame.Navigate(new ProductsPage());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"ОШИБКА: Перепроверьте данные. См.подробности: {ex.Message}");
            }
        }
    }
}
