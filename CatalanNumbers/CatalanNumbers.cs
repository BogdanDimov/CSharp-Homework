using System;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            BigInteger facN, facNPlus1, fac2N;

            fac2N = facN = 1;

            byte N = byte.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                facN *= i;
            }

            for (int i = 1; i <= 2 * N; i++)
            {
                fac2N *= i;
            }

            facNPlus1 = facN * ++N;

            Console.WriteLine(fac2N / (facNPlus1 * facN));
        }
    }
}
