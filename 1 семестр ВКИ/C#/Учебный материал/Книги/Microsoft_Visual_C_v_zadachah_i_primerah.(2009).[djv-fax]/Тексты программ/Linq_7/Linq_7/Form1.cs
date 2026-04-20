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
        XDocument doc;
        DirectoryInfo di;

        // тест
        IEnumerable<XElement> books;

        
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

        
        // конструктор формы (см. также Program.cs )
        // имя файла теста надо указать в поле Command Line Arguments
        // на вкладке Debug, для доступа к которой надо в меню Project
        // выбрать команду Properties
        public Form1(string[] args)
        {
            InitializeComponent();

            //radioButton1.Top = label1.Bottom + 8;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            
            // XML-файл находится в папке C:\Users\<User>\AppData\Roaming 
            // di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));


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
                    fpath = di.FullName + "\\"; //  Application.StartupPath + "\\";
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
                doc = XDocument.Load(fpath + fname); 
                
                books = doc.Elements(); // прочитать XML-файл

                // информация о тесте
                label0.Text = books.Elements("info").ElementAt(0).Value;
                
                n = books.Elements("queries").Elements().Count();

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
                                
                Random rnd = new Random(); // генератор случайных чисел
                int r; // случайное число
                for (int i = 0; i < n; i++)
                {
                    do 
                         r = rnd.Next(n);
                    while ( b[r] == true );

                    test[i] = r;
                    b[r] = true;
                }

                // здесь последовательность сгенерирована
                
                // отладочная печать
                //string st = "";
                //for (int i = 0; i < n; i++)
                //{
                //    st = st + test[i].ToString() + ", ";
                //}
                //label1.Text = "Тест: "+ st;
                                
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
                        radioButton1.Visible = false;
                        radioButton2.Visible = false;
                        radioButton3.Visible = false;
                        radioButton4.Visible = false;

                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;

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
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            radioButton5.Checked = true;

            // вопрос
            label0.Text = books.Elements("queries").Elements().ElementAt(i).Element("q").Value;
          
            // файл иллюстрации
            string src = books.Elements("queries").Elements().ElementAt(i).Element("q").Attribute("src").Value;


            // правильный ответ
            right = System.Convert.ToInt32(books.Elements("queries").Elements().ElementAt(i).Element("q").Attribute("right").Value);


            if (src.Length != 0)
            {
                // отобразить иллюстрацию
                try
                {
                    pictureBox1.Image = new Bitmap(fpath + src);
                    pictureBox1.Visible = true;
                    radioButton1.Top = pictureBox1.Bottom + 16;
                    label1.Top = radioButton1.Top-3;
                }
                catch
                {
                    if (pictureBox1.Visible)
                        pictureBox1.Visible = false;

                    radioButton1.Top = label0.Bottom + 10;
                }
            }
            else
            {
                pictureBox1.Visible = false;
                radioButton1.Top = label0.Bottom + 16;
                label1.Top = radioButton1.Top-3;

            }

            int j = 0;
            foreach (XElement a in books.Elements("queries").Elements().ElementAt(i).Element("as").Elements())  
           {
                switch (j)
                {
                    case 0: label1.Text = a.Value;
                            label1.Visible = true;
                            //radioButton1.Text = a.Value;
                            radioButton1.Visible = true;
                            break;
                    case 1: label2.Text = a.Value;
                            label2.Visible = true;
                            //radioButton2.Text = a.Value;
                            radioButton2.Top = label1.Bottom + 10;
                            label2.Top = radioButton2.Top-3;
                            radioButton2.Visible = true; 
                            break;
                    case 2: label3.Text = a.Value;
                            label3.Visible = true;
                            radioButton3.Top = label2.Bottom + 10;
                            label3.Top = radioButton3.Top-3;
                            radioButton3.Visible = true;
                            break;
                    case 3: label4.Text = a.Value;
                            label4.Visible = true;
                            radioButton4.Top = label3.Bottom + 10;
                            label4.Top = radioButton4.Top-3;
                            radioButton4.Visible = true;
                            break;
                }
                j++;
           }
            button1.Enabled = false; 
        }

        // щелчок на кнопке выбора ответа
        // функция обрабатывает событие Click
        // компонентов radioButton1 - radioButton3
        private void radioButton1_Click(object sender, EventArgs e)
        {
            if ((RadioButton)sender == radioButton1) otv = 0;
            if ((RadioButton)sender == radioButton2) otv = 1;
            if ((RadioButton)sender == radioButton3) otv = 2;
            if ((RadioButton)sender == radioButton4) otv = 3;

            button1.Enabled = true;
        }

        // отобразить результат
        private void ShowResult()
        {            
            int k; // количество уровней оценки
            
            int i;     // номер уровня
            int p = 0; // кол-во правильных ответов, необходимых для
                       // достижения i-го уровня 

            k = books.Elements("levels").Elements().Count();
            
            for (i = 0; i < k-1; i++)
            {
                p = System.Convert.ToInt32(books.Elements("levels").Elements().ElementAt(i).Attribute("p").Value);
                if (nr >= p) // кол-во правильных ответов больше или равно
                             // необходимому для лостижения уровня
                    break; 
            }
          
            // отобразить оценку
            label0.Text =
                "Всего вопросов: " + n.ToString() + "\n" +
                "Правильных ответов: " + nr.ToString() + "\n" +
                "Оценка: " + books.Elements("levels").Elements().ElementAt(i).Value;
        }
    }
}
