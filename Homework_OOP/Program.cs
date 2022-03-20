using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_OOP
{
    internal class Program
    {
        static string FlipLine(string str)
        {
            string NewStr = "";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                NewStr += str[i];
            }
            return NewStr;
        }

        static void Main(string[] args)
        {
            //Реализовать метод, который в качестве входного параметра принимает строку string, 
            //возвращает строку типа string, буквы в которой идут в обратном порядке. Протестировать метод.

            string mystr = "Hello, World!";
            Console.WriteLine(mystr);
            Console.WriteLine(FlipLine(mystr));
            Console.ReadKey();
        }
    }
}
