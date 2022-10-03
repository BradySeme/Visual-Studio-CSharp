using System;

namespace ParsingEnumsSubmissionAssingment
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Prompt the user to enter the current day of the week."
            Console.WriteLine("Enter in a day of the week.");
            string day = Console.ReadLine();

            try
            {
                //"Prompt the user to enter the current day of the week."
                DOTW.DaysOfTheWeek day1 = (DOTW.DaysOfTheWeek)Enum.Parse(typeof(DOTW.DaysOfTheWeek), day);
                Console.WriteLine(day1);
            }
            catch (Exception)
            {
                //"Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs."
                Console.WriteLine("Please enter an actual day of the week.");
            }       

        }
    }
}
