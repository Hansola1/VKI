using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ряд_кружков
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();

        }
        int x, y,r=40, r1, g1, b1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Graphics g;
        Random rnd = new Random();
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            SolidBrush myBrushred = new SolidBrush(Color.Red);
            //col = Color.FromRgb(0, 0, 0);
            //myBrushred.Color = Color.Red;
            y = 50;
            x = 0;
            Color col;
            for (int i = 1; i <= 15; i++)
            {
                r1 = rnd.Next(15, 256);  // Отступили от нуля на 15, 
                                        // чтобы избежать темных оттенков
                g1 = rnd.Next(15, 256);
                b1 = rnd.Next(15, 256);
                myBrushred.Color = Color.FromArgb(r1, g1, b1);
                r = rnd.Next(15, 25);
                x = rnd.Next(15, 750);
                y = rnd.Next(15, 400);
                g.FillEllipse(myBrushred, x, y, 2 * r, 2 * r);
                //x += 2 * r;
            }



        }
    }
}