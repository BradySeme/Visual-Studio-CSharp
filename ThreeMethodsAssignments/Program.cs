using System;

namespace ThreeMethodsAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            //User input
            Console.Write("Enter a number: \n");
            int answer = int.Parse(Console.ReadLine());

            //This is calling each of the methods
            MathMethods.Plus(answer);
            MathMethods.Minus(answer);
            MathMethods.Multiply(answer);
            
        }
    }
}
