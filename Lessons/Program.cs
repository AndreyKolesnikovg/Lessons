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
            int a=1;
            a = ++a * a;
            Console.WriteLine(a);
            
        }
    }
}
