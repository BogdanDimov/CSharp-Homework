using System;

namespace Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, difference;
            const double eps = 0.000001;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            difference = Math.Abs(a - b);

            if (difference >= eps)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
