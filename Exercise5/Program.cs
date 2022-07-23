using System;
using System.Collections.Generic;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            string vowels = "aeiou";
            int count = 0;
            foreach (char ch in word)
            {
                if (vowels.Contains(ch))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
