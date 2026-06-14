using FishShopApplication.DataControl;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace FishShopApplication.View
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            try
            {
                using (ShopFishContext db = new ShopFishContext())
                {
                    var user = db.Users.Include(r => r.Role)
                        .FirstOrDefault(u => u.Password == password && u.Login == login);

                    if (user != null)
                    {
                        Session.CurrentUser = user;
                        MainFrame.Navigate(new ProductsPage());
                    }
                    else
                    {
                        MessageBox.Show("Пользователя не существует!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Данные не верны");
            }
        }
    }
}
