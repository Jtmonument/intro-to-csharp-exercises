using System;
using System.IO;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../../kyrgyz_election.txt";
            var words = File.ReadAllText(path).Split(' ');
            Console.WriteLine(words.Length);
        }
    }
}
