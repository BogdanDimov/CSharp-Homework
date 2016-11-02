using System;
using System.Numerics;

namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main()
        {
            short N = short.Parse(Console.ReadLine());
            short K = short.Parse(Console.ReadLine());

            BigInteger factorial_n = 1, factorial_k = 1;

            for (int i = 1; i <= N; i++) // use only 1 loop
            {
                factorial_n *= i;

                if (i <= K)
                {
                    factorial_k *= i;
                }
            }

            Console.WriteLine(factorial_n / factorial_k);
        }
    }
}
