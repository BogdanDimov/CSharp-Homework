using System;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            double x, y;

            bool isValid = false;

            do
            {
                isValid = double.TryParse(Console.ReadLine(), out x) && x > -1000 && x < 1000;
            } while (!isValid);

            do
            {
                isValid = double.TryParse(Console.ReadLine(), out y) && y > -1000 && y < 1000;
            } while (!isValid);

            double distanceFromCenter = Math.Sqrt(x * x + y * y);

            Console.WriteLine(distanceFromCenter <= 2.0 ? "yes " + distanceFromCenter.ToString("F2") : "no " + distanceFromCenter.ToString("F2"));
        }
    }
}
