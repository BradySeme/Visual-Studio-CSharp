using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeMethodsAssignments
{
    class MathMethods
    {
        public static void Plus(int input)
        {
            int answer = input + 4;
            Console.WriteLine($"{input} + 4 = {answer}");
        }

        public static void Minus(int input)
        {
            int answer = input - 4;
            Console.WriteLine($"{input} - 4 = {answer}");
        }

        public static void Multiply(int input)
        {
            int answer = input * 4;
            Console.WriteLine($"{input} x 4 = {answer}");
        }
    }
}
