using Laboratory.View;
using System.Windows;


namespace Laboratory
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Out_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); 
        }

        public void ToTable_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TablesInfo());
        }
    }
}
