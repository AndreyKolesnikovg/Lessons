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

            /*      bool accessAllowed;

            string storedPassword = "qwerty";
            string enteredPassword = Console.ReadLine();
          accessAllowed = enteredPassword == storedPassword ? true : false;
            Console.WriteLine(accessAllowed);



            Console.ReadLine();
        

           */


            int inputData = int.Parse(Console.ReadLine());

            int outputData = (inputData < 0) ? 0 : inputData;
            Console.WriteLine(outputData);

            Console.ReadLine();




        }
    }
}
