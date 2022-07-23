using System;
using static System.Console;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool running = true;
            while (running)
            {
                int number;
                Write("Enter input: ");
                string input = ReadLine();
                if (int.TryParse(input, out number))
                {
                    sum += number;
                }
                else if (input.Equals("ok"))
                {
                    WriteLine("Sum: {0}", sum);
                    running = false;
                }
            }
        }
    }
}
