using System;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers: ");
            string[] input = Console.ReadLine().Split('-');
            if (input.Length == 0)
            {
                Environment.Exit(0);
            }

            var numbers = new int[input.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = Convert.ToInt32(input[i]);
                if (Array.Exists(numbers, num => num == number))
                {
                    Console.WriteLine("Duplicate");
                    break;
                }
                numbers[i] = number;
            }
        }
    }
}
