using System;

namespace _3rdBit
{
    class Program
    {
        static void Main()
        {
            uint input;
            bool isValid = false;

            do
            {
                isValid = uint.TryParse(Console.ReadLine(), out input);
            } while (!isValid);

            Console.WriteLine(((input >> 3) & 1) == 0 ? "0" : "1");
        }
    }
}
