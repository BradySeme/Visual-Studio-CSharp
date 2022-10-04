using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    //"Create another class called Employee and have it inherit from the Person class."
    //"Implement the SayName() method inside of the Employee class."
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine(FirstName + LastName);
        }
    }
}
