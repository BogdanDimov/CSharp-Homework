using System;

namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string website = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            string managerAge = Console.ReadLine();
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + phoneNumber);
            Console.WriteLine("Fax: " + (faxNumber.Length == 0 ? "(no fax)" : faxNumber));
            Console.WriteLine("Web site: " + website);
            Console.Write("Manager: " + managerFirstName + " " + managerLastName);
            Console.Write(" (age: " + managerAge);
            Console.WriteLine(", tel. " + managerPhone + ")");
        }
    }
}
