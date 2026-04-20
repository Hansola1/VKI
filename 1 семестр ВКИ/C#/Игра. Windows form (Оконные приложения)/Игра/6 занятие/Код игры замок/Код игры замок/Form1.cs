using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Код_игры_замок
{
    public partial class Form1 : Form
    {
        Bitmap Pict;//Переменная для рисунка
        Graphics g;//Графическая поверхность для рисунка
        PictureBox[,] Pb = new PictureBox[4, 4];//Массив PictureBox
        int h, w, i0, j0, x0, y0;
        int clik = 1;


        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();//Создаем поверхность

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        public void Pb_Click(object sender, EventArgs e)
        {
            //Обработчик щелчка по Pb[i,j]

            PictureBox Pib;
            Pib = (PictureBox)sender;
            if (clik == 1)
            {
                j0 = (Pib.Left - x0) / w;//Номер столбца и строки элемента,
                i0 = (Pib.Top - y0) / h;//по которому кликнули - запомнили.
                pictureBox1.Image = Pib.Image;//Изображение сохранили
                clik = 2;
            }
            else
            {//Перестановка
                Pb[i0, j0].Image = Pib.Image;
                Pib.Image = pictureBox1.Image;
                clik = 1;
            }
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            //Рисуем картинку
            Pict = new Bitmap("E:\\C#\\Игра\\Код игры замок\\ЗАМОК.jpg");
            g.DrawImage(Pict, 20, 20, Pict.Width, Pict.Height);
            //Размеры фрагмента рисунка
            w = Pict.Width / 4;
            h = Pict.Height / 4;

            //Невидимый pictureBox1 для перестановки фрагментов
            pictureBox1.Width = w;
            pictureBox1.Height = h;
            pictureBox1.Visible = false;
            x0 = 20;
            y0 = Pict.Height + 40;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Обработчик кнопки Start
            int i, j, k, m;
            bool zap;
            int[,] a = new int[4, 4];//Массив используется для перемешивания
            Image bb;

            Random rnd = new Random();
            // Если Pb[i,j] есть на форме, мы его удаляем
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                    if (this.Controls.Contains(Pb[i, j]))
                        this.Controls.Remove(Pb[i, j]);
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                    a[i, j] = 0;//Заполняем нулями
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                {//Создаем массив
                    Pb[i, j] = new PictureBox();
                    Pb[i, j].Left = x0 + j * w;
                    Pb[i, j].Top = y0 + i * h;
                    Pb[i, j].Width = w;
                    Pb[i, j].Height = h;
                    //Граница должна быть видна
                    Pb[i, j].BorderStyle = BorderStyle.Fixed3D;
                    Pb[i, j].Click += Pb_Click;
                    Controls.Add(Pb[i, j]);
                    zap = true;
                    while (zap)
                    {
                        k = rnd.Next(0, 4);
                        m = rnd.Next(0, 4);
                        if (a[k, m] == 0)//Если в элементе массива Pb нет рисунка
                        {
                            a[k, m] = 1;
                            zap = false;

                            //Здесь мы копируем из рисунка фрагмент
                            //Копирование идет не с рисунка на форме, а из рисунка в памяти.
                            //Поэтому координаты левого верхнего угла - 0,0.
                            bb = Pict.Clone(new Rectangle(m * w, k * h, w, h), Pict.PixelFormat);
                            Pb[i, j].Image = bb;//Вставляем фрагмент и Pb[i,j]
                        }

                    }
                }
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }



       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
