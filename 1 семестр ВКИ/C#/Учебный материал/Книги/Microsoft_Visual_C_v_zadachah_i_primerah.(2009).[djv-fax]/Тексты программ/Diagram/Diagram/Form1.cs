using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diagram
{
    public partial class Form1 : Form
    {
        // данные
        private double[] d;      

        // строит график 
        private void drawDiagram(object sender, PaintEventArgs e)
        {
            // графическая поверхность
            Graphics g = e.Graphics;

            // шрифт подписей данных
            Font dFont = new Font("Tahoma", 9);

            // ** заголовок **
            // шрифт заголовка
            Font hFont = new Font("Tahoma", 14,   FontStyle.Regular);
            string header = "Изменение курса доллара";

            // ширина области отображения текста
            int wh = (int)g.MeasureString(header, hFont).Width;

            int x = (this.ClientSize.Width - wh) / 2; 
            
            g.DrawString(header,
                hFont, System.Drawing.Brushes.DarkGreen,
                x, 5);


            /*
             *  область построения графика:
             *  - отступ сверху - 100;
             *  - отступ снизу - 20;
             *
             *  - отступ слева - 20;
             *  - отступ справа - 20.
             *
             *  ClientSize - размер внутренней области окна
             *
             *  график строим в отклонениях от минимального
             *  значения ряда данных, так, чтобы он занимал
             *  всю область построения
             */
            
            double max = d[0]; // максимальный эл-т массива
            double min = d[0]; // минимальный эл-т массива

            for (int i = 1; i < d.Length; i++)
            {
                if (d[i] > max) max = d[i];
                if (d[i] < min) min = d[i];
            }

            // рисуем диаграму
            int x1, y1; // координаты левого верхнего угла столбика
            int w, h;   // размер столбца
 
            // ширина столбиков диаграммы
            // 5 - расстояние между столбиками
            // d.Length - кол-во рядов данных (столбиков)
            w = (ClientSize.Width - 40 - 5 * (d.Length - 1)) / d.Length;

            x1 = 20;
            for (int i = 0; i < d.Length; i++)
            {
                y1 = this.ClientSize.Height - 20 -
                (int)((this.ClientSize.Height - 100) *
                (d[i] - min) / (max - min));

                // подпись численного значения первой точки
                g.DrawString(Convert.ToString(d[i]),
                    dFont, System.Drawing.Brushes.Black,
                    x1, y1 - 20);
                
                // рисуем столбик
                h = ClientSize.Height - y1 - 20 + 1;

                // зеленый прямоугольник
                g.FillRectangle(Brushes.ForestGreen, x1, y1, w, h);
                
                // контур прямоугольника
                g.DrawRectangle(System.Drawing.Pens.Black,
                                x1, y1, w, h);

                x1 = x1 + w +5;
            }
        }

        public Form1()
        {
            InitializeComponent();

            // чтение данных из файла в массив
            System.IO.StreamReader sr; // поток для чтения
            try
            {
                // создаем поток для чтения
                // Application.StartupPath возвращает путь
                // к каталогу, из которого была запущена программа
                sr = new System.IO.StreamReader(
                    Application.StartupPath + "\\usd.dat");

                // cоздаем массив 
                d = new double[10];

                // читаем данные из файла
                int i = 0;
                string t = sr.ReadLine();
                while ((t != null) && (i < d.Length))
                {
                    // записываем считанное число в массив
                    d[i++] = Convert.ToDouble(t);
                    t = sr.ReadLine();
                }

                // закрываем поток
                sr.Close();

                // задаем функцию обработки события Paint                    
                this.Paint += new PaintEventHandler(drawDiagram);
                
            }
            // обработка исключений:
            
            // - файл данных не найден
            catch (System.IO.FileNotFoundException ex)
            { 
                MessageBox.Show( ex.Message + "\n" +
                    "("+ ex.GetType().ToString() +")",
                    "График",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);   
            }
            
            // - другие исключения
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "",
                    MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }



        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

    }
}
