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
        int y, a, r, g, b;
        int x = 0;
        SolidBrush br1 = new SolidBrush(Color.Black);

        private void button1_Click(object sender, EventArgs e)
        {
            drawpole();
        }

        int n = 50, h = 50;  // 50 полосок
        Graphics gr;
        public void drawpole()
        {
            a = 5; // Шаг или ширина одного
                   // прямоугольника
            r = 0; // Оттенки красного цвета
            b = 0; // Оттенки синего цвета
            y = 100;



            for (int i = 1; i <= n; i++)
            {
                g = i * a; // Оттенки зеленого цвета
                x += a;
                br1.Color = Color.FromArgb(r, g, b);
                gr.FillRectangle(br1, x, y, a, h);
            }
        }

            public Form1()
        {
            InitializeComponent();
            gr = this.CreateGraphics();
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
