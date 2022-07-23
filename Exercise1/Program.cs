using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
