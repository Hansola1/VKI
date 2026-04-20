using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace Раздел_3_и_4__WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        

        private void Control_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textBlock1.Text = textBlock1.Text + "sender: " + sender.ToString() + "\n";
            textBlock1.Text = textBlock1.Text + "source: " + e.Source.ToString() + "\n\n";
        }
     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка нажата");
        }
        /*private void button1_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "Привет!";
        }
        */
       /* private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Действие выполнено");
        }

        private void escButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // закрытие окна
        }
       */
        public MainWindow()
        {
            InitializeComponent();
            //
            /*button1.Cursor = Cursors.Wait;
            button1.Background = new SolidColorBrush(Colors.Red);
            button1.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            */
            /*double d = 5.6;
            button1.Content = d;
            button1.Content = new Button { Content = "Hello" };
            */
        
        }

        //private void Up_Click(object sender, RoutedEventArgs e)
        //{
        //    scroll.LineUp();
        //}

        //public void Down_Click(object sender, RoutedEventArgs e)
        //{
        //    scroll.LineDown();
        //}

    }
}
