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
                {3,3,4,4,3}

            };

            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(myArray[i,j] + "\t");
                }
                Console.WriteLine();
            }
           

     
        
            
          
           

            
          

            Console.ReadLine();




        }
    }
}
