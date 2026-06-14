using demo.Data;
using demo.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace demo.Windows
{
    public partial class Authorization : Window
    {
        private DemoContext context;
        public Authorization()
        {
            InitializeComponent();
            context = new DemoContext();
        }

        private void Button_authorization(object sender, RoutedEventArgs e)
        {
            string login = BoxLogin.Text;
            string password = BoxPassword.Text;

            if (login == null || password == null)
            {
                MessageBox.Show("Заполните все поля");
            }

            try
            {
                User user = context.Users.FirstOrDefault(q => q.Login == BoxLogin.Text && q.Password == BoxPassword.Text);
                user.RoleNavigation = context.Roles.FirstOrDefault(q => q.Id == user.Role);

                if (user != null)
                {
                    Main main = new Main(user);
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ОШИБКА: Перепроверьте данные. См.подробности: {ex.Message}");
            }
        }

        private void Button_authorization_gouest(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}