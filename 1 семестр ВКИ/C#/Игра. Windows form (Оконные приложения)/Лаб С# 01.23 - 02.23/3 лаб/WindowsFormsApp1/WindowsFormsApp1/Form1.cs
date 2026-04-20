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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение исходных данных из TextBox
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);
            double fx = 0;



            // Ввод исходных данных в окно результатов
            textBox4.Text = "Результаты " + Environment.NewLine;
            textBox4.Text += "При X = " + textBox1.Text + Environment.NewLine;
            textBox4.Text += "При Y = " + textBox2.Text + Environment.NewLine;
            textBox4.Text += "При Z = " + textBox3.Text + Environment.NewLine;


            // Выбор функции
            if (radioButton1.Checked)
                fx = Math.Sin(x);
            else if (radioButton2.Checked)
                fx = Math.Pow(x, 2);
            else if (radioButton3.Checked)
                fx = Math.Exp(x);


            // Вычисление выражения
            double a;
            if ((x * y) > 0)
                //a = y * fx + z;
                a = (fx + Math.Pow(y, 2) + (Math.Sqrt(fx) * y) ;

            else if ((x * y) < 0)
                //a = y * Math.Exp(fx) - z;
                a = (fx + Math.Pow(y, 2) + Math.Sqrt(Math.Abs(fx) * y) ;

            else if ((x * y) == 0)
                //a = y * Math.Sin(fx) + z;
                a = (fx + Math.Pow(y, 2) + 1);


            // Вывод результата
            textBox4.Text += "A = " + a.ToString() + Environment.NewLine;
        }















        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Y_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
