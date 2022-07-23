using System;
using static System.Console;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter the width of your image: ");
            int width = Convert.ToInt32(ReadLine());
            Write("Enter the height of your image: ");
            int height = Convert.ToInt32(ReadLine());
            if (width > height)
            {
                WriteLine("The image is more like a landscape.");
            }
            else if (height > width)
            {
                WriteLine("The image is more like a portrait");
            }
            else 
            {
                WriteLine("The image is square.");
            }
        }
    }
}
