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
    /// <summary>
    /// Логика взаимодействия для PersonRecordEditDialog.xaml
    /// </summary>
    public partial class PersonRecordEditDialog : Window
    {
 

        public PersonRecordEditDialog()
        {
            InitializeComponent();
        }


        private void save_Click(object sender, RoutedEventArgs e)
        {
            panel newRecord = new panel();
            //panel.Controls.Add(newRecord);
            this.Close();
        }


    }
}
