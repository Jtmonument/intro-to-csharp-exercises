using System;
using System.IO;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../../kyrgyz_election.txt";
            var words = File.ReadAllText(path).Replace("\n", " ").Split(' ');
            string longestWord = words[0];
            foreach (var word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine(longestWord);
        }
    }
}
