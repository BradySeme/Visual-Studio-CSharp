using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = new DateTime();
            time = DateTime.Now;

            //"Prints the current date and time to the console."
            Console.WriteLine(DateTime.Now);

            //"Asks the user for a number."
            Console.WriteLine("Enter a number");
            int answer = int.Parse(Console.ReadLine());

            //"Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2."
            DateTime newtime = time.AddHours(answer);
            Console.WriteLine(newtime);
            
        }
    }
}
