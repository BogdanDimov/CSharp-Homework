using System;

namespace BiggestOf5
{
    class BiggestOf5
    {
        static void Main()
        {
            double a, b, c, d, e, max;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());

            max = a;

            if (b > a && b > c && b > d && b > e)
            {
                max = b;
            }
            else if (c > a && c > b && c > d && c > e)
            {
                max = c;
            }
            else if (d > a && d > b && d > c && d > e)
            {
                max = d;
            }
            else if (e > a && e > b && e > c && e > d)
            {
                max = e;
            }

            Console.WriteLine(max);
        }
    }
}
