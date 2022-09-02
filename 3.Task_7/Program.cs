using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = Console.ReadLine();
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
