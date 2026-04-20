using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sek
{
    public partial class Form1 : Form
    {
        // минуты, секунды, миллисекунды
        int m, s, ms; 

        public Form1()
        {
            InitializeComponent();

            // настройка таймера:
            // сигнал от таймера - каждые 0.5 секунды
            timer1.Interval = 500;

            // обнуление показаний
            m = 0; s = 0; ms = 0;

            label1.Text = "00";
            label2.Text = "00";
            label3.Visible = true;
        }

        // щелчок на кнопке Пуск/Стоп
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                // таймер работает,
                // остановить таймер
                timer1.Enabled = false;

                // изменить текст на кнопке
                // и сделать ее доступной
                button1.Text = "Пуск";
                button2.Enabled = true;
            }
            else
            {
                // таймер не работает,
                // запускаем таймер
                timer1.Enabled = true;

                // изменить текст на кнопке
                // и сделать ее недоступной
                button1.Text = "Стоп";
                button2.Enabled = false;
            }
        }

        // щелчок на кнопке Сброс
        private void button2_Click(object sender, EventArgs e)
        {
            m = 0; s = 0; ms = 0;

            label1.Text = "00";
            label2.Text = "00";

            // label4.Text = ":";
        }

        // сигнал от таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            // двоеточие мигает с периодом 0.5 сек
            if (label3.Visible)
            {
                if (s < 59)
                {
                    s++;
                    if (s < 10)
                        label2.Text = "0" + s.ToString();
                    else
                        label2.Text = s.ToString();
                }
                else
                {
                    if (m < 59)
                    {
                        m++;
                        if (m < 10)
                            label1.Text = "0" + m.ToString();
                        else
                            label1.Text = m.ToString();
                        s = 0;
                        label2.Text = "00";
                    }
                    else
                    {
                        m = 0;
                        label1.Text = "00";
                    }    
                }
                label3.Visible = false;
            }
            else
                label3.Visible = true;
        }
    }
}
