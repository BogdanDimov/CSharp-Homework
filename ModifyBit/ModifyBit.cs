using System;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            ulong N, mask;
            int v, P;
            bool isValid = false;

            do
            {
                isValid = ulong.TryParse(Console.ReadLine(), out N);
            } while (!isValid);

            do
            {
                isValid = int.TryParse(Console.ReadLine(), out P);
            } while (!isValid || P < 0 || P >= 64);

            do
            {
                v = int.Parse(Console.ReadLine());
            } while (v != 0 && v != 1);

            mask = (ulong)1 << P;

            Console.WriteLine(v == 1 ? N |= mask : N &= ~mask);
        }
    }
}
