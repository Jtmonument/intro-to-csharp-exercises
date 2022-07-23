using System;
using System.Collections.Generic;
using static System.Console;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("Error: You already entered that number! Try again!");
                }
                else
                {
                    numbers.Add(number);
                }
            }

            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
