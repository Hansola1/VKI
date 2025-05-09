using EducationPlans.Model;
using System.Windows;
using System.Windows.Controls;

namespace EducationPlans.View
{
    public partial class JournalPage : Page
    {
        public JournalPage()
        {
            InitializeComponent();
        }

        private void OutClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LoginPage());
        }
        private void ScheduleClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SchedulePage());
        }
        private void JournalClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new JournalPage());
        }
        private void HomeworkClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new JournalHomework());
        }
    }
}
