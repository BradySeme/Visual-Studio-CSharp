using System;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variable
            string word;

            //User input
            Console.Write("Enter a number to divide by 2: ");
            int fnum = int.Parse(Console.ReadLine());

            //This method divides by two
            MathEquations.Half(fnum);

            //This method outputs to the variable "word"
            MathEquations.Half(out word);

            //This is what is being output
            Console.WriteLine(word);
        }
    }
}
