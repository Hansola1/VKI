/*
 Экзаменатор.  
 Универсальная программа тестирования. Вопросы считываются
 из файла и затем перемешиваются. Это позволяет использовать
 программу одновременно на нескольких соседних компьютерах
 и с определенной степенью достоверности быть уверенным, что
 в каждый момент времени на экранах мониторов соседних компьютеров
 отображаются разные вопросы.
 
 (с) Культин Н.Б., 2009
 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// эти ссылки вставлены вручную
using System.Xml.Linq;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        // массив радиокнопок и меток
        RadioButton[] radioButton;
        Label[] label;
        
        XDocument xdoc;
        DirectoryInfo di;

        // тест - XML-элементы (узлы) 
        IEnumerable<XElement> xel;

        
        string fpath; // путь к файлу теста
        string fname; // файл теста
        
        // тест - последовательность номеров вопросов
        int[] test;
        int cv = 0; // текущий вопрос

        int mode = 0;  // состояние программы:
                   // 0 - начало работы;
                   // 1 - тестирование;
                   // 2 - завершение работы
        
        int otv;   // номер ответа, выбранного испытуемым
        int right; // номер правильного ответа

        int nr;     // количество правильных ответов
        int n;      // общее количество вопросов

        // имя файла теста надо указать в поле Command Line Arguments
        // на вкладке Debug, для доступа к которой надо в меню Project
        // выбрать команду Properties
        public Form1(string[] args) //(см. также Program.cs )
        {
            InitializeComponent();

            radioButton = new RadioButton[4];
            label = new Label[4];

            for (int i = 0; i < 4; i++)
            {
                // создать компонент RadioButton
                radioButton[i] = new System.Windows.Forms.RadioButton();

                radioButton[i].Location = new System.Drawing.Point(25, 20+i*16);
                radioButton[i].Name = "radioButton"+i.ToString();
                radioButton[i].Size = new System.Drawing.Size(14, 13);
                radioButton[i].Visible = false;
                
                // процедура обработки события Click
                radioButton[i].Click += new System.EventHandler(this.radioButton1_Click);
                radioButton[i].Parent = this;

                // создать компонент Label
                label[i] = new System.Windows.Forms.Label();

                label[i].AutoSize = true;
                label[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                label[i].Location = new System.Drawing.Point(45, 20 + i*16);
                label[i].MaximumSize = new System.Drawing.Size(400, 0);
                label[i].Name = "label" + i.ToString();
                label[i].Size = new System.Drawing.Size(45, 16);
                radioButton[i].Visible = false;
                label[i].Parent = this;
            }

            radioButton5.Checked = true;
         
            // имя файла теста должно быть указано
            // в качестве парамета команды запуска программы
            if (args.Length > 0)
            {
                // если указано только имя файла теста,
                // то предполагается, что файл находится
                // в папке C:\Users\<User>\AppData\Roaming
                if (args[0].IndexOf(":") == -1)
                {
                    di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                    fpath = di.FullName + "\\"; 
                    fname = args[0];
                }

                else
                {
                    // указано полное имя файла теста
                    fpath = args[0].Substring(0, args[0].LastIndexOf("\\") + 1);
                    fname = args[0].Substring(args[0].LastIndexOf("\\") + 1);
                }
            }
            else
            {
                // не указано имя файла теста
                label0.ForeColor = Color.DarkRed;
                label0.Text = "Не указано имя файла теста!";
                mode = 2;
                return;
            }

            try
            {
                xdoc = XDocument.Load(fpath + fname); 
                
                xel = xdoc.Elements(); // прочитать XML-файл

                // информация о тесте
                label0.Text = xel.Elements("info").ElementAt(0).Value;

                n = xel.Elements("queries").Elements().Count();

                // генерируем тест
                test  = new int[n]; // создать массив
                
                // запишем в массив test числа от 0 до n-1
                // так, чтобы каждое число было в массиве
                // только один раз. Это и есть тест - перемешанные
                // вопросы

                Boolean[] b; // вспомогательный массив
                             // b[i] == true, если число i записано в массив test 
                
                b = new Boolean[n];
                for (int i = 0; i < n; i++)
                {
                    b[i] = false;
                }
                                
                Random rnd = new Random(); 
                int r; // случайное число
                for (int i = 0; i < n; i++)
                {
                    do 
                         r = rnd.Next(n);
                    while ( b[r] == true );

                    test[i] = r;
                    b[r] = true;
                }
                                              
                mode = 0;
                cv = 0;
            }
            catch (Exception aException)
            {
                // ошибка доступа к файлу теста
                label0.ForeColor = Color.DarkRed;
                label0.Text = aException.Message;
                mode = 2;
                return;
            }
        }

        // щелчок на кнопке OK
        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:        
                    // отобразить первый вопрос
                    qw(test[cv]); 
                    cv++;
                    mode = 1;
                    break;

                case 1:
                    // переход к следующему вопросу
                    if (otv == right)
                        nr++; // выбран правильный вариант ответа

                    if (cv < n)
                    {
                        // отобразить следующий вопрос
                        qw(test[cv]); 
                        cv++;
                    }
                    else
                    {
                        // больше вопросов нет
                       for (int j = 0; j < 4; j++)
                        {
                            label[j].Visible = false;
                            radioButton[j].Visible = false;
                        }

                        pictureBox1.Visible = false;

                        // обработка и вывод результата
                        ShowResult();
                        
                        // следующий щелчок на кнопке Ok
                        // закроет окно программы
                        mode = 2;
                    }
                    break;
                
                case 2:   // завершение работы программы
                    this.Close(); // закрыть окно
                    break;
            }
        }

        // отображает вопрос
        private void qw(int i)
        {           
            int j;
            for ( j= 0; j < 4; j++)
            {
                label[j].Visible = false;
                radioButton[j].Visible = false;
            }

            radioButton5.Checked = true;

            // вопрос
            label0.Text = xel.Elements("queries").Elements().ElementAt(i).Element("q").Value;

            // правильный ответ
            right = System.Convert.ToInt32(xel.Elements("queries").Elements().ElementAt(i).Element("q").Attribute("right").Value);
          
            // файл иллюстрации
            string src = xel.Elements("queries").Elements().ElementAt(i).Element("q").Attribute("src").Value;

            if (src.Length != 0)
            {
                // отобразить иллюстрацию
                try
                {
                    pictureBox1.Image = new Bitmap(fpath + src);
                    pictureBox1.Visible = true;
                   
                    radioButton[0].Top = pictureBox1.Bottom + 16;
                    label[0].Top = radioButton[0].Top - 3;
                }
                catch
                {
                    if (pictureBox1.Visible)
                        pictureBox1.Visible = false;

                    radioButton[0].Top = label0.Bottom + 10;
                    label[0].Top = radioButton[0].Top - 3;
                }
            }
            else
            {
                pictureBox1.Visible = false;
                radioButton[0].Top = label0.Bottom + 10;
                label[0].Top = radioButton[0].Top - 3;
            }

            j = 0;
            foreach (XElement a in xel.Elements("queries").Elements().ElementAt(i).Element("as").Elements())  
           {
               label[j].Text = a.Value;
               label[j].Visible = true;
               radioButton[j].Visible = true;
               if (j != 0)
               {
                   radioButton[j].Top = label[j - 1].Bottom + 10;
                   label[j].Top = radioButton[j].Top - 3;
               }
                j++;
           }
            button1.Enabled = false; 
        }

        // щелчок на кнопке выбора ответа
        // функция обрабатывает событие Click
        // компонентов radioButton
        private void radioButton1_Click(object sender, EventArgs e)
        {
            if ((RadioButton)sender == radioButton[0]) otv = 1;
            if ((RadioButton)sender == radioButton[1]) otv = 2;
            if ((RadioButton)sender == radioButton[2]) otv = 3;
            if ((RadioButton)sender == radioButton[3]) otv = 4;

            button1.Enabled = true;
        }

        // отобразить результат
        private void ShowResult()
        {            
            int k; // количество уровней оценки
            
            int i;     // номер уровня
            int p = 0; // кол-во правильных ответов, необходимых для
                       // достижения i-го уровня 

            k = xel.Elements("levels").Elements().Count();
            
            for (i = 0; i < k-1; i++)
            {
                p = System.Convert.ToInt32(xel.Elements("levels").Elements().ElementAt(i).Attribute("p").Value);
                if (nr >= p) // кол-во правильных ответов больше или равно
                             // необходимому для лостижения уровня
                    break; 
            }
          
            // отобразить оценку
            label0.Text =
                "Всего вопросов: " + n.ToString() + "\n" +
                "Правильных ответов: " + nr.ToString() + "\n" +
                "Оценка: " + xel.Elements("levels").Elements().ElementAt(i).Value;
        }
    }
}
