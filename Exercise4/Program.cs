using System;
using System.Collections.Generic;
using static System.Console;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            var numbers = new List<int>();
            while (running)
            {
                Console.Write("Enter input: ");
                int number;
                string input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    if (!numbers.Contains(number))
                    {
                        numbers.Add(number);
                    }
                }
                else if (input.Equals("Quit"))
                {
                    running = false;
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
