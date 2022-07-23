using System;
using System.Collections.Generic;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers: ");
            string[] input = Console.ReadLine().Split("-");
            bool consecutive = true;
            int previous = 0;
            foreach (string number in input)
            {
                int num = Convert.ToInt32(number);
                if (Array.IndexOf(input, number) == 0)
                {
                    previous = num;
                    continue;
                }

                if (Math.Abs(num - previous) != 1)
                {
                    consecutive = false;
                    break;
                }
                previous = num;
            }

            if (consecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }
    }
}
