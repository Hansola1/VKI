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
        System.Drawing.Bitmap aBitmap;
        public Form1()
        {
            InitializeComponent();

            try
            {
                aBitmap = new Bitmap("brush_1.bmp");
               
            }
            catch
            { }
        }

        // обработка события Paint: дублирование
        // aBitmap вдоль левой границы формы
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (aBitmap != null)
            {
                Point p = new Point(0, 0);
                while (p.Y < ClientSize.Height)
                {
                    e.Graphics.DrawImage(aBitmap, p);
                    p.Y += aBitmap.Height;
                }
                
            }
        }
    }
}
