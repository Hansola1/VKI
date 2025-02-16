using data.DataBase;
using System.Windows;

namespace data
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addUser_Click(object sender, RoutedEventArgs e)
        {
            string login = login_TextBox.Text;
            string password = password_TextBox.Text;
            string email = email_TextBox.Text;
            string age = age_TextBox.Text;
            string sex = sex_TextBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(sex))
            {
                MessageBox.Show("Поля необходимо заполнить");
                return;
            }
            else
            {
                DBControll db = new DBControll();
                db.AddUser(login, password, email, age, sex);
    
                MessageBox.Show($"Пользователь успешно добавлен!");
            }
        }

        private void getUser_Click(object sender, RoutedEventArgs e)
        {
            string ID = ID_TextBox.Text.Trim();

            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Поле необходимо заполнить");
                return;
            }
            else
            {
                DBControll db = new DBControll();
                string login = db.GetLoginUser(ID);

                if (string.IsNullOrEmpty(login))
                {
                    MessageBox.Show("Пользователь не найден");
                }
                else
                {
                    MessageBox.Show($"Пользователь найден: {login}");
                }
            }
        }
    }
}