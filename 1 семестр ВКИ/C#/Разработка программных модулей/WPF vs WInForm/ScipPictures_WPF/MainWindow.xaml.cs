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
using System.IO;

namespace ScipPictures_WPF
{
    public partial class MainWindow : Window
    {
        int imageIndex = 0;
        private string[] imageSet = { "E:\\C#\\Разработка программных модулей\\WPF vs WInForm\\ScipPictures_WPF\\Materials\\1_pict.jpg", "E:\\C#\\Разработка программных модулей\\WPF vs WInForm\\ScipPictures_WPF\\Materials\\2_pict.jpg", "E:\\C#\\Разработка программных модулей\\WPF vs WInForm\\ScipPictures_WPF\\Materials\\3_pict.jpg", "E:\\C#\\Разработка программных модулей\\WPF vs WInForm\\ScipPictures_WPF\\Materials\\4_pict.png", "E:\\C#\\Разработка программных модулей\\WPF vs WInForm\\ScipPictures_WPF\\Materials\\5_pict.jpeg", "E:\\C#\\Разработка программных модулей\\WPF vs WInForm\\ScipPictures_WPF\\Materials\\6_pict.jpg", "E:\\C#\\Разработка программных модулей\\WPF vs WInForm\\ScipPictures_WPF\\Materials\\7_pict.jpg" };

        public MainWindow()
        {
            InitializeComponent();
            pictureBoxForImageShow();
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            imageIndex = (imageIndex + 1) % imageSet.Length;
            pictureBoxForImageShow();
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            imageIndex = (imageIndex - 1 + imageSet.Length) % imageSet.Length;
            pictureBoxForImageShow();
        }

        private void pictureBoxForImageShow()
        {
            if (File.Exists(imageSet[imageIndex]))
            {
                BitmapImage bitmap = new BitmapImage(new Uri(imageSet[imageIndex]));
                ImageList.Source = bitmap;
                //ImageList.Image = Image.FromFile(imageSet[imageIndex]);
            }
            else
            {
                MessageBox.Show("Файл " + imageSet[imageIndex] + " не найден");
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ImageList_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }
    }
}
