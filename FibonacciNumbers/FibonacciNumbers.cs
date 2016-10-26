using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            uint N;

            N = Convert.ToUInt32(Console.ReadLine());

            long first = 0;
            long second = 1;
            long next;

            Console.Write(first + ", " + second);

            for (uint i = 0; i < N - 2; i++)
            {
                next = first + second;

                first = second;
                second = next;

                Console.Write(", " + next);
            }

            Console.WriteLine();
        }
    }
}