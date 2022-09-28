using System;

namespace MainMethodAssignment
{
    class Program
    {

        static void Main(string[] args)
        {
            MathEquations mq = new MathEquations();

        //v Put in any number here v
            mq.Change("3");

        }

    }

    class MathEquations
    {
        //First method adds
        public void Change(int input)
        {
            int answer = input + 4;
            Console.WriteLine($"{input} + 4 = {answer}");
        }

        //Second method subtracts
        public void Change(double input)
        {
            double answer = input - 4;
            Console.WriteLine($"{input} - 4 = {answer}");
        }

        //Third method multiplies
        public void Change(string input)
        {
            double x = Double.Parse(input);
            double answer = x * 4;
            Console.WriteLine($"{input} * 4 = {answer}");
        }

    }
}
