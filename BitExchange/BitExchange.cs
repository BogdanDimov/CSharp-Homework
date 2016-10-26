using System;

namespace BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            uint N;
            bool isValid;

            int numberOfSetBits = 3;
            uint setLSBs = 0;

            do
            {
                isValid = uint.TryParse(Console.ReadLine(), out N);
            } while (!isValid);


            // form masks for positions 3,4,5 and 24,25,26
            for (int i = 0; i < numberOfSetBits; ++i)
            {
                setLSBs += (uint)Math.Pow(2, i);
            }

            uint smallMask = setLSBs << 3;
            uint largeMask = setLSBs << 24;
            
            // get bits at positions 3,4,5 and 24,25,26
            uint bits_3_4_5 = N & smallMask;
            uint bits_24_25_26 = N & largeMask;

            // clear bits at positions 3,4,5
            uint result = N & ~(smallMask);

            // clear bits at positions 24,25,26
            result &= ~(largeMask);

            // exchange bits
            result |= bits_3_4_5 << 21;
            result |= bits_24_25_26 >> 21;

            Console.WriteLine(result);
        }
    }
}
