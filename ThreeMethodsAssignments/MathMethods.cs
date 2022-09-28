using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeMethodsAssignments
{
    class MathMethods
    {
        //This is the methods that adds the input by 4
        public static void Plus(int input)
        {
            int answer = input + 4;
            Console.WriteLine($"{input} + 4 = {answer}");
        }

        //This is the methods that subtracts the input by 4
        public static void Minus(int input)
        {
            int answer = input - 4;
            Console.WriteLine($"{input} - 4 = {answer}");
        }

        //This is the methods that multiplies the input by 4
        public static void Multiply(int input)
        {
            int answer = input * 4;
            Console.WriteLine($"{input} x 4 = {answer}");
        }
    }
}
