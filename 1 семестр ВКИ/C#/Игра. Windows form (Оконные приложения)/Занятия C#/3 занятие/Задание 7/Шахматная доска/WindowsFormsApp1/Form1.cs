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
        int dx, dy, x, y, nx, ny, dlw, dlh;
        int x0, y0;
        int fw, fh;  // Ширина и высота формы        
        Graphics gr;


        public Form1()
        {
            InitializeComponent();
            gr = this.CreateGraphics();
            this.BackColor = Color.Aquamarine;
            fw = this.Width;//Текущая ширина формы
            fh = this.Height;//Текущая высота формы   
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            x0 = 10;
            y0 = 10;
            nx = 8;
            ny = 8;

            dx = (fw - x0 - 20) / nx;
            dy = (fh - y0 - 40) / ny;

            dlh = dy * ny;
            dlw = dx * nx;

            SolidBrush myBrushBlack = new SolidBrush(Color.Black);
            SolidBrush myBrushWhite = new SolidBrush(Color.White);
            Pen pen1 = new Pen(Color.Black);



            int color = 0;//переменная для определения цвета клетки
            for (int i = 1; i <= nx; i++)
            {
                x = x0 + (i - 1) * dx;
                color++;
                for (int j = 1; j <= ny; j++)
                {
                    y = y0 + (j - 1) * dy;
                    color++;
                    int col = color % 2;//индикатор цвета

                    if (col == 0)
                    {
                        gr.FillRectangle(myBrushBlack, x, y, dx, dy);
                    }
                    else
                    {
                        gr.FillRectangle(myBrushWhite, x, y, dx, dy);
                    }
                }
            }
        }
    



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
