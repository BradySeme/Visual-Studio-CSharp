using System;

namespace AssignmentDoAndDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 10;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine();

            do
            {
                Console.WriteLine(n);
                n--;
            }
            while (n > 5);
        }
    }
}
