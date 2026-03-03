using BuildingShopApplication.DataControl;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace BuildingShopApplication.Views
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
                using (BuildingShopDbContext db = new())
                {
                    var user = db.Users.Include(r => r.Role)
                        .FirstOrDefault(u => u.Login == login && u.Password == password);

                    if (user != null)
                    {
                        MessageBox.Show($"УСПЕШНО: Вы авторизовались с ролью {user.Role.Name}!");
                        Session.User = user;

                        MainFrame.Navigate(new ProductsPage());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ОШИБКА: Перепроверьте данные. См.подробности: {ex.Message}");
            }
        }
    }
}
