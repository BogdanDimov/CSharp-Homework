using System;

namespace NumsFrom1ToN
{
    class NumsFrom1ToN
    {
        static void Main()
        {

            UInt32 N = Convert.ToUInt32(Console.ReadLine());
            UInt32 count = 1;

            while (count <= N)
            {
                Console.Write(count + " ");
                count++;
            }
        }
    }
}
