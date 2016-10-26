using System;

namespace NthBit
{
    class NthBit
    {
        static void Main()
        {
            long p;
            int n;
            bool isValid;

            do
            {
                isValid = long.TryParse(Console.ReadLine(), out p);
            } while (!isValid);

            do
            {
                isValid = int.TryParse(Console.ReadLine(), out n);
            } while (!isValid || n >= 55);

            Console.WriteLine(((p >> n) & 1) == 0 ? "0" : "1");
        }
    }
}
