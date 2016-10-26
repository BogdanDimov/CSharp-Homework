using System;

class PrimeCheck
{
    static void Main()
    {
        string isPrime = "true";
        int number;
        bool isInt = int.TryParse(Console.ReadLine(), out number);

        if (isInt)
        {
            if (number <= 1)
            {
                isPrime = "false";
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = "false";
                    }
                }
            }

            Console.WriteLine(isPrime);
        }
    }
}