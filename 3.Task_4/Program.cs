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
            int[] numberArray = new int[1];

            string userInput = "";
            bool workingUser = true;

            while (workingUser)
            {
                Console.WriteLine("Input number fo add it to sum");
                Console.WriteLine("Input sum to show sum all you numbers");
                Console.WriteLine("Input exit to finish the programm");

                userInput = Console.ReadLine();

                if (userInput != "sum" && userInput != "exit")
                {
                    numberArray[0] = Convert.ToInt32(userInput);
                    int[] extendedNumberArray = new int[numberArray.Length + 1];

                    for (int i = 0; i < numberArray.Length; i++)
                    {
                        extendedNumberArray[i] = numberArray[i];
                    }

                    extendedNumberArray[extendedNumberArray.Length - 1] = numberArray[0];
                    numberArray = extendedNumberArray;
                    extendedNumberArray[extendedNumberArray.Length - extendedNumberArray.Length] = 0;
                }

                else if (Convert.ToString(userInput) == "sum")
                {
                    int summNumbers = 0;

                    for (int i = 0; i < numberArray.Length; i++)
                    {
                        summNumbers += numberArray[i];

                    }

                    Console.WriteLine("Sum you numbers is " + summNumbers);
                    summNumbers = 0;
                }

                else if (Convert.ToString(userInput) == "exit")
                {
                    workingUser = false;
                }
            }
        }
    }
}
