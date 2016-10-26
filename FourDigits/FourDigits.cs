using System;

namespace FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            int fourDigitNumber;
            bool isValid = false;

            do
            {
                isValid = int.TryParse(Console.ReadLine(), out fourDigitNumber);
            } while (!isValid);

            int first, second, third, fourth;

            first = fourDigitNumber % 10;
            second = (fourDigitNumber / 10) % 10;
            third = (fourDigitNumber / 100) % 10;
            fourth = (fourDigitNumber / 1000) % 10;

            // 1. Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4) 
            // and prints it on the console.

            Console.WriteLine(first + second + third + fourth);

            // 2. Prints on the console the number in reversed order: dcba (in our example 1102) 
            // and prints the reversed number.

            Console.WriteLine((fourth + third * 10 + second * 100 + first * 1000).ToString("D4"));

            // 3. Puts the last digit in the first position: dabc (in our example 1201) and 
            // prints the result.

            Console.WriteLine((first * 1000 + fourth * 100 + third * 10 + second).ToString("D4"));

            // 4. Exchanges the second and the third digits: acbd (in our example 2101) and 
            // prints the result.      

            Console.WriteLine((fourth * 1000 + second * 100 + third * 10 + first).ToString("D4"));
        }
    }
}
