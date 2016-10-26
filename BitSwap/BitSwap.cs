using System;

namespace BitSwap
{
    class BitSwap
    {
        static void Main()
        {
            uint n;
            int p, q, k;
            bool isValid;

            do
            {
                isValid = uint.TryParse(Console.ReadLine(), out n);
            } while (!isValid);

            do
            {
                isValid = int.TryParse(Console.ReadLine(), out p);
            } while (!isValid);

            do
            {
                isValid = int.TryParse(Console.ReadLine(), out q);
            } while (!isValid);

            do
            {
                isValid = int.TryParse(Console.ReadLine(), out k);
            } while (!isValid || (p + k - 1 >= 32) || (q + k - 1 >= 32));

            uint setLSBs = 0;

            // form masks for bits {p, p+1, …, p+k-1} and {q, q+1, …, q+k-1}
            for (int i = 0; i < k; ++i)
            {
                setLSBs += (uint)Math.Pow(2, i);
            }

            uint mask_p = setLSBs << p;
            uint mask_q = setLSBs << q;

            // get bits {p, p+1, …, p+k-1} and {q, q+1, …, q+k-1}
            uint bits_p = n & mask_p;
            uint bits_q = n & mask_q;

            // clear bits {p, p+1, …, p+k-1}
            n &= ~(mask_p);

            // clear bits {q, q+1, …, q+k-1}
            n &= ~(mask_q);

            int shiftValue = Math.Abs(p - q);

            // exchange bits
            if (p < q)
            {
                n |= bits_p << shiftValue;
                n |= bits_q >> shiftValue;
            }
            else
            {
                n |= bits_p >> shiftValue;
                n |= bits_q << shiftValue;
            }

            // output value of n after bit swap
            Console.WriteLine(n);
        }
    }
}
