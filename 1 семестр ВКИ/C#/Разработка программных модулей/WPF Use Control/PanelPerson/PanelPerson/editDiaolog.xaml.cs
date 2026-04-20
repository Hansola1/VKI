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
using System.Windows.Shapes;

namespace PanelPerson
{
    public partial class editDiaolog : Window
    {
        public string NameP { get; private set; }
        public string Lastname { get; private set; }
        public string Fathername { get; private set; }
        public string Age { get; private set; }

        public editDiaolog(string firstName, string lastName, string middleName, string age)
        {
            InitializeComponent();
            NameP = firstName;
            Lastname = lastName;
            Fathername = middleName;
            Age = age;

            NamePTextBox.Text = NameP;
            LastnameTextBox.Text = Lastname;
            FathernameTextBox.Text = Fathername;
            AgeTextBox.Text = Age;
        }


        private void save_Click(object sender, RoutedEventArgs e)
        {
            NameP = NamePTextBox.Text;
            Lastname = LastnameTextBox.Text;
            Fathername = FathernameTextBox.Text;
            Age = AgeTextBox.Text;

            DialogResult = true;
            this.Close();
        }
    }
}
