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

namespace PanelPerson
{
    public partial class panel : UserControl
    {
        public event EventHandler EditButtonClicked;
        public event EventHandler DeleteButtonClicked;

        public panel()
        {
            InitializeComponent();
        }


        public void UpdateData(string firstName, string lastName, string middleName, string age)
        {
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            middleNameTextBox.Text = middleName;
            ageTextBox.Text = age.ToString();
        }

        private void EditButtonClick(object sender, RoutedEventArgs e)
        {
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
