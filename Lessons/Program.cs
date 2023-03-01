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

            /*   int limit = int.Parse(Console.ReadLine());


               for (int i = 0; i < limit; i++)
               {
                   Console.WriteLine(i);
               }

           */
            /* 
            int i = 0;
            for (; i<3;i++ )
            {
                Console.WriteLine("for_1 " + i);
            } */


            /* for (int i = int.Parse(Console.ReadLine()); i>=0; i--)
            {
                
                Console.WriteLine(i + "i");
                
            }
            */

            for (int i = 0, j=5; i < 5; i++, j--)
            {
                Console.WriteLine(i + "i");
                Console.WriteLine(j + "j");
            }



            Console.ReadLine();

        }
    }
}
