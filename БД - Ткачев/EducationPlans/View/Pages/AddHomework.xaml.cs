using EducationPlans.Model.DataBase;
using EducationPlans.View.Pages;
using EducationPlans.Model.ViewModel;
using EducationPlans.Model;
using System.Windows;
using System.Windows.Controls;
using System.Diagnostics.Metrics;

namespace EducationPlans.View.Pages
{
    public partial class AddHomework : Page
    {
        public AddHomework()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            using (var db = new ApplicationContext())
            {
                SubjectSelector.ItemsSource = db.Subject.ToList();
                SubjectSelector.DisplayMemberPath = "Title";
                SubjectSelector.SelectedValuePath = "Id";
            }
        }

        private void addClick(object sender, RoutedEventArgs e)
        {
            string startDate = startDateTextBox.Text;
            string titleHomework = titleHomeworkTextBox.Text;
            string descriptionHomework = descriptionHomeworkTextBox.Text;
            var selectedSubject = SubjectSelector.SelectedItem as Subject;

            if (string.IsNullOrWhiteSpace(startDate) || string.IsNullOrWhiteSpace(descriptionHomework) ||
                string.IsNullOrWhiteSpace(titleHomework) || selectedSubject == null)
            {
                MessageBox.Show("Все поля должны быть заполнены.");
                return;
            }

            if (!DateTime.TryParse(startDate, out DateTime deadline))
            {
                MessageBox.Show("Неверный формат даты.");
                return;
            }

            using (var db = new ApplicationContext())
            {
                var journalHomework = new JournalHomework
                {
                    Title = titleHomework,
                    Description = descriptionHomework,
                    Deadline = deadline,
                    SubjectID = selectedSubject.Id,
                    ScheduleID = 2, //пока эту логику на потом
                };

                db.JournalHomework.Add(journalHomework);
                db.SaveChanges();

                MessageBox.Show("Домашняя работа успешно добавлена!");

                titleHomeworkTextBox.Text = "";
                descriptionHomeworkTextBox.Text = "";
                startDateTextBox.Text = "";
                SubjectSelector.SelectedIndex = -1;
            }
        }

        private void outClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LoginPage());
        }
    }
}
