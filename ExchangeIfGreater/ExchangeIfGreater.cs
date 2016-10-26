using System;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            double A, B;

            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());

            if (A > B)
            {
                double temp;

                temp = A;
                A = B;
                B = temp;
            }

            Console.WriteLine(A + " " + B);
        }
    }
}
