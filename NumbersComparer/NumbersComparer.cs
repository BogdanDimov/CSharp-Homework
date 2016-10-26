using System;

namespace NumbersComparer
{
    class NumbersComparer
    {
        static void Main()
        {
            double A, B;

            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(A < B ? B : A);
        }
    }
}
