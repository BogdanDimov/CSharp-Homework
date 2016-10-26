using System;

namespace Interval
{
    class Interval
    {
        static void Main()
        {

            int M, N;

            M = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());

            int diff = Math.Abs(M - N);
            int count = 0;

            for (int i = 1; i < diff; i++)
            {
                if (M < N)
                {
                    if ((M + i) % 5 == 0)
                        count++;
                }
                else
                {
                    if ((N + i) % 5 == 0)
                        count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
