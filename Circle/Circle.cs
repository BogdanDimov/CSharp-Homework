using System;

namespace Circle
{
    class Circle
    {
        static void Main()
        {
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine((Math.PI * r * 2).ToString("F2") + " " + (Math.PI * r * r).ToString("F2"));
        }
    }
}
