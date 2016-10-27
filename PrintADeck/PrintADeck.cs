using System;

namespace PrintADeck
{
    class PrintADeck
    {
        static void Main()
        {

            string card = Console.ReadLine();
            ushort cardNum = 0;

            switch (card)
            {
                case "2": cardNum = 2; break;
                case "3": cardNum = 3; break;
                case "4": cardNum = 4; break;
                case "5": cardNum = 5; break;
                case "6": cardNum = 6; break;
                case "7": cardNum = 7; break;
                case "8": cardNum = 8; break;
                case "9": cardNum = 9; break;
                case "10": cardNum = 10; break;
                case "J": cardNum = 11; break;
                case "Q": cardNum = 12; break;
                case "K": cardNum = 13; break;
                case "A": cardNum = 14; break;
            }

            for (int i = 2; i <= cardNum; i++)
            {
                if (i == 11)
                {
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                }
                else if (i == 12)
                {
                    Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                }
                else if (i == 13)
                {
                    Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                }
                else if (i == 14)
                {
                    Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");
                }
                else
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
            }
        }
    }
}
