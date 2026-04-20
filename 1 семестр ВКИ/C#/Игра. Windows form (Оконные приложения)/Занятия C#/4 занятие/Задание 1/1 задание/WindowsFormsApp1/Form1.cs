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
       
        string str = "";
        const int n = 5;
        int i, j;
        int[,] table = new int[5, 5];
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zapoln2(n);

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 5; j++) // размер 
                {
                    table[i, j] = rnd.Next(25); // случайное до 25
                    str += " " + Convert.ToString(table[i, j]);
                }
                str += "\n";
            }
         label1.Text = str;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void zapoln2(int n)
        {
            int i, j, c, d;
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    table[i, j] = 0;

            for (i = 1; i <= n * n; i++)
            {// Ищем случайное свободное место
                do
                {
                    c = rnd.Next(0, 5);
                    d = rnd.Next(0, 5);
                }
                while (table[c, d] != 0);
                table[c, d] = i;
                //   25 чисел по порядку в случайные места
            }


        }
    }
}
