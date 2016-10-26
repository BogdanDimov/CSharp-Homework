using System;

namespace QuadraticEquation
{
    class QuadtraticEquation
    {
        static void Main()
        {
            double a, b, c, d, x_1, x_2;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            d = (b * b) - (4.0 * a * c);

            if (d > 0)
            {

                x_1 = (-b + Math.Sqrt(d)) / (2 * a);
                x_2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.WriteLine(x_1 < x_2 ? x_1.ToString("F2") + "\n" + x_2.ToString("F2") : x_2.ToString("F2") + "\n" + x_1.ToString("F2"));
            }
            else if (d == 0)
            {
                x_1 = x_2 = -b / (2 * a);

                Console.WriteLine(x_1.ToString("F2"));
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
