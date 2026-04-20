using CommandsApp;
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
public class WindowCommands
{
    static WindowCommands()
    {
        Exit = new RoutedCommand("Exit", typeof(MainWindow));
    }
    public static RoutedCommand Exit { get; set; }
}
namespace CommandsApp
{
      
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();
        }
        public class WindowCommands
        {
            static WindowCommands()
            {
                Exit = new RoutedCommand("Exit", typeof(MainWindow));
            }
            public static RoutedCommand Exit { get; set; }
        }
        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
            {
                writer.WriteLine("Выход из приложения: " + DateTime.Now.ToShortDateString() + " " +
                DateTime.Now.ToLongTimeString());
                writer.Flush();
            }

            this.Close();
        }

    }
 }


