using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            ushort score;

            score = Convert.ToUInt16(Console.ReadLine());

            if (score >= 1 && score <=3)
            {
                Console.WriteLine(score * 10);
            }
            else if (score >= 4 && score <= 6)
            {
                Console.WriteLine(score * 100);
            }
            else if (score >= 7 && score <= 9)
            {
                Console.WriteLine(score * 1000);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
