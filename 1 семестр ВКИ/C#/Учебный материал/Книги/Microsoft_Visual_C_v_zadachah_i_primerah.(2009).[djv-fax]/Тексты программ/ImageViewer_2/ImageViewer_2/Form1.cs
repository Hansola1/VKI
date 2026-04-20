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
        // список jpg-файлов
        List<string> imgList = new List<string>();
        int nImg = 0;  // номер (в списке) отображаемой иллюстрации

        int pbw, pbh,     // первоначальный размер
            pbX, pbY;     // и положение pictureBox  

        string aPath;     // путь к файлам

        public Form1()
        {
            InitializeComponent();

            // запомнить размер 
            // и положение pictureBox1
            pbh = pictureBox1.Height;
            pbw = pictureBox1.Width;
            pbX = pictureBox1.Location.X;
            pbY = pictureBox1.Location.Y;

            DirectoryInfo di; // каталог
            // получить имя каталога "Мои рисунки"
            di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            aPath = di.FullName;

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

            // очистить список иллюстраций
            imgList.Clear();

            // добавляем в imgList имена jpg-файлов
            // каталога aPath
            foreach (FileInfo fc in fi)
            {
                imgList.Add(fc.Name);
            }

            if (fi.Length == 0) return false;
            else
            {
                nImg = 0;
                ShowPicture(aPath + "\\" + imgList[nImg]);

                // сделать недоступной кнопку Предыдущая 
                button2.Enabled = false;

                // если в каталоге один jpg-файл,
                // сделать недоступной кнопку Следующая 
                if (imgList.Count == 1)
                    button3.Enabled = false;

                this.Text = aPath;

                return true;
            }
        }

        // выводит иллюстрацию в поле компонента pictureBox1
        private void ShowPicture(string aPicture)
        {
            double mh, mw;   // коэффициенты масштабирования

            pictureBox1.Visible = false;
            pictureBox1.Left = pbX;

            // загружаем изображение в pictureBox1
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image =
                new Bitmap(aPicture);

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

        // предыдущая картинка
        private void button2_Click(object sender, EventArgs e)
        {
            // если кнопка "Следующая" недоступна,
            // сделаем ее доступной
            if (!button3.Enabled)
                button3.Enabled = true;

            if (nImg > 0)
            {
                nImg--;
                ShowPicture(aPath + "\\" + imgList[nImg]);

                // отображается первая иллюстрация 
                if (nImg == 0)
                {
                    // теперь кнопка Предыдущая недоступна 
                    button2.Enabled = false;
                }
            }
        }

        // следующая картинка 
        private void button3_Click(object sender, EventArgs e)
        {
            if (!button2.Enabled)
                button2.Enabled = true;

            if (nImg < imgList.Count)
            {
                nImg++;
                ShowPicture(aPath + "\\" + imgList[nImg]);
                if (nImg == imgList.Count-1)
                {
                    button3.Enabled = false;
                }
            }
        }

        // щелчок на кнопке Обзор
        private void button1_Click(object sender, EventArgs e)
        {
            // FolderBrowserDialog - окно Обзор папок
            FolderBrowserDialog fb
                            = new FolderBrowserDialog();

            fb.Description =
                  "Выберите папку,\n" + "в которой находятся иллюстрации";
            
            // кнопка создать папку недоступна
            fb.ShowNewFolderButton = false; 
                        
            // "стартовая" папка
            fb.SelectedPath = aPath;
            
            // отображаем диалоговое окно
            if (fb.ShowDialog() == DialogResult.OK)
            {
                // пользователь выбрал каталог и
                // щелкнул на кнопке OK
                aPath = fb.SelectedPath;
                

                if (!FillListBox(fb.SelectedPath))
                    // в каталоге нет файлов иллюстраций
                    pictureBox1.Image = null;
            }
        }


    }
}
