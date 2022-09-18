using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int pkqweight = Convert.ToInt32(Console.ReadLine());
            if (pkqweight <= 50) 
            {
                Console.WriteLine("Please enter the package width:");
                int pkqwidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int pkqheight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int pkqlength = Convert.ToInt32(Console.ReadLine());

                int pkqdimensions = pkqheight + pkqlength + pkqwidth;
                if (pkqdimensions <= 50)
                {

                    int total = ((pkqheight * pkqlength * pkqwidth) * pkqweight) / 100;
                    Console.WriteLine($"Your estimated total for shipping this package is: {total.ToString("C")} \nThank you!");
                }

                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
            }

            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

        }
    }
}
