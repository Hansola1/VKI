using EducationPlans.Model;
using EducationPlans.Model.DataBase;
using EducationPlans.Model.ViewModel;
using EducationPlans.View.Pages;
using System.Windows;
using System.Windows.Controls;

namespace EducationPlans.View
{
    public partial class HomeworkPage : Page
    {
        public HomeworkPage()
        {
            InitializeComponent();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            List<HomeworkView> homework = new List<HomeworkView>();

            try
            {
                using (var db = new ApplicationContext())
                {
                    homework = db.JournalHomework //используй джоин, упрощает ВСЕ
                        .Join(db.Subject, 
                            jh => jh.SubjectID, s => s.Id,
                            (jh, s) => new HomeworkView
                            {
                                Title = jh.Title,
                                Subject = s.Title,
                                Description = jh.Description,
                                Deadline = jh.Deadline
                            }).ToList();
                }

                Homework_DataGrid.ItemsSource = homework;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
                MessageBox.Show($"Полная ошибка: {ex.ToString()}");
            }
        }


        private void AddClick(object sender, EventArgs e)
        {
            if (UserSession.typeUser == "teacher")
            {
                MainFrame.Navigate(new AddHomework());
            }
            else
            {
                MessageBox.Show("Упс, а вы не преподаватель");
            }
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
