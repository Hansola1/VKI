using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;

using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CreatUserControl
{
    [DefaultEvent(nameof(TextChanged))] //DefaultEvent - задает событие
    public partial class ClearTextBox : UserControl
    {
        public ClearTextBox()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public event EventHandler TextChanged;

         //Browsable - видимость события
        //public new event EventHandler? TextChanged
        /*public override event EventHandler TextChanged
        {
            add => txtValue.TextChanged += value;
            remove => txtValue.TextChanged -= value;
        }*/

        [Browsable(true)]
        public new string Text
        {
            get => txtValue.Text;
            set => txtValue.Text = value;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Text = ""; 
        }
    }
}
