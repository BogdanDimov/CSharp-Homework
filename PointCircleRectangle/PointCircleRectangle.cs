using System;

namespace PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main()
        {
            double x, y;
            bool isDouble;

            do
            {
                isDouble = double.TryParse(Console.ReadLine(), out x);
            } while (!isDouble || x < -1000 || x > 1000);

            do
            {
                isDouble = double.TryParse(Console.ReadLine(), out y);
            } while (!isDouble || y < -1000 || y > 1000);

            bool outsideCircle = false;
            bool outsideRectangle = false;

            if (x < -1.0 || x > 5.0 || y > 1.0 || y < -1.0)
            {
                outsideRectangle = true;
            }

            if ((x - 1) * (x - 1) + (y - 1) * (y - 1) > 1.5 * 1.5)
            {
                outsideCircle = true;
            }

            Console.WriteLine((outsideCircle ? "outside circle " : "inside circle ") + (outsideRectangle ? "outside rectangle" : "inside rectangle"));
        }
    }
}
