using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_OOP
{
    internal class Program
    {
        public static void SearchMail(ref string s)
        {
            string[] s1 = s.Split('&');
            s = "";
            for(int i = 0; i < s1.Length; i++)
            {
                string[] s2 = s1[i].Split(' ');

                for (int j = 0; j < s2.Length; j++)
                {
                    if (s2[j].Contains('@'))
                    {
                        s = $"{s}\n{ s2[j]}";
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //*Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail адрес.Разделителем между ФИО и адресом 
            //электронной почты является символ &: Кучма Андрей Витальевич & Kuchma@mail.ru Мизинцев Павел Николаевич 
            //&Pasha@mail.ru Сформировать новый файл, содержащий список адресов электронной почты. Предусмотреть метод, 
            //выделяющий из строки адрес почты. Методу в качестве параметра передается символьная строка s, e-mail 
            //возвращается в той же строке s: public void SearchMail(ref string s).

            string PathFile1 = @"C:\Users\REFRESH\Documents\NameAndAddresses.txt";
            string PathFile2 = @"C:\Users\REFRESH\Documents\Addresses.txt";

            string alltext = File.ReadAllText(PathFile1);
            SearchMail(ref alltext);
            File.WriteAllText(PathFile2, alltext);

            Console.ReadKey();
        }
    }
}
