using System;

namespace MethodsandObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Instantiate and initialize an Employee object with a first name of “Sample” and a last name of 'Student'."
            Employee em = new Employee();
            em.FirstName = "Sample";
            em.LastName = "Student";

            //"Call the superclass method SayName() on the Employee object."
            em.SayName();

        }
    }
}
