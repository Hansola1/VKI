using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public int[,] a = new int[4, 4];
        int h = 40;//Размер кнопки
        int x0 = 30;//Угол игрового поля
        int y0 = 20;
        int i0, k0;
        Button[,] bt = new Button[4, 4];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zapolnenie();
            int i, j;
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                {
                    bt[i, j] = new Button();
                    bt[i, j].Left = x0 + j * h;
                    bt[i, j].Top = y0 + i * h;
                    bt[i, j].Width = h;
                    bt[i, j].Height = h;
                    bt[i, j].Font = new Font("Arial", 10, FontStyle.Bold);
                    bt[i, j].BackColor = Color.FloralWhite;
                    bt[i, j].ForeColor = Color.DarkOliveGreen;
                    if (a[i, j] != 0)
                        bt[i, j].Text = a[i, j].ToString();
                    else
                    {  //Пустое поле
                        i0 = i;
                        k0 = j;
                    }
                    bt[i, j].Click += bt_Click; //Создаем указатель на метод кнопки.
                    Controls.Add(bt[i, j]); //Добавляем кнопку в коллекцию 
                                            //элементов формы
                }
        }

        public void bt_Click(object sender, EventArgs e)
        {
            int i, k;
            Button Tb;
            Tb = (Button)sender;
            k = (Tb.Left - x0) / h;
            i = (Tb.Top - y0) / h;
            //Проверка наличия рядом пустого поля
            if (((Math.Abs(i - i0) == 1) && (k == k0)) || ((Math.Abs(k - k0) == 1) && (i == i0)))
            {
                swap(ref a[i, k], ref a[i0, k0]);
                bt[i, k].Text = "";
                bt[i0, k0].Text = a[i0, k0].ToString();
                //Новое пустое поле
                i0 = i;
                k0 = k;
            }
        }


        public void swap(ref int a, ref int b)
        {
            int r;
            r = b;
            b = a;
            a = r;
        }

        public void zapolnenie()
        {
            int i, j, k, m;
            bool zap;
            int n = 4;
            Random rnd = new Random();
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                    a[i, j] = 0;
            for (i = 0; i < 15; i++)
            {
                zap = true;
                while (zap)
                {
                    k = rnd.Next(0, 4);
                    m = rnd.Next(0, 4);
                    if (a[k, m] == 0)
                    {
                        a[k, m] = i + 1;
                        zap = false;
                    }
                }
            }
        }

    }
}
