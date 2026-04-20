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
        class sale
        {
            public string Title;
            public int n;
            public double p;
        }        

        sale[] sales = { 
                           new sale { Title = "Toyota", n = 15400 },
                           new sale { Title = "Mazda", n = 12700 },
                           new sale { Title = "Ford", n = 24500 },
                           new sale { Title = "Renault", n = 48300 },
                           new sale { Title = "Hunday", n = 35200 }
                       };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // отобразить исходные данные
            string st = "";
            foreach (sale aSale in sales)
                st = st + aSale.Title + " - " + aSale.n.ToString() + "\n";

            // обработка данных
            long sum = 0;
        //    IEnumerable<int> count = sales.Select(a => a.n);
        //    sum = count.Sum();

            foreach (sale aSale in sales)
                sum = sum + aSale.n;

            st = st + "Всего: " + sum.ToString();

            // вычислить долю каждой категории в общей сумме
            foreach (sale aSale in sales)
                aSale.p = (double)aSale.n / sum;


            // сортировка:
            // OrderBy - по возрастанию
            // OrderByDescending - по убыванию
            st = st + "\n\n";
            IEnumerable<sale> sorted = sales.OrderByDescending(a => a.n); // по убыванию

            // вывод результата
            foreach (sale aSale in sorted)
                st = st + aSale.Title + " - " + aSale.n.ToString("### 000") + ",  " +
                       (aSale.p * 100).ToString("f") + "%\n";

            label1.Text = st;
        }
    }
    
}
