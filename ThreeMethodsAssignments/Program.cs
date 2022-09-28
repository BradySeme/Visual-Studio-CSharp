using System;

namespace ThreeMethodsAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: \n");
            int answer = int.Parse(Console.ReadLine());

            MathMethods.Plus(answer);
            MathMethods.Minus(answer);
            MathMethods.Multiply(answer);
            
        }
    }
}
