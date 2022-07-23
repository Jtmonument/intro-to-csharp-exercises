using System;
using static System.Console;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("{0}! = {1}", number, factorial);
        }
    }
}
