using System;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers: ");
            string input = Console.ReadLine();
            int maxNumber = int.MinValue;
            foreach (string character in input.Replace(" ", "").Trim().Split(","))
            {
                int numParsed;
                if (int.TryParse(character, out numParsed) && numParsed > maxNumber)
                {
                    maxNumber = numParsed;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
