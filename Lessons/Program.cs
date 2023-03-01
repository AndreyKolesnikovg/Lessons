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
            for (int i = 0;i < 100; i++) 
            { 

                string msg = Console.ReadLine();

                
                if (msg == "exit") {
                    break;
                }
                Console.WriteLine(i);
            }

           Console.ReadLine();  

        }
    }
}
