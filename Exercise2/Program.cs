using System;
using static System.Console;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Write("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            WriteLine(firstNumber > secondNumber ? firstNumber : secondNumber);
        }
    }
}
