using System;

namespace Calculate_
{
    class Program
    {
        static void Main()
        {
            double sum = 1.0, x;
            ulong factorial = 1, N;

            N = Convert.ToUInt64(Console.ReadLine());
            x = Convert.ToDouble(Console.ReadLine());

            for (ulong i = 1; i <= N; i++)
            {
                factorial *= i;
                sum += factorial / Math.Pow(x, i);
            }

            Console.WriteLine("{0:f5}", sum);
        }
    }
}