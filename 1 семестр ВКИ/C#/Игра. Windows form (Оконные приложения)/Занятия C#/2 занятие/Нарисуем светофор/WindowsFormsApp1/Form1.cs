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

        Graphics g;  //Объявляем 
                     //переменную g типа Graphics

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            //Создаем поверхность на форме

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush myBrushgray = new SolidBrush(Color.Gray);
            g.FillRectangle(myBrushgray, 40, 25, 200, 400);
            SolidBrush myBrushred = new SolidBrush(Color.Red);
            g.FillEllipse(myBrushred, 80, 25, 130, 130);
            SolidBrush myBrushYellow = new SolidBrush(Color.Yellow);
            g.FillEllipse(myBrushYellow, 80, 155, 130, 130);
            SolidBrush myBrushGreen = new SolidBrush(Color.Green);
            g.FillEllipse(myBrushGreen, 80, 285, 130, 130);

        }
    }
}
