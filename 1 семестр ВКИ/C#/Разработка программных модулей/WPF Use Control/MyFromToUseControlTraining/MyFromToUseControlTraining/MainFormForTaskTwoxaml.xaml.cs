using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyFromToUseControlTraining
{
    public partial class MainFormForTaskTwoxaml : Window
    {
        private int totalRecords;
        private int totalAges;

        public MainFormForTaskTwoxaml()
        {
            InitializeComponent();
        }

        private void sumAge_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void get_Click(object sender, RoutedEventArgs e)
        {
            var edit = new PersonRecordEditDialog();
            edit.Show();
            this.Close();
        }

        private void full_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        /*private void InitializePanel()
        {
            panelPerson = new FlowLayoutPanel();
            // Добавление панели на форму
            this.Controls.Add(panelPerson);
        } 

        private void AddButton_Click(object sender, EventArgs e)
        {
            PersonRecordUserControl newRecord = new PersonRecordUserControl();
            panel.Controls.Add(newRecord);
        }*/
    }
   
}
