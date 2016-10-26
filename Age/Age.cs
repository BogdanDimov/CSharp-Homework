using System;
class Program
{
    static void Main()
    {

        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;
        int age = (int)((now.AddMonths(-7) - birthday).TotalDays / 365.242199);
        Console.WriteLine("{0}\n{1}", age, age + 10);
    }
}