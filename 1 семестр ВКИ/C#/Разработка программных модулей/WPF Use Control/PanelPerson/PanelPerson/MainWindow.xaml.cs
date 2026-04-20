using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class MainWindow : Window
    {
        private int full = 0;
        private int SumAge = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void get_Click(object sender, RoutedEventArgs e)
        {
            panel newPanel = new panel();
           // container.Children.Add(newPanel);

            newPanel.EditButtonClicked += EditButtonClickedHandler;
            newPanel.DeleteButtonClicked += DeleteButtonClickedHandler;

            full++;
            totalRecordsTextBox.Text = $"Всего записей: {full}";
        }


        private void EditButtonClickedHandler(object sender, EventArgs e)
        {
            panel pap = new panel();
            editDiaolog dialog = new editDiaolog(pap.firstNameTextBox.Text, pap.lastNameTextBox.Text, pap.middleNameTextBox.Text, pap.ageTextBox.Text);
            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                pap.UpdateData(dialog.NameP, dialog.Lastname, dialog.Fathername, dialog.Age);
            }
        }


        private void DeleteButtonClickedHandler(object sender, EventArgs e)
        {
            panel newPanel = new panel();
            newPanel.UpdateData("", "", "", "");
        }
    }
}
