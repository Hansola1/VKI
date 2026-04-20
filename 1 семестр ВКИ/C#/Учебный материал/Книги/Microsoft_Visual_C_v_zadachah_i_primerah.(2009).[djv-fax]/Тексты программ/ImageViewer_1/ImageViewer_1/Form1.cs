using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        int pbw, pbh,     // первоначальный размер
            pbX, pbY;     // и положение pictureBox  

        string aPath;     // путь к файлам картинок

        public Form1()
        {
            InitializeComponent();

            // запомнить размер 
            // и положение pictureBox1
            pbh = pictureBox1.Height;
            pbw = pictureBox1.Width;
            pbX = pictureBox1.Location.X;
            pbY = pictureBox1.Location.Y;
            

            // элементы listBox1 сортируются в
            // алфавитном порядке
            listBox1.Sorted = true;

            DirectoryInfo di; // каталог
            // получить имя каталога "Мои рисунки"
            di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            aPath = di.FullName;
            label1.Text = aPath;

            // сформировать список иллюстраций
            FillListBox(aPath);
        }

        // формирует список иллюстраций
        // aPath - путь к файлам иллюстраций
        private Boolean FillListBox(string aPath)
        {
            // информация о каталоге
            DirectoryInfo di =
                new DirectoryInfo(aPath);

            // информация о файлах
            FileInfo[] fi = di.GetFiles("*.jpg");

            // очистить список listBox
            listBox1.Items.Clear();

            // добавляем в listBox1 имена jpg-файлов,
            // содержащихся в каталоге aPath
            foreach (FileInfo fc in fi)
            {
                listBox1.Items.Add(fc.Name);
            }

            label1.Text = aPath;

            if (fi.Length == 0) return false;
            else
            {
                // выбираем первый файл из полученного списка
                listBox1.SelectedIndex = 0;
                return true;
            }
        }

        // пользователь выбрал другой
        // элемент списка щелчком кнопкой
        // мыши или перемещением по списку
        // при помощи клавиатуры 
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double mh, mw;   // коэффициенты масштабирования

            pictureBox1.Visible = false;
            pictureBox1.Left = pbX;

            // загружаем изображение в pictureBox1
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image =
                new Bitmap( aPath + "\\" + 
                           listBox1.SelectedItem.ToString());

            // масштабируем, если нужно
            if ((pictureBox1.Image.Width > pbw) ||
                (pictureBox1.Image.Height > pbh))
            {
                pictureBox1.SizeMode =
                    PictureBoxSizeMode.StretchImage;

                mh = (double)pbh / (double)pictureBox1.Image.Height;
                mw = (double)pbw / (double)pictureBox1.Image.Width;

                if (mh < mw)
                {
                    // масштабируем по ширине
                    pictureBox1.Width = Convert.ToInt16(
                            pictureBox1.Image.Width * mh);
                    pictureBox1.Height = pbh;
                }
                else
                {
                    // масштабируем по высоте
                    pictureBox1.Width = pbw;
                    pictureBox1.Height = Convert.ToInt16(
                            pictureBox1.Image.Height * mw);
                }
            }

            // разместить картинку в центре области
            // отображения иллюстраций
            pictureBox1.Left = pbX + (pbw - pictureBox1.Width) / 2;
            pictureBox1.Top = pbY + (pbh - pictureBox1.Height) / 2;

            pictureBox1.Visible = true; 
        }

        // щелчок на кнопке Обзор
        private void button1_Click(object sender, EventArgs e)
        {
            // FolderBrowserDialog - окно Обзор папок
            FolderBrowserDialog fb
                            = new FolderBrowserDialog();

            fb.Description =
                  "Выберите папку,\n" +"в которой находятся иллюстрации";
            fb.ShowNewFolderButton = false;

            // отображаем диалоговое окно
            if (fb.ShowDialog() == DialogResult.OK)
            {
                // пользователь выбрал каталог и
                // щелкнул на кнопке OK
                aPath = fb.SelectedPath;
                label1.Text = aPath;

                if ( !FillListBox(fb.SelectedPath))
                    // в каталоге нет файлов иллюстраций
                    pictureBox1.Image = null;
            }
        }
    }
}
