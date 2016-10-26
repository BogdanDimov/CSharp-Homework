using System;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            uint N;

            N = Convert.ToUInt32(Console.ReadLine());

            double result = 0.0;

            for (int i = 0; i < N; i++)
            {
                result += Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine(result);
        }
    }
}
