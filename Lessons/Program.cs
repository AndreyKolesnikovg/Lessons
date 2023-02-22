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
            bool isInfected = false;
            bool isLoh = false;
         
            if (!isInfected && !isLoh) 
            {
                Console.WriteLine("Персонаж болен и не Loh");
            }
            

        }
    }
}
