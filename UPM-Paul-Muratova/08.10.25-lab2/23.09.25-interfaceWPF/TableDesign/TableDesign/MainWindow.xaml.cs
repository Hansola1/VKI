using System.Windows;
using TableDesign.Models;

namespace TableDesign
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            loadFakeData();
        }

        public void loadFakeData()
        {
            var users = new List<UserView>
            {
                new UserView
                {
                    Name = "Эублефар",
                    Description = "Описание профиля(текст должен быть выровнен по всей ширине поля + перенос текста). Это пример длинного текста для демонстрации обрезки и переноса.",
                    BloodGroup = "Вторая",
                    Zodiac = "Топтиптоп",
                    CreationDate = "01.04.1999"
                },
                new UserView
                {
                    Name = "Эублефар",
                    Description = "Описание профиля(текст должен быть выровнен по всей ширине поля + перенос текста). Это пример длинного текста для демонстрации обрезки и переноса.",
                    BloodGroup = "Первая",
                    Zodiac = "Траляля",
                    CreationDate = "01.04.1999"
                },
            };

            UserList.ItemsSource = users;
        }
    }
}