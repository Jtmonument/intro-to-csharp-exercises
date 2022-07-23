using System;
using static System.Console;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a number between 1 and 10: ");
            int number = Convert.ToInt32(ReadLine());
            WriteLine(number);
            if (number >= 1 && number <= 10)
            {
                WriteLine("\nValid");
            }
            else
            {
                WriteLine("\nInvalid");
            }
        }
    }
}
