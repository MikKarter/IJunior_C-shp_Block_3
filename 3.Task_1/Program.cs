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
            Random randomNumber = new Random();
            int firstNumberForRandom = 4;
            int secondNumberForRandom = 14;
            int[,] testArray = new int[randomNumber.Next(firstNumberForRandom, secondNumberForRandom), randomNumber.Next(firstNumberForRandom, secondNumberForRandom)];

            int rowTestArray = 2;
            int columnTestArray = 1;
            int multiplicationNumbers = 1;
            int sumNumbers = 0;

            Console.WriteLine("Введите число для нижней границы рандома");
            firstNumberForRandom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число для верхней границы рандома");
            secondNumberForRandom = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testArray.GetLength(0); i++)
            {
                for (int j = 0; j < testArray.GetLength(1); j++)
                {
                    testArray[i, j] = randomNumber.Next(firstNumberForRandom, secondNumberForRandom);
                    Console.Write(testArray[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int j = 0; j < testArray.GetLength(1); j++)
            {
                sumNumbers += testArray[rowTestArray, j];
            }


            for (int i = 0; i < testArray.GetLength(0); i++)
            {
                multiplicationNumbers *= testArray[i, columnTestArray];
            }

            Console.WriteLine(multiplicationNumbers);
            Console.WriteLine(sumNumbers);
        }
    }
}
