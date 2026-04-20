using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int i, j;
        int[,] table = new int[3, 4]; 
        string str = "";
        Random rnd = new Random();



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    table[i, j] = rnd.Next(10);
                    str += " " + Convert.ToString(table[i, j]);
                }
                str += "\n";
                label1.Text = str;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
