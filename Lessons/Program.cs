using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] myarray = {5,6,7,9,8};

            int result = myarray.Where(i => i < 0).FirstOrDefault();


            Console.WriteLine(result);
        
            
          
           

            
          

            Console.ReadLine();




        }
    }
}
