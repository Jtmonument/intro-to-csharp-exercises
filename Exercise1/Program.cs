using System;
using System.IO;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../../kyrgyz_election.txt";
            var words = File.ReadAllText(path).Replace("\n", " ").Split(' ');
            Console.WriteLine(words.Length);
        }
    }
}
