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

        // щелчок на кнопке OK
        private void button1_Click(object sender, EventArgs e)
        {
            double sum;      // сумма
            double discount; // скидка
            double total;    // общая сумма

            sum = 309000;
            discount = 0;

            if (checkBox1.Checked)
            {
                // ABS
                sum += 8390;
            }
            
            if (checkBox2.Checked)
            {
                // противотуманные фары
                sum += 5990;
            }
            
            if (checkBox3.Checked)
            {
                // парктроник
                sum += 7590;
            }

            total = sum;

            string st;
            st = "Цена в выбранной комплектации: " + sum.ToString("C");
            
            if ((checkBox1.Checked) && (checkBox2.Checked) && (checkBox3.Checked))
            {
                // скидка предоставляется, если выбраны все опции
                discount = sum * 0.01;
                total = total - discount;
                st += "\nСкидка (1%): " + discount.ToString("C") +
                      "\nИтого: " + total.ToString("C");
            }

            label3.Text = st; 
        }

        // пользователь изменил состояние переключателя
        // функция обрабатывает событие CheckedChanged
        // компонентов checkBox1 - checkBox3
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}
