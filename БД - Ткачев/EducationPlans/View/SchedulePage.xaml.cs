using EducationPlans.Model;
using EducationPlans.Model.DataBase;
using EducationPlans.Model.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace EducationPlans.View
{
    public partial class SchedulePage : Page
    {
        public SchedulePage()
        {
            InitializeComponent();
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            List<ScheduleView> schedules = new List<ScheduleView>();

            using (var db = new ApplicationContext())
            {
                schedules = db.Schedule.Select(s => new ScheduleView
                {
                    TimeStart = s.TimeStart,
                    TimeEnd = s.TimeEnd,
                    ClassTitle = db.Class.FirstOrDefault(c => c.Id == s.ClassID).Title,
                    GroupTitle = db.Groups.FirstOrDefault(g => g.Id == s.GroupID).Title,
                    SubjectTitle = db.Subject.FirstOrDefault(sub => sub.Id == db.SpecializationSubject.FirstOrDefault(ss => ss.Id == s.SpecializationSubjectID).SubjectID).Title,
                    TeacherName = db.Teacher.FirstOrDefault(t => t.Id == db.SpecializationSubject.FirstOrDefault(ss => ss.Id == s.SpecializationSubjectID).TeacherID).Name
                }).ToList();
            }

            ScheduleDataGrid.ItemsSource = schedules;
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
    }   
}
