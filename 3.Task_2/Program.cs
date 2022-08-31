using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumberForArray= new Random();

            Console.WriteLine("Please imput numbers of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please imput numbers of columsn");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] testArray = new int [rows, columns];
            int maxNumberOfArray = int.MinValue;
            
            for (int i = 0; i < testArray.GetLength(0); i++)
            {
                for (int j = 0; j < testArray.GetLength(1); j++)
                {
                    testArray[i,j] = randomNumberForArray.Next (1, 100);
                    Console.Write(testArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < testArray.GetLength(0); i++)
            {
                for (int j = 0; j < testArray.GetLength(1); j++)
                {
                    if (maxNumberOfArray < testArray[i,j])
                    {
                        maxNumberOfArray = testArray[i,j];
                    }
                }
            }

            for (int i = 0; i < testArray.GetLength(0); i++)
            {
                for (int j = 0; j < testArray.GetLength(1); j++)
                {
                    if (maxNumberOfArray == testArray[i,j])
                    {
                        testArray[i, j] = 0;
                    }
                    
                    Console.Write(testArray[i, j] + " ");
                }
                
                Console.WriteLine();
            }
        }
    }
}
