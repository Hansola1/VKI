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
        int r, x, y;
        int fw, fh;  // Ширина и высота формы
        Random rnd = new Random();     //создается объект класса Random
        Pen pen1 = new Pen(Color.Blue);
        Graphics gr;


        public void krug(int x, int y, int r)
        {
            SolidBrush br1 = new SolidBrush(Color.Black);
            pen1.Color = Color.Blue;
            gr.DrawEllipse(pen1, x, y, 2 * r, 2 * r);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {

                r = rnd.Next(20, 100);
                x = rnd.Next(fw - 2 * r); // Следим, 
                                          //чтобы кружок не выходил за форму
                y = rnd.Next(fh - 2 * r);
                krug(x, y, r);
            }
        }

        public Form1()
        {
            InitializeComponent();
            gr = this.CreateGraphics();
            this.BackColor = Color.Aquamarine;
            fw = this.Width;//Текущая ширина формы
            fh = this.Height;//Текущая высота формы 



        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
