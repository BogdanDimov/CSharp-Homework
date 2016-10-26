using System;

namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
            string s, text;
            double d;
            int i;

            s = Console.ReadLine();

            if (s == "integer")
            {
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(i + 1);
            }
            else if (s == "real")
            {
                d = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("{0:F2}", d + 1.0);
            }
            else if (s == "text")
            {
                text = Console.ReadLine();
                Console.WriteLine(text + "*");
            }
        }
    }
}
