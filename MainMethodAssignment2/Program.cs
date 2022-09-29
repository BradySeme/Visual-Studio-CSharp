using System;

namespace MainMethodAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring the class
            MathEquations me = new MathEquations();
            //Variables
            int fnum;
            int snum;
            

            //User input
            Console.WriteLine("Enter in two numbers one at a time. You don't have to enter in a second number");
            Console.Write("First number: ");
            fnum = int.Parse(Console.ReadLine());
            Console.Write("Second optional number: ");
            
            //If the user skips the second prompt, it will throw up an error, which will get caught below
            try
            {
                snum = int.Parse(Console.ReadLine());
                Console.WriteLine(me.Plus(fnum, snum));
            }

            //Here is where the exception will be caught 
            catch (Exception)
            {
                Console.WriteLine(me.Plus(fnum));
            }
            
        }
    }


}
