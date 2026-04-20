using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form2 frm2;
        List <string> ask = new List <string> ();//Объявление списка вопросов
        int otvet;

        public Form1()
        {
            InitializeComponent();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;//Управление игрой видимо
            listBox1.Visible = true;
            button1.Visible = true;
            otvet = 0;//Правильный ответ    }        

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2 = new Form2();//Создаем указатель на форму 2
            frm2.frm1 = this;//Передаем форме 2 указатель на форму 1
            frm2.Show();//Показываем форму 2
            this.Hide();//Прячем форму 1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == otvet)
            {
                MessageBox.Show("Ok");
            }
            else
            {
                MessageBox.Show("Почитай Википедию");
                label1.Visible = false;//Управление невидимо
                listBox1.Visible = false;
                button1.Visible = false;
            }
        }
    }
}
