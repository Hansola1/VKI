using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // графическая поверхность
        Graphics g;

        // баннер
        Bitmap baner;

        // область вывода баннера
        Rectangle rct;
       
        public Form1()
        {
            InitializeComponent();

            try
            {
                // загружаем фбаннера
                baner = new Bitmap("banner.png");
            }
            catch (Exception exception)
            {
                MessageBox.Show( "Ошибка загрузки файла банера\n" +
                                 exception.ToString(), "Банер");
                this.Close();// закрываем форму
                return;
            }

            // определяем графическую поверхность
            g = this.CreateGraphics();

            // определяем область отображения баннера
            rct.X = 0;
            rct.Y = 0;
            rct.Width = baner.Width;
            rct.Height = baner.Height;

            // настройка таймера
            timer1.Interval = 50;
            timer1.Enabled = true;
        }

        // сигнал от таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            // сместить область отображения
            // банера влево
            rct.X -= 1;

            // если область отображения целиком
            // "уехала" за левую границу формы,
            // вернем ее обратно
            if (Math.Abs(rct.X) > rct.Width)
                rct.X += rct.Width;

            // т.к. область отображения едет влево, то после
            // вывода в "съехавшую" область, выведем банер
            // еще раз (как минимум один, если ширина формы
            // равна ширине банера)
            for (int i = 0; i <= Convert.ToInt16(
                 this.ClientSize.Width / rct.Width) + 1; i++)
                g.DrawImage(baner, rct.X + i * rct.Width, rct.Y);
        }

        // перемещение указателя мыши
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // при наведении курсора мыши на баннер,
            // движение останавливается
            if ((e.Y < rct.Y + rct.Height) && (e.Y > rct.Y))
            {
                if (timer1.Enabled != false)
                    timer1.Enabled = false;
            }
            else
            {
                if (timer1.Enabled != true)
                    timer1.Enabled = true;
            }
        }
    }
}
