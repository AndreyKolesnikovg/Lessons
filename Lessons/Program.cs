using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0;i < 4; i++) 
            { 
                if (i == 2)
                {
                    continue;

                }
               

                Console.WriteLine(i);
            }

           Console.ReadLine();  

        }
    }
}
