using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form7 : Form
    {
        public Form1 frm1;  
        public Form2 frm2;  
        public Form3 frm3;  
        public Form4 frm4;  
        public Form5 frm5;  
        public Form6 frm6;  
        public Form7 frm7;  

        Bitmap Pict2;
        Bitmap Pict;//Переменная для рисунка
        Graphics g;//Графическая поверхность для рисунка
        //PictureBox[,] Pb = new PictureBox[N_size, N_size];//Массив PictureBox
        const int N_size = 5; //на сколько кусков режем картинку
        PictureBox[,] Pb = new PictureBox[N_size, N_size];
        int[,] a = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 1 }, { 1, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 } };
        int[,] aa = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 1 }, { 1, 0, 0, 1, 1 }, { 0, 0, 0, 0, 0 } };
        int h, w, i0, j0, x0, y0; int och = 0;



        public Form7()
        {
            InitializeComponent();
            g = this.CreateGraphics();//Создаем поверхность
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Form7_Paint(object sender, PaintEventArgs e)
        {
            //Рисуем картинку
            Pict = new Bitmap("E:\\C#\\Игра\\Game_pictures\\3 origхх.png"); //6N_size0 на N_size00
            g.DrawImage(Pict, 20, 20, Pict.Width, Pict.Height);

            //Размеры фрагмента рисунка              
            Pict2 = new Bitmap("E:\\C#\\Игра\\Game_pictures\\otv 3-3u.JPG");
            g.DrawImage(Pict2, Pict2.Width + 40, 20, Pict2.Width, Pict2.Height);
            w = Pict2.Width / N_size;
            h = Pict2.Height / N_size;

            //Невидимый pictureBox1 для перестановки фрагментов
            pictureBox1.Width = w;
            pictureBox1.Height = h;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            x0 = Pict2.Width + 40; // гориз
            y0 = Pict2.Height - 405; // высот

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Обработчик кнопки Start
            int i, j;
            a = new int[N_size, N_size];//Массив используется для перемешивания
            //Image bb;
            // Убираем картинку
            pictureBox1.Visible = false;

            Random rnd = new Random();
            // Если Pb[i,j] есть на форме, мы его удаляем
            for (i = 0; i < N_size; i++)
                for (j = 0; j < N_size; j++)
                    if (this.Controls.Contains(Pb[i, j]))
                        this.Controls.Remove(Pb[i, j]);


            for (i = 0; i < N_size; i++)
                for (j = 0; j < N_size; j++)
                    a[i, j] = 0;
            //Заполняем нулями


            for (i = 0; i < N_size; i++)
                for (j = 0; j < N_size; j++)
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
                    int ugx = j * w;
                    int ugy = i * h;
                    Pb[i, j].Image = Pict2.Clone(new Rectangle(ugx, ugy, w, h), Pict2.PixelFormat);

                   // Каждый элемент Pb[i, j] получает свои координаты и размеры, а также изображение фрагмента картинки.

                }
        }

        public void Pb_Click(object sender, EventArgs e)  // Обработчик щелчка по Pb[i, j]. Условия победы, поражения
        {
            int x0 = Pict2.Width + 40;
            int y0 = 20;

            PictureBox Pib;
            Pib = (PictureBox)sender;
            j0 = (Pib.Left - x0) / w; //Номер столбца и строки элемента,
            i0 = (Pib.Top - y0) / h; //по которому кликнули - запомнили.
            pictureBox1.Image = Pib.Image; //Изображение сохранили

            if (och == 5) //нужно найти 5 отличий
            {
                MessageBox.Show("Вы победили!");
            }
            if (och == -3) //поражение
            {
                MessageBox.Show("Вы проиграли!");
            }

            if (aa[i0, j0] == 1)
            {
                // frm4 = new Form4();
                // frm4.frm6 = this;
                // frm4.pictureBox1.Image = Pib.Image;
                ///////frm4.pictureBox2.Image = Pict.Clone(new Rectangle(20+i0*w, 20+j0*h, w, h), Pict.PixelFormat);
                // frm4.pictureBox2.Image = Pict.Clone(new Rectangle(20 + i0 * w, 20 + j0 * h, w, h), Pict.PixelFormat);
                // frm4.Show();

                och++;
                label1.Text = och.ToString();
            }
            else if (aa[i0, j0] == 0)
            {
                och--;
                label1.Text = och.ToString();
            }
        }






        private void button2_Click(object sender, EventArgs e)
        {
            frm1 = new Form1(); //Создаем указатель на форму2
            frm1.Show(); //Показываем форму2
            this.Hide();//Прячем форму1
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
