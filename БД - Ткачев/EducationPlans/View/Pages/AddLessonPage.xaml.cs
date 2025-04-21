using EducationPlans.Model.DataBase;
using EducationPlans.View.Pages;
using EducationPlans.Model.ViewModel;
using EducationPlans.Model;
using System.Windows;
using System.Windows.Controls;
using System.Diagnostics.Metrics;

namespace EducationPlans.View.Pages
{
    public partial class AddLessonPage : Page
    {
        public AddLessonPage()
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
 
                ClassSelector.ItemsSource = db.Class.ToList();
                ClassSelector.DisplayMemberPath = "Title";

                GroupSelector.ItemsSource = db.Groups.ToList();
                GroupSelector.DisplayMemberPath = "Title";
            }
        }

        private void addClick(object sender, RoutedEventArgs e)
        {
            string startDate = startDateTextBox.Text;
            string endDate = endDateTextBox.Text;
            string group = GroupSelector.Text;
            string classes = ClassSelector.Text;
            string subject = SubjectSelector.Text;
            string teacherName = teacherTextBox.Text;

            if (string.IsNullOrWhiteSpace(startDate) || string.IsNullOrWhiteSpace(endDate) ||
                string.IsNullOrWhiteSpace(group) || string.IsNullOrWhiteSpace(classes) ||
                string.IsNullOrWhiteSpace(subject) || string.IsNullOrWhiteSpace(teacherName))
            {
                MessageBox.Show("Все поля должны быть заполнены.");
                return;
            }

            if (!DateTime.TryParse(startDate, out DateTime dateStart) || !DateTime.TryParse(endDate, out DateTime dateEnd))
            {
                MessageBox.Show("Неверный формат даты.");
                return;
            }

            using (var db = new ApplicationContext())
            {
                var teacher = db.Teacher.FirstOrDefault(s => s.Name == teacherName);
                if (teacher == null)
                {
                    MessageBox.Show($"Преподаватель '{teacherName}' не найден");
                    return;
                }
                var classe = db.Class.FirstOrDefault(s => s.Title == classes);
                if (classe == null)
                {
                    MessageBox.Show($"Класс '{teacherName}' не найден");
                    return;
                }
                var subjecte = db.Class.FirstOrDefault(s => s.Title == subject);
                if (subjecte == null)
                {
                    MessageBox.Show($"Предмет '{subject}' не найден");
                    return;
                }
                var groupe = db.Class.FirstOrDefault(s => s.Title == group);
                if (groupe == null)
                {
                    MessageBox.Show($"Группа '{group}' не найденa");
                    return;
                }

                var specSubj = db.SpecializationSubject.FirstOrDefault(s => s.SubjectID == subjecte.Id && s.TeacherID == teacher.Id);
                if (specSubj == null)
                {
                    MessageBox.Show("Предмет не соответствует специализации преподавателя.");
                    return;
                }

                var schedule = new Schedule
                {
                    TimeStart = dateStart,
                    TimeEnd = dateEnd,
                    ClassID = classe.Id,
                    GroupID = groupe.Id,
                    SpecializationSubjectID = specSubj.Id
                };

                db.Schedule.Add(schedule);
                db.SaveChanges();

                MessageBox.Show("Занятие в расписание успешно добавлено!");
            }
        }

        private void outClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LoginPage());
        }
    }
}
