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
        Graphics g; //Объявляем переменную g типа Graphics
        int nom = 1;
        bool down = true;



        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics(); //Создаем поверхность на форме
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush myBrushgray = new SolidBrush(Color.Gray);
            g.FillRectangle(myBrushgray, 80, 25, 70, 210);
            SolidBrush myBrush1 = new SolidBrush(Color.LightGray);
            //Создается заливка для кружочков (Один раз!)
            g.FillEllipse(myBrush1, 80, 95, 70, 70);
            g.FillEllipse(myBrush1, 80, 165, 70, 70);
            myBrush1.Color = Color.Red;   //Меняется свойство Color объекта myBrush1
            g.FillEllipse(myBrush1, 80, 25, 70, 70);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;//Запуск таймера
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;//Остановка таймера
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SolidBrush myBrush1 = new SolidBrush(Color.Red);

            switch (nom)
            {
                case 1:   // Если красный
                    {
                        myBrush1.Color = Color.Red;
                        g.FillEllipse(myBrush1, 80, 25, 70, 70);
                        myBrush1.Color = Color.LightGray;
                        g.FillEllipse(myBrush1, 80, 95, 70, 70);
                        down = true;
                        nom = 2;  // Будет желтый
                    }
                    break;
                case 2:   // Если желтый
                    {
                        myBrush1.Color = Color.Yellow;
                        g.FillEllipse(myBrush1, 80, 95, 70, 70);
                        if (down)   // Если вниз
                        {
                            myBrush1.Color = Color.LightGray;
                            g.FillEllipse(myBrush1, 80, 25, 70, 70);
                            nom = 3;
                        }
                        else  // Если вверх
                        {
                            myBrush1.Color = Color.LightGray;
                            g.FillEllipse(myBrush1, 80, 165, 70, 70);
                            nom = 1;
                        }
                    }
                    break;
                case 3:   // Если зеленый
                    {
                        myBrush1.Color = Color.Green;
                        g.FillEllipse(myBrush1, 80, 165, 70, 70);
                        myBrush1.Color = Color.LightGray;
                        g.FillEllipse(myBrush1, 80, 95, 70, 70);
                        down = false;
                        nom = 2;
                    }
                    break;

            }
        }
    }
}
