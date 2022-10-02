using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsSubmissionAssignment
{
    public class Employee
    {
        //"Create an Employee class with Id, FirstName and LastName properties. "
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //"In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
        //Remember that comparison operators must be overloaded in pairs."
        public static string operator== (Employee ID1, Employee ID2)
        {
            string answer;
            if (ID1.ID == ID2.ID)
            {
                 answer = "The IDs match";
            }
            else
            {
                answer = "The IDs don't match";
            }
            return answer;
        }

        public static string operator !=(Employee ID1, Employee ID2)
        {
            string answer;
            if (ID1.ID != ID2.ID)
            {
                answer = "The IDs don't match";
            }
            else
            {
                answer = "The IDs match";
            }
            return answer;
        }
    }
}
