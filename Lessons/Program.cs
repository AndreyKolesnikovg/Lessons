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

            int[] myarray;

            myarray = new int[199];
            myarray[0] = 1;
            myarray[1] = 2;
            myarray[2] = 3;
            
            myarray[4] = 5;
            myarray[3] = myarray[4] + myarray[2];


      


            Console.WriteLine(myarray[3]);
            Console.WriteLine(myarray.Length);

            Console.ReadLine();




        }
    }
}
