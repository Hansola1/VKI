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
        // заголовок диаграммы
        string header;

        // количество элементов данных
        int N = 0;
      
        double[] dat; // ряд данных
        double[] p;   // доля категории в общей сумме


        // подписи данных
        private string[] title;
   

        public Form1()
        {
            InitializeComponent();

            try
            {
                System.IO.StreamReader sr;

                sr = new System.IO.StreamReader(
                    Application.StartupPath + "\\date.dat",
                    System.Text.Encoding.GetEncoding(1251));

                // считываем заголовок диаграммы
                header = sr.ReadLine();

                // считываем данные о количестве записей
                // и инициализируем массивы
                N = Convert.ToInt16(sr.ReadLine());
                dat = new double[N];
                p = new double[N];
                title = new string[N];


                // читаем данные
                int i = 0;
                string st;
                st = sr.ReadLine();
                while ((st != null) && (i < N))
                {
                    title[i] = st;

                    st = sr.ReadLine();
                    dat[i++] = Convert.ToDouble(st);

                    //i++;

                    st = sr.ReadLine();
                }

                // закрываем поток
                sr.Close();

                // задать процедуру обработки события Paint
                this.Paint += new PaintEventHandler(Diagram);
              
                double sum = 0;
                int j = 0;
                
                // вычислить сумму
                for (j = 0; j < N; j++)
                    sum += dat[j];

                // вычислить долю каждой категории
                for (j = 0; j < N; j++)
                    p[j] = (double)(dat[j] / sum);
            }

            // задаем цвет формы
            //this.BackColor = System.Drawing.Color.White;

            catch (  Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Диаграмма",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // процедура рисует круговую диаграмму;
        // имеет такие же параметры, что и
        // процедура обработки события Paint
        private void Diagram(object sender, PaintEventArgs e)
        {
            // графическая поверхность
            Graphics g = e.Graphics;

            // шрифт заголовка
            Font hFont = new Font("Tahoma", 12);
       
            // выводим заголовок
            int w = (int)g.MeasureString(header, hFont).Width;
            int x = (this.ClientSize.Width - w) / 2;

            g.DrawString(header,
                hFont, System.Drawing.Brushes.Black, x, 10);

            // шрифт легенды
            Font lFont = new Font("Tahoma", 9);

            // диаметр диаграммы
            int d = ClientSize.Height - 70;

            int x0 = 30;
            int y0 = (ClientSize.Height - d) / 2 + 10;

            // координаты верхнего левого угла
            // области легенды
            int lx = 60 + d;
            int ly = y0 + (d - N * 20 + 10) / 2;

            // длинна дуги сектора
            int swe;

            // кисть для заливки сектора диаграммы
            Brush fBrush = Brushes.White;

            // начальная точка дуги сектора
            int sta = -90;
            
            // рисуем диаграмму
            for (int i = 0; i < N; i++)
            {
                // длинна дуги
                swe = (int)(360 * p[i]);

                // задать цвет сектора
                switch (i)
                {
                    case 0:
                        fBrush = Brushes.YellowGreen;
                        break;
                    case 1:
                        fBrush = Brushes.Gold;
                        break;
                    case 2:
                        fBrush = Brushes.Pink;
                        break;
                    case 3:
                        fBrush = Brushes.Violet;
                        break;
                    case 4:
                        fBrush = Brushes.OrangeRed;
                        break;
                    case 5:
                        fBrush = Brushes.RoyalBlue;
                        break;
                    case 6:
                        fBrush = Brushes.SteelBlue;
                        break;
                    case 7:
                        fBrush = Brushes.Chocolate;
                        break;
                    case 8:
                        fBrush = Brushes.LightGray;
                        break;
                    case 9:
                        fBrush = Brushes.Gold;break;
                }

                // из-за округления возможна ситуация
                // при которой будет промежуток между
                // последним и первым секторами
                if (i == N - 1)
                {
                    // последний сектор
                    swe = 270 - sta;
                }

                // рисуем сектор
                g.FillPie(fBrush, x0, y0, d, d, sta, swe);

                // рисуем границу сектора
                g.DrawPie(System.Drawing.Pens.Black, x0, y0, d, d, sta, swe);
                
                // прямоугольник легенда
                g.FillRectangle(fBrush,
                          lx, ly + i * 20, 20, 10);
                g.DrawRectangle(System.Drawing.Pens.Black,
                          lx, ly + i * 20, 20, 10);

                // подпись
                g.DrawString( title[i] + " - " +
                                    p[i].ToString("P"),
                                    lFont, System.Drawing.Brushes.Black,
                                    lx + 24, ly + i * 20 - 3);

                // начальная точка дуги для следующего сектора
                sta = sta + swe; 
            }
        }
    }
}
