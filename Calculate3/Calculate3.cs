﻿using System;
using System.Numerics;

namespace Calculate3
{
    class Calculate3
    {
        static void Main()
        {

            byte N = byte.Parse(Console.ReadLine()), K = byte.Parse(Console.ReadLine());

            BigInteger result, fac_n, fac_k, fac_nk;
            fac_n = fac_k = fac_nk = 1;

            for (int i = 1; i <= N; i++)
            {
                fac_n *= i;
            }

            for (int i = 1; i <= K; i++)
            {
                fac_k *= i;
            }

            for (int i = 1; i <= N - K; i++)
            {
                fac_nk *= i;
            }

            result = fac_n / (fac_k * fac_nk);
            Console.WriteLine(result);
        }
    }
}
