using System;
using static System.Console;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter the speed limit: ");
            int speedLimit = Convert.ToInt32(ReadLine());
            Write("Enter the speed of the car: ");
            int carSpeed = Convert.ToInt32(ReadLine());
            if (carSpeed > speedLimit)
            {
                int points = (carSpeed - speedLimit) / 5;
                WriteLine("{0} demerit points", points);
                if (points > 12)
                {
                    WriteLine("License Suspended.");
                }
            }
            else
            {
                WriteLine("Ok");
            }
        }
    }
}
