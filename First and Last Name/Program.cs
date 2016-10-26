using System;

namespace _07.First_and_Last_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string lastName, firstName;

            Console.WriteLine("What's your First Name? ");
            firstName = Console.ReadLine();

            Console.WriteLine("What's your Last Name? ");
            lastName = Console.ReadLine();

            Console.WriteLine("Hello {0} {1}!\n", firstName, lastName);
        }
    }
}
