using System;
namespace NotDivisibleNumbers
{
    class NotDivisibleNumbers
    {
        static void Main()
        {
            uint N = Convert.ToUInt32(Console.ReadLine());
            uint count = 1;

            while (count <= N)
            {
                if (count % 3 == 0 || count % 7 == 0)
                {
                    count++;
                    continue;
                }
                else
                {
                    Console.Write(count + " ");
                    count++;
                }
            }
        }
    }
}
