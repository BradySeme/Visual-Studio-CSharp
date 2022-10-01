using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Implement the SayName() method inside of the Employee class."
            Employee em = new Employee();

            //"Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”.
            //Call the SayName() method on the object."

            em.FirstName = "Sample ";
            em.LastName = "Student";

            em.SayName();            
        }
    }
}
