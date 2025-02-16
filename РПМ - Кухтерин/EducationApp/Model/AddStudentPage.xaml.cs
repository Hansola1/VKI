using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace EducationApp.Model
{
    public partial class AddStudentPage : Page
    {
        public AddStudentPage()
        {
            InitializeComponent();
        }

        public void cancel_button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }

        public void add_student_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Студент добавлен!");
        }
    }
}
