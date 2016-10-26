using System;

namespace DivideBy7And5
{
    class Program
    {
        static void Main()
        {
            bool validValue = false;
            int someInt;

            do
            {
                validValue = int.TryParse(Console.ReadLine(), out someInt);
            } while (!validValue);

            if (someInt % 5 == 0 && someInt % 7 == 0)
            {
                Console.WriteLine("true {0}", someInt);
            }
            else
            {
                Console.WriteLine("false {0}", someInt);
            }
        }
    }
}
