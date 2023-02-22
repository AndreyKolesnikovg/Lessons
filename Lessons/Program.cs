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
            int count = 0;
            do
            {
            count++;
                Console.WriteLine(count);

            } 
            while (count<0);
           


        }
    }
}
