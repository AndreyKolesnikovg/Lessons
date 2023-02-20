using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Security.AccessControl;

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Среднее арифм. 2 чисел

            string stra, strb;
            double a, b;
            Console.WriteLine("Введите первое число");
            stra = Console.ReadLine();
            a = Convert.ToDouble(stra);
            Console.WriteLine("Введите второе число");
            strb = Console.ReadLine();
            b = Convert.ToDouble(strb);


            double sar = (a + b) / 2;
            Console.WriteLine("Ср. арифм. = " + sar);


            // Сумма и произв 3 чисел 

            string ch1, ch2, ch3;
            double sum, proizv;

            Console.WriteLine("Введите первое число");
            ch1 = Console.ReadLine();
            double fint = double.Parse(ch1);

            Console.WriteLine("Введите второе число");
            ch2 = Console.ReadLine();
            double sint = double.Parse(ch2);

            Console.WriteLine("Введите третье число");
            ch3 = Console.ReadLine();
            double thint = double.Parse(ch3);


            sum = fint + sint + thint;
            Console.WriteLine("Сумма чисел = " + sum);
            proizv = fint * sint * thint;
            Console.WriteLine("Произведение чисел = " + proizv);

            // Обмен валюты 

            string RUB; Double USD;
            Console.WriteLine("Введите количество рублей, которые" +
                "вы бы хотели обменять на доллары");
            RUB = Console.ReadLine();
            double DRUB = double.Parse(RUB);
            USD = DRUB/74.04;
            Console.WriteLine("Вы получите " + USD + " долларов в результате операции");
            
        }
    }
}
