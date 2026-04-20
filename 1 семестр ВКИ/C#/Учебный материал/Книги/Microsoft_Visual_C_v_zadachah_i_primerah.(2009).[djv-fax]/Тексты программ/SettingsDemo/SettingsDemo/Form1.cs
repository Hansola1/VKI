/* 
 *  Программа демонстрирует, как сохранить параметры программы в файле
 *  конфигурации. Файл конфигурации создает среда разработки в результате
 *  формирования списка параметров на вкладке Setteings (команда Project>Properties)
 * 
 *  (c) Культин Н.Б, 2008
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* Пространство имен WindowsFormsApplication1.Properties определено
   в файле Settings.Desiner.cs, который создается автоматически в
   результате формирования списка параметров на вкладке
   Settings (команда Project>Properties).
   
  Список параметров программы SettingsDemo:  
   --------------------------
   Name | Type | Scope |Value
   --------------------------
   Left | int  | User  | 10
   Top  | int  | User  | 10
   --------------------------
   Параметры используются для сохранения информации о положении формы.
 *
 * User-scoped параметры сохраняются каталоге пользователя
 * (C:\Users\User\AppData\Local\Application, где: User - имя пользователя;
 * Application - имя приложения, которое сохраняет параметры) в файле User.config
 * Файл конфигурации создает приложение в момент сохранения параметров.
 * Для каждого пользователя создается свой файл конфигурации.
 * 
 * Application-scoped параметры сохраняются каталоге приложения,
 * в файле application.exe.config (где: application - имя выполняемого
 * файла приложения ).
 * Файл Application-scoped параметров один для всех пользователей. 
 * 
 */

using WindowsFormsApplication1.Properties;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // загрузить параметры из файла конфигурации
            this.Left = Settings.Default.Left;
            this.Top = Settings.Default.Top;
            this.label2.Text = Settings.Default.User;
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // сохранить текущие значения параметров в файле
            // конфигурации
            Settings.Default.Left = this.Left;
            Settings.Default.Top = this.Top;
            Settings.Default.Save();
        }
    }
}
