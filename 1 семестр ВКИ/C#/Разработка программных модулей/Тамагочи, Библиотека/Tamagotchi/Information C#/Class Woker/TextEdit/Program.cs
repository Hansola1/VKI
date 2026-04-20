//метод Reverse(), который возвращает строку в перевернутом виде;
//метод UcFirst(), который возвращает строку, сделав ее первую букву заглавной;
//метод UcWords(), который возвращает строку, сделав заглавной первую букву каждого слова этой строки


using System;
using System.Collections.Generic;
using System.Text;

namespace TextEdit
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var myS = new MyString();
            Console.WriteLine(" " + myS.Reverse(text));
            Console.WriteLine(myS.UcFirst(text));
            Console.WriteLine(myS.UcWords(text));

        }
    }

    public class MyString
    {
        public string text { get; set; }

        public string Reverse(string text)
        {
            Char[] charsInText = text.ToCharArray();
            Array.Reverse(charsInText);

            return new string(charsInText);
        }

        public string UcFirst(string text)
        {
            return char.ToUpper(text[0]) + text.Substring(1);
        }

        public string UcWords(string text) 
        {

            StringBuilder sb = new StringBuilder();

            bool newWord = true;

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsWhiteSpace(text[i]))
                {
                    sb.Append(" "); // Add space between words
                    newWord = true;
                }
                else if (newWord)
                {
                    sb.Append(Char.ToUpper(text[i]));
                    newWord = false;
                }
                else
                {
                    sb.Append(text[i]);
                }
            }

            return sb.ToString();
        }

    }

}

