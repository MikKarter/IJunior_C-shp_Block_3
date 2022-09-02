using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input amount array:");
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

            Console.WriteLine("input amount step for change position:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            for (int changePosition = 0; changePosition < userInput; changePosition++)
            {
                for (int i = 0; i < 1; i++)
                {
                    int firtsNumber = numberArray[0];

                    for (int j = 0; j < numberArray.Length - 1; j++)
                    {

                        int tempNumber = numberArray[j];
                        numberArray[j] = numberArray[j + 1];
                    }

                    numberArray[numberArray.Length - 1] = firtsNumber;
                }
            }

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.Write(numberArray[i] + " ");
            }
        }
    }
}
