using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = "14,4";

            int a;
           bool result = int.TryParse(str, out a);
            if (result )
            {
                Console.WriteLine("Операция успешна, значение = " + a);
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать!");
            }
          
          

           

        }
    }
}
