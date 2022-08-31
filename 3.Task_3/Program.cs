using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumberForArray = new Random();
            Console.WriteLine("Please imput numbers of columsn");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[] testArray = new int[columns];

            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = randomNumberForArray.Next(0, 11);
                Console.Write(testArray[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < (testArray.Length); i++)
            {
                if (i == 0 & testArray[i] > testArray[testArray.Length - testArray.Length+1])
                {
                    Console.Write(testArray[i] + " ");

                }

                if (i == testArray.Length - 1 & testArray[testArray.Length - 2] < testArray[i])
                {
                    Console.Write(testArray[i] + " ");
                }

                if (i != (testArray.Length - 1) & i != (testArray.Length - testArray.Length))
                {
                    if (testArray[i] > testArray[i - 1] & testArray[i] > testArray[(i + 1)])
                    {
                        Console.Write(testArray[i] + " ");
                    }
                }
            }
        }
    }
}




