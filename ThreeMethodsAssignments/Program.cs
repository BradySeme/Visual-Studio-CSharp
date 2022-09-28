using System;

namespace ThreeMethodsAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethods mm = new MathMethods();
            //User input
            Console.Write("Enter a number: \n");
            int input = int.Parse(Console.ReadLine());

            //This is calling each of the methods
            Console.WriteLine($"{input} + 4 = {mm.Plus(input)}");
            Console.WriteLine($"{input} - 4 = {mm.Minus(input)}");
            Console.WriteLine($"{input} x 4 = {mm.Multiply(input)}");

        }
    }
}
