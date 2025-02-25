using System;
using System.Windows;
using System.Windows.Controls;

namespace EducationApp.View.old
{
    public partial class EditStudentPage : Page
    {
        public EditStudentPage()
        {
            InitializeComponent();
        }

        public void cancel_Click(object sender, EventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }

        public void save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Студент изменен!");
        }
    }
}
