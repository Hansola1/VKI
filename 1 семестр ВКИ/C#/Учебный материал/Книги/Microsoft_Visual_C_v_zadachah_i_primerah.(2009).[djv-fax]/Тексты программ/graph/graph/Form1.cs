using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace graph
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
            Font hFont = new Font("Tahoma", 14, FontStyle.Regular);
            string header = "Курс доллара";

            // ширина области отображения текста
            int w = (int)g.MeasureString(header, hFont).Width;

            int x = (this.ClientSize.Width - w) / 2; 
            
            g.DrawString(header,
                hFont, System.Drawing.Brushes.Black,
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

            // расстояние между точками графика (шаг по Х )
            int sw = (int)((this.ClientSize.Width - 40) / (d.Length - 1));

            double max = d[0]; // максимальный эл-т массива
            double min = d[0]; // минимальный эл-т массива

            for (int i = 1; i < d.Length; i++)
            {
                if (d[i] > max) max = d[i];
                if (d[i] < min) min = d[i];
            }

            // рисуем график
            int x1, y1, x2, y2;

            // первая точка
            x1 = 20;
            y1 = this.ClientSize.Height - 20 -
                (int)((this.ClientSize.Height - 100) *
                (d[0] - min) / (max - min));

            // маркер первой точки
            g.DrawRectangle(System.Drawing.Pens.Black,
                x1 - 2, y1 - 2, 4, 4);

            // подпись численного значения первой точки
            g.DrawString(Convert.ToString(d[0]),
                dFont, System.Drawing.Brushes.Black,
                x1 - 10, y1 - 20);


            // остальные точки
            for (int i = 1; i < d.Length; i++)
            {
                
                x2 = 8 + i * sw;
                y2 = this.ClientSize.Height - 20 -
                    (int)((this.ClientSize.Height - 100) *
                    (d[i] - min) / (max - min));

                // маркер точки
                g.DrawRectangle(System.Drawing.Pens.Black,
                      x2 - 2, y2 - 2, 4, 4);

                // соединим текущую точку с предыдущей
                g.DrawLine(System.Drawing.Pens.Black,
                    x1, y1, x2, y2);

                // подпись численного значения
                g.DrawString(Convert.ToString(d[i]), 
                    dFont, System.Drawing.Brushes.Black,
                    x2 - 10, y2 - 20);

                x1 = x2;
                y1 = y2;
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
