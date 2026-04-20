using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Начальное значение X
            textBox1.Text = "14,26";
            // Начальное значение Y
            textBox2.Text = "-1,22";
            // Начальное значение Z
            textBox3.Text = "0,035";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Считывание значения X
            double x = double.Parse(textBox1.Text);
            // Вывод значения X в окно
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            // Считывание значения Y
            double y = double.Parse(textBox2.Text);
            // Вывод значения Y в окно
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            // Считывание значения Z
            double z = double.Parse(textBox3.Text);
            // Вывод значения Z в окно
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();

             // Вычисляем арифметическое выражение
              double a  = 2 * Math.Cos(x - Math.PI /6) ; //x
              double b = (0.5 + Math.Sin(y) * Math.Sin(y)) ; 
              double c = (1 + z * z / (3 - z * z / 5)) ;
              double u = a / b * c;
                
         textBox4.Text += Environment.NewLine + "Результат U = " + u.ToString(); // Выводим результат в окно
        }



        private void Form1_Click(object sender, EventArgs e)
        {

        }

    }

   

     
}
