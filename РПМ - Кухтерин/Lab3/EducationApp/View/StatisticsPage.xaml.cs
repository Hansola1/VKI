using EducationApp.DataBase;
using EducationApp.Model;
using System.Windows;
using System.Windows.Controls;

namespace EducationApp.View
{
    public partial class StatisticsPage : Page
    {
        CourseControllDB courseDB = new CourseControllDB();
        public StatisticsPage()
        {
            InitializeComponent();
            LoadStatistics();
        }

    private void LoadStatistics()
    {
        List<Statistics> listCourse = courseDB.GetStatisticsSex();
        Statistics_ListView.ItemsSource = listCourse;
    }

    private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }
    }
}
