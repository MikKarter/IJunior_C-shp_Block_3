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
            int[] userNumberArray = new int[1];
            int summUserNumbers = 0;
            string userInput;
            bool workingUser = true;

            while (workingUser)
            {
                Console.WriteLine("Input number fo add it to sum");
                Console.WriteLine("Input sum to show sum all you numbers");
                Console.WriteLine("Input exit to finish the programm");
                userInput = Console.ReadLine();
                int[] extendedUserNumberArray = new int[userNumberArray.Length + 1];

                if (userInput!= "sum" && userInput != "exit")
                {
                    userNumberArray[0] = Convert.ToInt32(userInput);

                    for (int i = 0; i < userNumberArray.Length; i++)
                    {
                        extendedUserNumberArray[i] = userNumberArray[i];
                    }
                    extendedUserNumberArray[extendedUserNumberArray.Length - 1] = userNumberArray[0];
                    userNumberArray = extendedUserNumberArray;
                    extendedUserNumberArray[extendedUserNumberArray.Length-extendedUserNumberArray.Length] = 0;
                }

                else if (Convert.ToString(userInput) == "sum")
                {
                    for (int i = 0; i < userNumberArray.Length; i++)
                    {
                        summUserNumbers += userNumberArray[i];
                        
                    }
                    Console.WriteLine("Sum you numbers is " + summUserNumbers);
                    summUserNumbers = 0;
                }

                else if (Convert.ToString(userInput) == "exit")
                {
                    workingUser = false;
                }
            }
        }
    }
}
