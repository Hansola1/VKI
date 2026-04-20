using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // массив
        string[] names = { "Никита Культин", "Платон Культин",
                           "Данила Культин", "Лариса Цой" };
        
        private void button1_Click(object sender, EventArgs e)
        {
            // образец для поиска
            string aName;

            // результат поиска
            IEnumerable<string> filteredNames;

            aName = textBox1.Text;

            // преобразование элементов массива к верхнему регистру
            filteredNames =         
                    System.Linq.Enumerable.Select( names, n => n.ToUpper());

            filteredNames =
                    System.Linq.Enumerable.Where(filteredNames, n => n.Contains(textBox1.Text.ToUpper())); 
            
            label1.Text = "";

            foreach (string st in filteredNames)
                label1.Text = label1.Text + st + '\n';             

        }
    }
}
