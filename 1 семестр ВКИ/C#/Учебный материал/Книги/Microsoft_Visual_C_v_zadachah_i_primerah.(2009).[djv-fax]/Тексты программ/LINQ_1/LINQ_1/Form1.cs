/*
 
Демонстрирует использование LINQ операторов Contains и Equals для
поиска в массиве
 
 
*/
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
        // массив
        string[] names = { "Никита Культин", "Платон Культин",
                           "Данила Культин", "Лариса Цой",};
        
        public Form1()
        {
            InitializeComponent();
        }

        // щелчок на кнопке найти
        private void button1_Click(object sender, EventArgs e)
        {
            // образец для поиска
            string aName;

            // результат поиска
            IEnumerable<string> filteredNames;

            aName = textBox1.Text;

            if (radioButton1.Checked)
            {
                // поиск подстроки
                filteredNames =
                    System.Linq.Enumerable.Where(names, n => n.Contains(aName));
            }
            else
            {
                // равенство
                filteredNames =
                    System.Linq.Enumerable.Where(names, n => n.Equals(aName));

            }
            
            label1.Text = "";

            foreach (string st in filteredNames)
                label1.Text = label1.Text + st + '\n';             

        }
    }
}
