using System;
using System.Collections.Generic;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                string[] list = Console.ReadLine().Replace(" ", "").Trim().Split(",");
                var numbers = new List<int>();
                foreach (string input in list)
                {
                    int number;
                    if (int.TryParse(input, out number))
                    {
                        numbers.Add(number);
                    }
                }
                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List! Try again!");
                    continue;
                }
                numbers.Sort();
                foreach (int num in numbers.GetRange(0, 3))
                {
                    Console.WriteLine(num);
                }
                running = false;
            }
        }
    }
}
