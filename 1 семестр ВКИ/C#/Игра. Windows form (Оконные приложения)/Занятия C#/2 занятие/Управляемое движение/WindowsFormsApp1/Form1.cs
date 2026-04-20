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

        private Image Bit;
        int x = 300, y = 100, w = 40, h = 40;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);
            g.DrawImage(Bit, x, y, w, h);


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            rct.X = x;
            rct.Y = y;
            rct.Width = w;
            rct.Height = h;
            Invalidate(rct);
            //Обработка кодов клавиш
            if (e.KeyCode == Keys.Down) y += 10;
            if (e.KeyCode == Keys.Up) y -= 10;
            if (e.KeyCode == Keys.Left) x -= 10;
            if (e.KeyCode == Keys.Right) x += 10;
            g.DrawImage(Bit, x, y, w, h);

        }
        Graphics g;
        Rectangle rct;


        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            Bit = new Bitmap("E:\\C#\\Занятия C#\\Управляемое движение объекта с помощью клавиш\\apple.png");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rct.X = x;
            rct.Y = y;
            rct.Width = w;
            rct.Height = h;
            Invalidate(rct); //Перерисовываем прямоугольник цветом фона 
                            // (т. е.  Стираем рисунок)
                            //Invalidate очищает прямоугольник. 
                            //Если скобки пустые – всю форму.
            x += w;   //Меняем координаты рисунка
            y += h;
            g.DrawImage(Bit, x, y, w, h);
            //Ставим рисунок в новые координаты
            //Отражение от стенок
            if ((x < 0) || (x > (ClientRectangle.Width - rct.Width))) w = -w;
            if ((y < 0) || (y > (ClientRectangle.Height - rct.Height))) h = -h;


        }
    }
}
