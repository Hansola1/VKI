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
        // битовые образы: небо и самолет
        System.Drawing.Bitmap sky, plane;

       
        Graphics g; // рабочая графическая поверхность

        // приращение координаты X,
        // определяет скорость полета
        int dx;

        // область, в которой находится самолет
        Rectangle rct;

        // true - самолет скрывается в облаках
        Boolean demo = true;

        // генератор случайных чисел
        System.Random rnd;

        public Form1()
        {
            InitializeComponent();

            try
            {
              /*  
                // Вариант 1: загрузка битовых образов из файлов
                sky = new Bitmap("sky.bmp");	 // небо
                plane = new Bitmap("plane.bmp"); // самолет
 
                // загрузить и задать фоновый рисунок формы
                this.BackgroundImage = new Bitmap("sky.bmp");
               */
 
                // Вариант 2: загрузка битовых образов из ресурса
                sky = Properties.Resources.sky;     // фон
                plane = Properties.Resources.plane; // самолет
                
                // загрузить и задать фоновый рисунок формы
                this.BackgroundImage = Properties.Resources.sky;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(),
                    "Полет",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close(); // закрыть приложение
                return;
            }

            // сделать прозрачным фон вокруг объекта
            plane.MakeTransparent();

            // задать размер формы в соответствии
            // с размером фонового рисунка
            this.ClientSize =
                new System.Drawing.Size(
                    new Point(BackgroundImage.Width,
                    BackgroundImage.Height));

            // задать вид границы окна
            this.FormBorderStyle =
                 System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // g - графическая поверхность, на которой
            // будем формировать рисунок.
            // в качестве поверхности
            // будем использовать BackgroundImage формы
            g = Graphics.FromImage(BackgroundImage);

            // инициализация генератора случ. чисел
            rnd = new System.Random();

            // исходное положение самолета
            rct.X = -40;
            rct.Y = 20 + rnd.Next(20);

            rct.Width = plane.Width;
            rct.Height = plane.Height;

            /*
            скорость полета определяется периодом следования
            сигналов от таймера (значение свойства Timer1.Interval)
            и величиной приращения координаты по X
            */

            dx = 2;		// скорость полета - 2 пикселя/тик_таймера

            timer2.Interval = 20;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // стираем изображение самолета путем копирования
			// области фона на рабочую поверхность
			g.DrawImage(sky,new Point(0,0));

			// изменяем положение самолета
			if (rct.X < this.ClientRectangle.Width)
				rct.X += dx;
			else {
				// если достигли границы, задаем заново
				// положение самолета
				rct.X = -40;
				rct.Y = 20 +
					rnd.Next(this.ClientSize.Height - 40 - plane.Height);

				// скорость полета от 2 до 5 пикселей/тик_таймера
				dx = 2 + rnd.Next(4);
			}

			// рисуем самолет на рабочей поверхности
            // (фактически на поверхности формы),
            // но для того, чтобы изменеия появились,
            // надо инициировать обновление формы
			g.DrawImage(plane, rct.X, rct.Y);
            

			/*
			Метод Refresh инициирует перирисовку всей формы
            Метод Invalidate позволяет иницировать перерисовку
            только той области формы, которая указана
            в качестве параметра метода.
			*/
			
            if ( ! demo )
				// обновить область формы,
				// в которой находится объект
				this.Invalidate(rct);
			else
            {
				// если объект находится вне области,
                // указанной в качестве параметра метода
                // Invalidate, то от не будет виден
				
                Rectangle reg =
                     new Rectangle(20,20,
                           sky.Width - 40, sky.Height - 40);

                // показать обновляемую область
				g.DrawRectangle(Pens.Black,
					reg.X ,reg.Y ,reg.Width-1, reg.Height-1);

				this.Invalidate(reg); // обновить область
			}
		}
    }
}

