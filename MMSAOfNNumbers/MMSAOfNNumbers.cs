using System;

namespace MMSAOfNNumbers
{
    class MMSAOfNNumbers
    {
        static void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double min, max, sum;

            min = 10000;
            max = -10000;
            sum = 0;

            double input;

            for (int i = 0; i < N; i++)
            {
                input = Convert.ToDouble(Console.ReadLine());

                if (input > max)
                {
                    max = input;
                }
                if (input < min)
                {
                    min = input;
                }

                sum += input;
            }

            Console.WriteLine("min={0:f2}", min);
            Console.WriteLine("max={0:f2}", max);
            Console.WriteLine("sum={0:f2}", sum);
            Console.WriteLine("avg={0:f2}", sum / N);
        }
    }
}
