using System;

namespace BiggestOf3
{
    class BiggestOf3
    {
        static void Main()
        {
            double a, b, c, max;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            max = a;

            if (b > a && b > c)
            {
                max = b;
            }
            else if (c > a)
            {
                max = c;
            }

            Console.WriteLine(max);
        }
    }
}
