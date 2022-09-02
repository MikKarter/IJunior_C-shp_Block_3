using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input amount of numbers for array:\n");

            int amountNumbers = Convert.ToInt32(Console.ReadLine());
            int[] numberArray = new int[amountNumbers];
            int lowRandomNumber = 0;
            int highRandomNumber = 20;

            Random randomNumber = new Random();

            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = randomNumber.Next(lowRandomNumber, highRandomNumber);
                Console.Write(numberArray[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < numberArray.Length; i++)
            {
                for (int j = 0; j < numberArray.Length-1; j++)
                {
                    if (numberArray[j] > numberArray[j + 1])
                    {
                        int tempNumber = numberArray[j];
                        numberArray[j] = numberArray[j + 1];
                        numberArray[j+1] = tempNumber;
                    }
                }
            }

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.Write(numberArray[i] + " ");
            }
        }
    }
}
