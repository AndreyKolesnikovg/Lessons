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

            int[,] myArray;
            myArray = new int[,] 
            {
                {2,45,12 ,1,1},
                {1,1,1,1,3}, 
                { 3,3,4,4,3}

            };
            

            Console.WriteLine(myArray[0,2])  ;
        
            
          
           

            
          

            Console.ReadLine();




        }
    }
}
