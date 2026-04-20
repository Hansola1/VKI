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
        private const int bw = 40, bh = 22; // размер кнопки
        private const int dx = 5, dy = 5; // расстояние между кнопками   

        // кнопки 
        private Button[] btn = new Button[15];
    
        // текст на кнопках
        char[] btnText = {'7','8','9','+',
                          '4','5','6','-',
                          '1','2','3','=',
                          '0',',','c'};
        
        // кнопку будем идентифицировать
        // по значению свойства Tag
        int[] btnTag = {7,8,9,-3,
                        4,5,6,-4,
                        1,2,3,-2,
                        0,-1,-5};

        private double ac = 0;  // аккумулятор
        private int op = 0 ;     // код операции

        private Boolean fd; // fd == true - ждем первую цифру числа,
        // например, после нажатия кнопки +
        // fd == false - ждем следующую 
        // цифру или нажатие кнопки операции;


        public Form1()
        {
            InitializeComponent();

            fd = true;

            // создать кнопки
            int x, y;    // координаты кнопки

            // установить размер клиентской области формы
            this.ClientSize =
                new Size(4*bw + 5*dx, 5*bh + 7*dy);

            // задать размер и положение индикатора
            label1.SetBounds(dx, dy, 4*bw + 3*dx, bh);
            label1.Text = "0";

            y = label1.Bottom + dy ;
            
            // создать кнопки
            int k =0; // номер кнопки
            for ( int i=0; i < 4; i++)
            {
                x = dx;
                for (int j = 0; j < 4; j++)
                {
                    if ( !((i == 3 ) && (j == 0)))
                    {
                        // создать и настроить кнопку
                        btn[k] = new Button();
                        btn[k].SetBounds(x, y, bw, bh);
                        btn[k].Tag = btnTag[k];
                        btn[k].Text = btnText[k].ToString();
                        

                        // задать функцию обработки
                        // события Click
                        this.btn[k].Click += new
                            System.EventHandler(this.Button_Click);

                        if (btnTag[k] < 0)
                        {
                            // кнопка операции
                            btn[k].BackColor = SystemColors.ControlLight;
                        }

                        // поместить кнопку на форму
                        this.Controls.Add(this.btn[k]);

                        x = x + bw + dx;
                        k++;
                    }
                    else // кнопка ноль
                    {
                        // создать и настроить кнопку
                        btn[k] = new Button();
                        btn[k].SetBounds(x, y, bw * 2 + dx, bh);
                        btn[k].Tag = btnTag[k];
                        btn[k].Text = btnText[k].ToString();

                        // задать функцию обработки
                        // события Click
                        this.btn[k].Click += new
                            System.EventHandler(this.Button_Click);

                        // поместить кнопку на форму
                        this.Controls.Add(this.btn[k]);

                        x = x + 2*bw + 2*dx;
                        k++; 
                        j++;
                    }
                }
                y = y + bh + dy;
            }
        }

        // щелчок на кнопке
        private void Button_Click(object sender, System.EventArgs e)
        {
            // нажатая кнопка
            Button btn = (Button)sender;

            // кнопки 1..9
            if ( Convert.ToInt32(btn.Tag) > 0)
            {
                if ( fd )
                {
                    // на индикаторе ноль, т.е.
                    // это первая цифра 
                    label1.Text = btn.Text;
                    fd = false;
                }
                else
                    label1.Text += btn.Text;
                return;
            }

            // ноль
            if (Convert.ToInt32(btn.Tag) == 0)
            {
                 if (fd) label1.Text = btn.Text;
                 if (label1.Text != "0")
                        label1.Text += btn.Text;
                 return;
            }

            // запятая
            if ( Convert.ToInt32(btn.Tag) == -1 )
            {
                if (fd)
                {
                    label1.Text = "0,";
                    fd = false;
                }
                else
                    if (label1.Text.IndexOf(",") == -1)
                        label1.Text += btn.Text;
                return;
            }

            // "с" - очистить
            if (Convert.ToInt32(btn.Tag) == -5 )
            {
                ac = 0; // очистить аккумулятор
                op = 0;
                label1.Text = "0";
            
                fd = true; // снова ждем первую цифру
                return;
            }

            // кнопки "+","-","="
            if (Convert.ToInt32(btn.Tag) < -1)
            {
                double n; // число на индикаторе

                n = Convert.ToDouble(label1.Text);

                // Нажатие клавиши операции означает что пользователь
                // ввел операнд. Если в аккумуляторе есть число, то
                // выполним операцию. Если это не так, запомним 
                // операцию, чтобы выполнить ее при следующем нажатии
                // клавиши операции.
                if (ac != 0) 
                {
                    switch (op)
                    {
                        case -3: ac += n;
                            break;
                        case -4: ac -= n;
                            break;
                        case -2: ac = n;
                            break;
                    }
                    label1.Text = ac.ToString("N");
                }
                else {
                    ac = n;
                }
                
                op = Convert.ToInt32(btn.Tag); // запомнить операцию
                fd = true; // ждем следующее число   
             }
        }
    }
}
