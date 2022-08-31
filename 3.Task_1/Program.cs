using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumberOne = new Random();
            Random randomNumberTwo = new Random();
            int[,] testArray = new int[randomNumberOne.Next(4,11), randomNumberTwo.Next(4,14)];

            int rowTestArray = 2;
            int columnTestArray = 1;
            int multiplicationNumbers = 1;
            int sumNumbers = 0;

            for (int i = 0; i < testArray.GetLength(0); i++)
            {
                for (int j = 0; j < testArray.GetLength(1); j++)
                {
                    testArray[i,j] = randomNumberOne.Next(50,77);
                    Console.Write(testArray[i, j] + " ");
                    sumNumbers += testArray[rowTestArray, j];
                }

                multiplicationNumbers *= testArray[i, columnTestArray];
                Console.WriteLine();
            }
            Console.WriteLine(multiplicationNumbers);
            Console.WriteLine(sumNumbers);
        }
    }
}
