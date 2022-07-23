using System;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            char[] name = Console.ReadLine().ToCharArray();
            Array.Reverse(name);
            foreach (char ch in name)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
