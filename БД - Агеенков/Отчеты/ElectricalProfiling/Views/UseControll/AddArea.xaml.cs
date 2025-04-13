using ElectricalProfiling.Model;
using System.Windows;
using System.Windows.Controls;

namespace ElectricalProfiling.Views.UseControll
{
    public partial class AddArea : UserControl
    {
        public AddArea()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string nameProject = ProjectName_TextBox.Text;
            string nameArea = AreaName_TextBox.Text;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            var parent = Parent as Panel;
            parent?.Children.Remove(this);
        }
    }
}
