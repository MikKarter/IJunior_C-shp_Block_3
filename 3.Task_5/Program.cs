using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much numbers will in be array?");
            int numbers = Convert.ToInt32(Console.ReadLine());
            int lowRandomNumber = 1;
            int highRandomNumber = 5;
            int countMaxNumbers = 1;
            int maxCountValue = 0;
            int findingNumber = 0;
            int[] numbersArray = new int[numbers];

            Random randomNumber = new Random();

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = randomNumber.Next(lowRandomNumber, highRandomNumber);
                Console.Write(numbersArray[i] + " ");
            }

            int tempNumber = numbersArray[0];

            for (int i = 1; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] == tempNumber)
                {
                    countMaxNumbers++;
                    findingNumber = numbersArray[i];
                }

                else if (maxCountValue < countMaxNumbers)
                {
                    maxCountValue = countMaxNumbers;
                    countMaxNumbers = 1;
                    findingNumber = tempNumber;
                }
                
                tempNumber = numbersArray[i];
            }

            if (countMaxNumbers > maxCountValue)
            {
                maxCountValue = countMaxNumbers;
            }

            Console.WriteLine();
            Console.WriteLine("Number " + findingNumber + " reply " + maxCountValue + " times");
        }
    }
}
