using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EducationApp.Model
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
