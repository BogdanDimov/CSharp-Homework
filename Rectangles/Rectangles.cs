using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double width, height, area, perimeter;
            bool condition1, condition2;

            do
            {
                condition1 = double.TryParse(Console.ReadLine(), out width);
            } while (!condition1);

            do
            {
                condition2 = double.TryParse(Console.ReadLine(), out height);
            } while (!condition2);


            area = width * height;
            perimeter = 2.0 * width + 2.0 * height;
            Console.WriteLine(area.ToString("0.00") + " " + perimeter.ToString("0.00"));
        }
    }
}
