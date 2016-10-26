using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            double weight;
            bool inputValid = false;

            do
            {
                inputValid = double.TryParse(Console.ReadLine(), out weight) && weight > 0 && weight < 1000;

            } while (!inputValid);

            Console.WriteLine(((17.0 / 100.0) * weight).ToString("0.000"));
        }
    }
}
