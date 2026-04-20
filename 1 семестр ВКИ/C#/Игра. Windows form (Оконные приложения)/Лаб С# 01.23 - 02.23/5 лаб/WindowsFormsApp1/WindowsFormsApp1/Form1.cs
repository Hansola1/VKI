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
            // Получаем номер выделенной строки
            int index = listBox1.SelectedIndex;
            // Считываем строку в переменную str
            string str = (string)listBox1.Items[0];
            // Узнаем количество символов в строке
            int len = str.Length;
            // Считаем, что количество пробелов равно 0
            int count = 0;
            // Устанавливаем счетчик символов в 0
            // Организуем цикл перебора всех символов в строке

            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] == '1') || (str[i] == '0'))
                    count++;
            }
            label1.Text = "Количество нулей и единиц = " + count.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}









/*           while (i < len)
           {
               // Если нашли пробел, то увеличиваем
               // счетчик пробелов на 1
               if (str[i] == ' ')
                   count++;
               i++;
           }
*/