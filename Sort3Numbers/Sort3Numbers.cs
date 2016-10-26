using System;

namespace Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main()
        {
            int a, b, c, first, second, third;

            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            c = Convert.ToInt16(Console.ReadLine());

            first = a;
            second = b;
            third = c;

            if (a > b && a > c)
            {
                if (c > b)
                {
                    second = c;
                    third = b;
                }
            }
            else if (b > a && b > c)
            {
                first = b;

                if (a > c)
                {
                    second = a;
                    third = c;
                }
                else
                {
                    second = c;
                    third = a;
                }
            }
            else // if (c > a && c > b)
            {
                first = c;

                if (a > b)
                {
                    second = a;
                    third = b;
                }
                else
                {
                    second = b;
                    third = a;
                }
            }

            Console.WriteLine("{0} {1} {2}", first, second, third);
        }
    }
}
