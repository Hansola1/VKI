using EducationApp.DataBase;
using EducationApp.Model;
using System.Windows;
using System.Windows.Controls;

namespace EducationApp.View
{
    public partial class ListRequest : Page
    {
        private CourseControllDB courseDB = new();

        public ListRequest()
        {
            InitializeComponent();
            LoadListRequest();
        }
        private void LoadListRequest()
        {
            List<Requestes> ListRequest = courseDB.GetRequestCourse();
            CourseRequest_ListView.ItemsSource = ListRequest;
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }
    }
}
