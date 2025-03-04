using EducationApp.DataBase;
using EducationApp.Model;
using EducationApp.Models;
using System.Windows;
using System.Windows.Controls;

namespace EducationApp.View
{
    public partial class StatisticsPage : Page
    {
        UserControllDB usersDB = new UserControllDB();
        public StatisticsPage()
        {
            InitializeComponent();
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            List<Statistics> listCourse = usersDB.GetStatisticsRole();
            Statistics_ListView.ItemsSource = listCourse;
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }
    }
}
