using System;

namespace NumbersFrom1toN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            uint N;

            N = Convert.ToUInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
