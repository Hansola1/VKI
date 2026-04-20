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

namespace CreatUserControl_2
{
    /// <summary>
    /// Логика взаимодействия для usState.xaml
    /// </summary>
    public partial class usState : UserControl
    {
        public usState()
        {
            InitializeComponent();
        }

        public States SelectedState
        {
            get
            {
                return (States)cboState.SelectedItem;
            }
        }

        private void usState_Loaded(object sender, RoutedEventArgs e) // _Load
        {
            //Init data
            List<States> list = new List<States>();
            list.Add(new States() { ID = 1, Name = "Delhi" });
            list.Add(new States() { ID = 2, Name = "Bihar" });
            list.Add(new States() { ID = 3, Name = "Punjab" });
            list.Add(new States() { ID = 4, Name = "UP" });

            cboState.ItemsSource = list; //DataSource
            cboState.SelectedValuePath = "ID"; //ValueMember
            cboState.DisplayMemberPath = "Name";
        }
    }
}
