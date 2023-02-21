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
            int a;
            a = int.Parse(Console.ReadLine());
            if (a==5) 
            {
                Console.WriteLine("a=5");
            }
            else if (a==2)
            {
                Console.WriteLine("a=2");
            }
            else
            {
                Console.WriteLine("a!=5");
            }
            

        }
    }
}
