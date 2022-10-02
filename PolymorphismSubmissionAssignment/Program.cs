using System;

namespace PolymorphismSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface."
            IQuittable em = new Employee();
            em.Quit();
        }
    }
}
