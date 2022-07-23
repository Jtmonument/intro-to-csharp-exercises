using System;
using System.Collections.Generic;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter words: ");
            string[] words = Console.ReadLine().ToLower().Split(' ');
            foreach (string word in words)
            {
                Console.Write(char.ToUpper(word[0]) + word.Substring(1));
            }
        }
    }
}
