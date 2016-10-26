using System;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            bool inputValid = false;
            int someInt;
            string someString;

            do
            {
                someString = Console.ReadLine();

                if (int.TryParse(someString, out someInt))
                {
                    inputValid = true;

                    Console.WriteLine((someInt & 1) == 1 ? "odd " + someInt : "even " + someInt);
                }

            } while (!inputValid);
        }
    }
}