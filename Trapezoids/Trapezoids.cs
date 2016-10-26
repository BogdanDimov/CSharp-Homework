using System;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            double a, b, h;
            bool isDouble;            

            do
            {
                isDouble = double.TryParse(Console.ReadLine(), out a);
            } while (!isDouble || a < -500.0 || a > 500.0);

            do
            {
                isDouble = double.TryParse(Console.ReadLine(), out b);
            } while (!isDouble || b < -500.0 || b > 500.0);

            do
            {
                isDouble = double.TryParse(Console.ReadLine(), out h);
            } while (!isDouble || h < -500.0 || h > 500.0);

            double area = (a + b) * (h / 2);

            Console.WriteLine(area.ToString("F7"));
        }
    }
}
