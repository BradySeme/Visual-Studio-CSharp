using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorSubmissionAssignment
{
    public class User
    {
        public string name;
        public int age;

        //"Chain two constructors together."
        public User() : this("DefaultUser")
        {
        }

        public User(string name) : this(name, 18)
        { 
        }

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
