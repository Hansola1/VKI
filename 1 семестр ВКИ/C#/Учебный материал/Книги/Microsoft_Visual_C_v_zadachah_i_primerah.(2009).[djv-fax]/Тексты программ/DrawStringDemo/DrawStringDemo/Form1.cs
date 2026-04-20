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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // шрифт определяет значение свойства Font формы
            e.Graphics.DrawString("Microsoft Visual C#", this.Font, Brushes.DarkGreen, 10, 10);

            // вывод текста шрифтом, определенным программистом:
            Font aFont = new Font("Tahoma", 12, FontStyle.Regular);
            e.Graphics.DrawString("Microsoft Visual C#", aFont, Brushes.Black, 10, 30);

            // вывод текста в центре формы
            Font hFont = new Font("Tahoma", 14, FontStyle.Regular);
            string header = "Microsoft Visual C# 2008 Express Edition";

            // размер области отображения текста зависит
            // от характеристик шрифта, который используется
            // его отображения.

            // определить размер области отображения текста
            int w = (int)e.Graphics.MeasureString(header, hFont).Width;
            int h = (int)e.Graphics.MeasureString(header, hFont).Height;

            // вычислить координаты левого верхнего угла области
            // отображения текста, так чтобы текст был размещен
            // в центре формы по горизонтали и вертикали
            // ClientSize.Width - размер внутренней области формы
            int x = (this.ClientSize.Width - w) / 2;
            int y = (this.ClientSize.Height - h) / 2;

            // вывести текст в центре формы
            e.Graphics.DrawString(header, hFont,
                 System.Drawing.Brushes.DarkGreen, x, y);

            // выведем текст еще раз
            e.Graphics.DrawString(header, hFont,
                 System.Drawing.Brushes.DarkGreen, x, y + h);


        }

        // изменился размер окна
        private void Form1_Resize(object sender, EventArgs e)
        {
            // сообщить системе о необходимости
            // перерисовать окно. В результате будет
            // сгенерировано событие Paint.
            this.Refresh();
        }
    }
}
