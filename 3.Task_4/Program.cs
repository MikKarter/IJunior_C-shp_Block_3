using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SumNumber = "sum";
            const string FinishProgramm = "exit";

            int[] numberArray = new int[0];
            string userInput;
            bool isWorking = true;

            while (isWorking)
            {
                Console.WriteLine("Input number fo add it to sum");
                Console.WriteLine("Input sum to show sum all you numbers");
                Console.WriteLine("Input exit to finish the programm");

                userInput = Console.ReadLine();

                if (userInput != "sum" && userInput != "exit")
                {
                    int[] extendedNumberArray = new int[numberArray.Length + 1];

                    for (int i = 0; i < numberArray.Length; i++)
                    {
                        extendedNumberArray[i] = numberArray[i];
                    }

                    numberArray = extendedNumberArray;
                    numberArray[numberArray.Length - 1] = Convert.ToInt32(userInput);
                }
                else if (userInput == SumNumber)
                {
                    int summNumbers = 0;

                    for (int i = 0; i < numberArray.Length; i++)
                    {
                        summNumbers += numberArray[i];
                    }

                    Console.WriteLine("Sum you numbers is " + summNumbers);
                }
                else if (userInput == FinishProgramm)
                {
                    isWorking = false;
                }
            }
        }
    }
}
