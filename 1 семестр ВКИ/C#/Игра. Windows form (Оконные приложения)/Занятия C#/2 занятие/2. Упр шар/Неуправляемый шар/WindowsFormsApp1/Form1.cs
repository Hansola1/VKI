using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics g; // Объявляем графическую поверхность 
        Rectangle rct;//Прямоугольник с размерами рисунка 
        private Image Ball;//Рисунок 
        int x = 400, y = 100, dx = 2, dy = 2;

        private void timer1_Tick(object sender, EventArgs e)
        {
            rct.X = x;//Создаем прямоугольник
            rct.Y = y;
            rct.Width = Ball.Width;
            rct.Height = Ball.Height;
            Invalidate(rct);//Перерисовываем прямоугольник. Стираем мяч
                            //Invalidate очищает прямоугольник. Если скобки пустые – всю форму.
            x += dx;//Меняем координаты мяча
            y += dy;
            g.DrawImage(Ball, x, y, Ball.Width, Ball.Height);//рисуем мяч в новом положении
                                                             //Отражение от стенок
            if ((x < 0) || (x > (ClientRectangle.Width - Ball.Width))) dx = -dx;
            if ((y < 0) || (y > (ClientRectangle.Height - Ball.Height))) dy = -dy;

        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;//Остановка таймера
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value;//Интервал таймера
            timer1.Enabled = true;//Пуск таймера

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (((int)numericUpDown1.Value > 1) && ((int)numericUpDown1.Value < 100))
            {
                timer1.Interval = (int)numericUpDown1.Value;//Интервал таймера
            }

        }

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();//Cоздаем поверхность 
            Ball = new Bitmap("E:\\C#\\Занятия C#\\2 занятие\\2. Упр шар\\ball.png");//Создаем рисунок мяча        
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);//Окрашиваем форму
            g.DrawImage(Ball, x, y, Ball.Width, Ball.Height);//Рисуем мяч в начальном 
        }
    }
}
