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
        public Form1()
        {
            InitializeComponent();
        }

        // массив
        double[] numbers = { 20, 56, 15, 33, 18, 27 };
        
        private void button1_Click(object sender, EventArgs e)
        {
            double count, min, max, sum;

            count = numbers.Count();  // количество элементов массива
            max = numbers.Max();      // максимальный элемент
            min = numbers.Min();      // минимальный элемент
            sum = numbers.Sum();      // сумма элементов массива

            label2.Text = "number: ";
            for (int i = 0; i < count; i++)
            {
                label2.Text = label2.Text + numbers[i].ToString() + "  ";
            }
            
            label2.Text = label2.Text + 
                          "\ncount = " + count.ToString() +
                          "\nmin = " + min.ToString() +
                          "\nmax = " + max.ToString() +
                          "\nsum = " + sum.ToString();

            // список sorted содержит упорядоченные 
            // по возрастанию элементы массива numbers
            IEnumerable<double> sorted = numbers.OrderBy(n => n);

            label2.Text = label2.Text + "\nnumber sorted: ";
            foreach (double a in sorted)
                label2.Text = label2.Text + a.ToString() + "  ";
            
            
            // элемент percent(i) - доля i-го элемента sorted[i]
            // в общей сумме элементов sorted
            IEnumerable<double> percent = numbers.Select(n => n/sum*100);

            percent = percent.OrderBy(n => n);
            
            label3.Text = "percent: ";
            foreach (double a in percent)
                label3.Text = label3.Text + a.ToString("f") + "  ";        
            
            label3.Text = label3.Text + "\npercent sorted: ";
            foreach (double a in percent)
                label3.Text = label3.Text + a.ToString("f")+ "  ";

        }
    }
}
