using System;

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            ulong productOdd, productEven;

            productEven = productOdd = 1;

            string str = Console.ReadLine();
            string[] string_numbers = str.Split(' ');

            for (int i = 0; i < string_numbers.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    productEven *= ulong.Parse(string_numbers[i]);
                }
                else
                {
                    productOdd *= ulong.Parse(string_numbers[i]);
                }
            }

            Console.WriteLine(productOdd == productEven ? "yes {0}" : "no {0} {1}", productOdd, productEven);
        }
    }
}
