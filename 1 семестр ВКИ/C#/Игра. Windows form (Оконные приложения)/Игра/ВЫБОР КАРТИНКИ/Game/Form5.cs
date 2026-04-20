using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game // выбор между 3 картинками
{
    public partial class Form5 : Form
    {
        public Form1 frm1;  //Объявляем Form3 и даем ей имя frm3
        public Form2 frm2;  //Объявляем Form2 и даем ей имя frm2
        public Form3 frm3;  //Объявляем Form3 и даем ей имя frm3
        public Form4 frm4;  //Объявляем Form2 и даем ей имя frm2
        //public Form6 frm6;  //Объявляем Form3 и даем ей имя frm3
        //public Form7 frm7;  //Объявляем Form3 и даем ей имя frm3

        
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm1 = new Form1(); //Создаем указатель на форму2
            frm1.Show(); //Показываем форму2
            this.Hide();//Прячем форму1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frm2 = new Form2(); //Создаем указатель на форму2
            //frm2.Show(); //Показываем форму2
            //this.Hide();//Прячем форму1
            int level = 0;
            switch (level)
            {
                case 0:
                    // Открыть вторую форму для игры на 1 уровне
                    frm2 = new Form2();//('1');
                    frm2.Show();
                    this.Hide();
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int level = 1;
            switch (level)
            {
                case 1:   
                    frm2 = new Form2(); //('1');
                    frm2.Show();
                    this.Hide();
                    break;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int level = 2;
            switch (level)
            {
                case 2:                   
                    frm2 = new Form2(); //('1');
                    frm2.Show();
                    this.Hide();
                    break;
            }

        }
    }
}
