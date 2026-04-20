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
        const int nw = 4;        // кол-во клеток по горизонтали
        const int nh = 4;        // кол-во клеток по вертикали
                       
        const int np = (nw * nh) / 2;  // кол-во пар картинок

        // рабочая графическая поверхность
        System.Drawing.Graphics g;

        // картинки (загружаются из файла) 
        Bitmap pics;

        // размер (ширина и высота) клетки (картинки)
        int cw, ch;

        // игровое поле: 
        int[,] field = new int[nw, nh];
        // field[i,j] == 1 ... k - клетка закрыта (k-номер картинки);
        // field[i,j] == 101 ... (100+k) - клетка открыта, картинка отображается                            
        // field[i,j] == 201 ... (200+k) - для картинки найдена пара 

        // кол-во открытых (найденных) пар картинок
        int nOpened = 0;

        // количества открытых в данный момент клеток
        int cOpened = 0;

        // координаты 1-й открытой клетки
        int[] open1 = new int[2];

        // координаты 2-й открытой клетки
        int[] open2 = new int[2];

        // таймер
        System.Windows.Forms.Timer timer1;

        // нарисовать клетку:
        // - картинку, если клетка открыта;
        // - границу, если клетка закрыта;
        // - фон, если в клетке картинка, для которой найдена пара
        private void cell(int i, int j)
        {
            int x,y;       // координаты левого верхнего угола клетки

            // между меду картинками
            // оставляем промежутки в 1 пиксель
            x = i * (cw + 2);
            y = j * (ch + 2) + menuStrip1.Height;

            if (field[i, j] > 200)
                // для этой клетки найдена пара,
                // картинку отображать не надо
                g.FillRectangle(SystemBrushes.Control,
                    x, y, cw + 2, ch + 2);

            if ((field[i, j] > 100) && (field[i, j] < 200))
            {
                // клетка открыта - отобразить картинку
                g.DrawImage(pics,
                    new Rectangle(x + 1, y + 1, cw, ch),
                    new Rectangle((field[i, j] - 101) * cw, 0, cw, ch),
                    GraphicsUnit.Pixel);
                g.DrawRectangle(Pens.Black,
                    x + 1, y + 1, cw, ch);
            }

            if ((field[i, j] > 0) && (field[i, j] < 100))
            {
                // клетка закрыта. рисуем контур
                g.FillRectangle(SystemBrushes.Control,
                    x + 1, y + 1, cw, ch);
                g.DrawRectangle(Pens.Black,
                    x + 1, y + 1, cw, ch);
            }
        }

        // нарисовать поле
        private void drawField()
        {
            for (int i = 0; i < nw; i++)
                for (int j = 0; j < nh; j++)
                    this.cell(i, j);
        }

        // новая игра
        private void newGame()
        {
            // Раскидаем пары картинок по игровому полю:
            // запишем в массив field случайные числа
            // от 1 до k, где к - количество картинок.
            // Каждое число должно быть записано
            // в массив два раза.
            
            Random rnd = new Random(); // генератор случайных чисел
            int rndN; // случайное число

            int[] buf = new int[np];
            // np - кол-во картинок;
            // в buf[i] записываем, сколько i чисел 
            // (индентификаторов картинок) записали в массив field

            for (int i = 0; i < nw; i++)
                for (int j = 0; j < nh; j++)
                {
                    do
                    {
                        rndN = rnd.Next(np) + 1;
                    } while (buf[rndN - 1] == 2);

                    field[i, j] = rndN;
                    buf[rndN - 1]++;
                }

            nOpened = 0;
            cOpened = 0;

            this.drawField();
        }

        public Form1()
        {
            InitializeComponent();

            try
            {
                // загружаем файл с картинками
                pics = new Bitmap("pictures.bmp");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Файл 'pictures.bmp' не найден.\n" +
                    exc.ToString(), "Парные картинки",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // определяем размер картинки и устанавливаем
            // размер клеток игрового поля
            cw = (int)(pics.Width / np);
            ch = pics.Height;

            // установить размер клиентской (рабочей) области формы
            // в соответствии с размером картинок и их количеством
            // (см. определения констант cw и ch)
            this.ClientSize =
                new System.Drawing.Size(nw * (cw + 2) + 1,
                                        nh * (ch + 2) + 1 + menuStrip1.Height);

            // рабочая графическая поверхность
            g = this.CreateGraphics();
            
            timer1 = new Timer();

            timer1.Tick += new System.EventHandler(this.timer1_Tick);

            //timer1.Enabled = false;
            timer1.Interval = 200;
           
            newGame();
        }

        // щелчок на игровом поле
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            {
                int i,j; // индексы элемента массива fild,
                         // соответствующего клетке, в кот.
                         // сделан щелчок

                i = e.X / (cw +3);  
                j = (e.Y - menuStrip1.Height) / (ch+3);

                // если таймер работает, это значит что в данный 
                // момент открыты две клеткаи, в которых находятся
                // одинаковые картинки, но они еще не "стерты".
                // Если щелчок сделан в одной из этих картинок,
                // то ни чего делать не надо.
                if ((timer1.Enabled) && (field[i, j] > 200))
                {
                    return;
                }


                // щелчок на месте одной из двух уже найденных
                // парных картинок
                if (field[i, j] > 200) return;

                // открытых клеток нет
                if (cOpened == 0)
                {
                    cOpened++;

                    // записываем координаты 1-й открытой клетки
                    open1[0] = i; open1[1] = j;

                    // клетка помечается как открытая
                    field[i, j] += 100;

                    // отрисовать клетку
                    this.cell(i, j);

                    return;
                }

                // открыта одна клетка, надо открыть вторую
                if (cOpened == 1)
                {
                    // записываем координаты 2-й открытой клетки
                    open2[0] = i; open2[1] = j;

                    // если открыта одна клетка, и щелчок сделан
                    // в той же клетке, ничего не происходит
                    if ((open1[0] == open2[0]) && (open1[1] == open2[1]))
                        return;
                    else
                    {
                        // теперь открыты две клетки
                        cOpened++;

                        // клетка помечается как открытая
                        field[i, j] += 100;

                        // отрисовать клетку
                        this.cell(i, j);

                        // открыты 2 одинаковые картинки
                        if (field[open1[0], open1[1]] ==
                            field[open2[0], open2[1]])
                        {
                            nOpened++;

                            // пометим клетки как найденные
                            field[open1[0], open1[1]] += 100;
                            field[open2[0], open2[1]] += 100;

                            cOpened = 0;

                            // Запускаем таймер. Процедура обработки
                            // сигнала от таймера "сотрет" клетки,
                            // клетки с одинаковыми картинками
                            timer1.Enabled = true;

                        }
                    }
                    return;
                }

                // уже открыты 2 клетки но с разными картинками,
                // закроем их и откроем ту, в которой сделан щелчок
                if (cOpened == 2)
                {
                    // закрываем открытые клетки
                    field[open1[0], open1[1]] -= 100;
                    field[open2[0], open2[1]] -= 100;

                    this.cell(open1[0], open1[1]);
                    this.cell(open2[0], open2[1]);

                    // записываем в open1 номер текущей клетки
                    open1[0] = i; open1[1] = j;

                    cOpened = 1;        // счетчик открытых клеток

                    // открыть клетку, в которой сделан щелчок
                    field[i, j] += 100;
                    this.cell(i, j);
                }
            }
        }

        // команда Новая игра
        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        // обработка события таймера
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            // отрисовать клетки
            this.cell(open1[0], open1[1]);
            this.cell(open2[0], open2[1]);

            // остановить таймер
            timer1.Enabled = false;

            if (nOpened == np)
            {
                MessageBox.Show("Вы справились с поставленной задачей!");               
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // отрисовать игровое поле
            drawField();
        }

        // команда О программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }
    }
}
