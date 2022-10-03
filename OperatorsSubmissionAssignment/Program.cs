using System;

namespace OperatorsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em1 = new Employee();
            Employee em2 = new Employee();

            em1.ID = 6;
            em2.ID = 6;

            //Overloaded operator
            string answer = em1 == em2;

            Console.WriteLine(answer);
        }
    }
}
