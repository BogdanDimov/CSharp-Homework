using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            double a, b, c;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            if ((a > 0.0 && b > 0.0 && c > 0.0) ||
                (a > 0.0 && b < 0.0 && c < 0.0) ||
                (a < 0.0 && b > 0.0 && c < 0.0))
            {
                Console.WriteLine("+");
            }
            else if ((a == 0.0) || (b == 0.0) || (c == 0.0))
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
