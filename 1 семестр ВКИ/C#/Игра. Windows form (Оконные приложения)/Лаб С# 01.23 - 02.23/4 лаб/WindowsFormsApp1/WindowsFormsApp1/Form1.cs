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


//В массиве из 20 целых чисел найти наибольший элемент и поменять его местами с первым элементом.
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int[]Mas = new int[20];
        
        private void button1_Click(object sender, EventArgs e)
        {
            int Max = Mas[0];
            int j = 0;
            listBox1.Items.Clear(); // Инициализируем класс случайных чисел Random rand = new Random();
            Random rand = new Random(); // Генерируем и выводим 15 элементов

            for (int i = 0; i < Mas.Length ;  i++)
            {
                Mas[i] = rand.Next(0, 20);
            listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
 

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            int Max = Mas[0];
            int j = 0;

            for (int i = 0; i < Mas.Length; i++)

            {
                if (Max < Mas[i])
                {
                    Max = Mas[i];
                    j = i;
                }

            }
            int res = Mas[0];
            Mas[0] = Max;
            Mas[j] = res;
            
            for (int i = 0; i < Mas.Length; i++)

            {
               

                listBox2.Items.Add("Mas[" + Convert.ToString(i) + "] = " + Mas[i].ToString());

            }
        }
    }
}
