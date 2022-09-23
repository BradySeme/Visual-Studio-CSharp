using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report\n");

            //Name input here
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            //Course input here
            Console.WriteLine("What course are you on?");
            int coursenum = Convert.ToInt32(Console.ReadLine());

            //Page input here
            Console.WriteLine("What page number?");
            int pagenum = Convert.ToInt32(Console.ReadLine());

            //Help input here
            Console.WriteLine("Do you need help with anything?");
            Console.WriteLine("Please answer true or false.");
            string help = Console.ReadLine();

            //Positive input here
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string exp = Console.ReadLine();

            //Feedback input here
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            //Hour input here
            Console.WriteLine("How many hours did you study today?");
            int hournum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
