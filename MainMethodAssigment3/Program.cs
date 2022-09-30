using System;

namespace MainMethodAssigment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the class
            MathEquations me = new MathEquations();

            //User input
            Console.Write("Enter in your first number:");
            int fnum = int.Parse(Console.ReadLine());
            Console.Write("Enter in your second number:");
            int snum = int.Parse(Console.ReadLine());

            //"Call the method in the class, passing in two numbers"
            me.Plus(fnum, snum);

            //User input
            Console.Write("Enter in your first number:");
            fnum = int.Parse(Console.ReadLine());
            Console.Write("Enter in your second number:");
            snum = int.Parse(Console.ReadLine());

            //"Call the method in the class, specifying the parameters by name"
            me.Plus(x: fnum, y: snum);

        }
    }
}
