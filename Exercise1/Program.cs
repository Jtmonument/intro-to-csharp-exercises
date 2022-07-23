using System;
using System.Collections.Generic;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            var names = new List<string>();
            while (running)
            {
                Console.Write("Enter a name: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    names.Add(input);
                }
                else
                {
                    running = false;
                }
            }

            if (names.Count > 2)
            {
                if (names.Count > 3)
                {
                    Console.WriteLine("{0}, {1} and {2} others like your post.", names[0], names[1], names.Count - 2);
                }
                else
                {
                    Console.WriteLine("{0}, {1} and {2} other like your post.", names[0], names[1], names.Count - 2);
                }
            }
            else if (names.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
            }
            else if (names.Count == 1)
            {
                Console.WriteLine("{0} likes your post.", names[0]);
            }
        }
    }
}
