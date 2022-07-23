using System;
using static System.Console;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToGuess = new Random().Next(1, 11);
            for (int i = 0; i < 4; i++)
            {
                Write("Guess a number: ");
                int guess = Convert.ToInt32(ReadLine());
                if (guess == numberToGuess)
                {
                    WriteLine("You won!");
                    Environment.Exit(0);
                }
                else if (i < 3)
                {
                    WriteLine("Wrong! Try again!");
                }
            }
            WriteLine("You lost!");
        }
    }
}
