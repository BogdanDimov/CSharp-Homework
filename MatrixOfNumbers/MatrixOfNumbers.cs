using System;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int shit = 1;

            for (int i = 1, count = 1; i <= (N * 2) - 1; i++, count++)
            {
                Console.Write(i + " ");

                if (count == N && i < (N * 2) - 1)
                {
                    Console.WriteLine();
                    count = 0;
                    i = shit++;
                }
            }
        }
    }
}
