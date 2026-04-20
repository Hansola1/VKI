using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ScipPictures_WinForm
{
    public partial class Form1 : Form
    {
        int imageIndex = 0;  
        private string[] imageSet = { "E:\\C#\\Разработка программных модулей\\WPF vs WInForm\\ScipPictures_WinForm\\Materials\\1_pict.jpg", "E:\\C#\\Разработка программных модулей\\WPF vs WInForm\\ScipPictures_WinForm\\Materials\\2_pict.jpg", "E:\\C#\\Разработка программных модулей\\WPF vs WInForm\\ScipPictures_WinForm\\Materials\\3_pict.jpg", "E:\\C#\\Разработка программных модулей\\WPF vs WInForm\\ScipPictures_WinForm\\Materials\\4_pict.png", "E:\\C#\\Разработка программных модулей\\WPF vs WInForm\\ScipPictures_WinForm\\Materials\\5_pict.jpeg", "E:\\C#\\Разработка программных модулей\\WPF vs WInForm\\ScipPictures_WinForm\\Materials\\6_pict.jpg", "E:\\C#\\Разработка программных модулей\\WPF vs WInForm\\ScipPictures_WinForm\\Materials\\7_pict.jpg" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxForImageShow();
        }

        private void left_Click(object sender, EventArgs e)
        {
            imageIndex = (imageIndex + 1) % imageSet.Length;
            pictureBoxForImageShow();
        }

        private void right_Click(object sender, EventArgs e)
        {
            imageIndex = (imageIndex - 1 + imageSet.Length) % imageSet.Length;
            pictureBoxForImageShow();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxForImageShow()
        {
            if (File.Exists(imageSet[imageIndex]))
            {
                pictureBoxForImage.Image = Image.FromFile(imageSet[imageIndex]);
            }
            else
            {
                MessageBox.Show("Файл " + imageSet[imageIndex] + " не найден");
            }
        }     
    }
}
