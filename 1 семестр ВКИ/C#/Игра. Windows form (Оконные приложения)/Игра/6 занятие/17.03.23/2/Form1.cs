using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        Button[] b1 = new Button[4]; //Массив кнопок
        int l;//Случайное число

        public Form1()
        {
            InitializeComponent();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        { label1.BackColor = Color.Green; }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        { label1.BackColor = Color.Blue; }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void whiteToolStripMenuItem1_Click(object sender, EventArgs e)
        { label1.ForeColor = Color.White; }

        private void yellowToolStripMenuItem1_Click(object sender, EventArgs e)
        { BackColor = Color.Yellow; }

        private void magentaToolStripMenuItem1_Click(object sender, EventArgs e)
        { label1.ForeColor = Color.Magenta; }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        { this.Close(); }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            Button MyButton = new Button(); // Создаем кнопку с именем
                                            //   MyButton
            MyButton.Location = new Point(25, 110);//Задаем ее положение
                                                   // на форме
            MyButton.Text = "Mb"; // Текст
            MyButton.BackColor = Color.Green; // Цвет фона
            MyButton.Size = new Size(70, 40); // Размер кнопки
            MyButton.Font = new Font("Arial", 10, FontStyle.Regular); //Шрифт
            MyButton.ForeColor = Color.Red; // Цвет текста
            MyButton.Click += b1_Click; //Создаем указатель на метод кнопки.          
            Controls.Add(MyButton);//Добавляем кнопку в коллекцию элем-овформы
        }
        public void b1_Click(object sender, EventArgs e)
        {
            //sender-объект, на котором произошло событие.
            //Преобразуем его в кнопку
            Button Tb = sender as Button;
            // Button Tb = (Button)sender; 
            // Можно преобразовать и так
            MessageBox.Show(Tb.Text);
        }
        public void MYButton()
        {  //Формируем массив кнопок
            for (int i = 0; i < 4; i++)
            {
                b1[i] = new Button();
                b1[i].Left = 80;
                b1[i].Text = "B" + (i + 1).ToString();
                b1[i].Top = 100 + i * 70;
                b1[i].Size = new Size(70, 40);
                b1[i].Tag = i;
                b1[i].Click += b2_Click;
                b1[i].BackColor = Color.White;
                b1[i].ForeColor = Color.Red;
                b1[i].Font = new Font("Arial", 10, FontStyle.Regular);
                b1[i].Hide();  //Прячем кнопки массива
                Controls.Add(b1[i]);
            }
        }
        public void b2_Click(object sender, EventArgs e)
        {
            Button Tb;
            Tb = (Button)sender; //Преобразование
            if ((int)Tb.Tag == l) //Преобразуем Tag в int
            {
                MessageBox.Show("Победа");
                for (int i = 0; i < 4; i++)
                    b1[i].Hide(); //Прячем все кнопки
            }
            else Tb.Hide(); //Прячем кнопку
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            MYButton(); //Вызываем MYButton
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            l = rnd.Next(0, 4);//Загадали число
            for (int i = 0; i < 4; i++)
                b1[i].Show();//Показали кнопки

        }
    }
}
