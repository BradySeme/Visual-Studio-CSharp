using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassAssignment
{
    public abstract class Person
    {
        //"Create an abstract class called Person with two properties: string firstName and string lastName."
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //"Give it the method SayName()."
        public abstract void SayName();
 
    }
}
