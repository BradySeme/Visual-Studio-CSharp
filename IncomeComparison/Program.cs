using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int p1Hourlyrate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            int p1Hoursworked = Convert.ToInt32(Console.ReadLine());
            int p1annual = (p1Hoursworked * p1Hourlyrate) * 52;

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            int p2Hourlyrate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            int p2Hoursworked = Convert.ToInt32(Console.ReadLine());
            int p2annual = (p2Hoursworked * p2Hourlyrate) * 52;

            Console.WriteLine("Annual salary of Person 1: \n" + p1annual);
            Console.WriteLine("Annual salary of Person 2 : \n" + p2annual);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool p1vp2 = p1annual > p2annual;
            Console.WriteLine(p1vp2);

        }
    }
}
