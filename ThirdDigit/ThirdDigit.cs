using System;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {

            int myInt;
            bool isValid = false;            

            do
            {
                isValid = int.TryParse(Console.ReadLine(), out myInt);
            } while (!isValid);

            int thirdDigit = (myInt / 100) % 10;

            if (thirdDigit == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + thirdDigit);
            }
        }
    }
}
