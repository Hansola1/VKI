using System.Windows;
using System.Windows.Controls;
using EntityFrameworkLearn.Model;

namespace EntityFrameworkLearn.Views
{
    public partial class CharactersPage : Page
    {
        public CharactersPage()
        {
            InitializeComponent();
        }

        public void AddPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(login_TextBox.Text))
            {
                MessageBox.Show("Заполните поля");
            }

            using (var db = new ApplicationContext())
            {
                var player = new Players
                {
                    Name = name_TextBox.Text,
                    Login = login_TextBox.Text,
                    Password = password_TextBox.Text,
                };
                MessageBox.Show("Игрок создан");

                db.Players.Add(player); // НЕ ПИШИ РУКАМИ ЗАПРОСЫ. Встроенная функция внесет в БД нового пользователя.
                db.SaveChanges();
            }
        }
    }
}
