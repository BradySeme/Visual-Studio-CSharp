using System;
using System.Collections.Generic;

namespace LAMBDASubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee();
            List<Employee> listofusers = new List<Employee>()
            {
                new Employee() { ID = 0, FirstName = "Joe", LastName = "Pham"},
                new Employee() { ID = 1, FirstName = "Claire", LastName = "Prestgard"},
                new Employee() { ID = 2, FirstName = "Chris", LastName = "Butler"},
                new Employee() { ID = 3, FirstName = "Brady", LastName = "Seme"},
                new Employee() { ID = 4, FirstName = "Bill", LastName = "Cruz"},
                new Employee() { ID = 5, FirstName = "Ben", LastName = "Dover"},
                new Employee() { ID = 6, FirstName = "Joe", LastName = "Mama"},
                new Employee() { ID = 7, FirstName = "Harry", LastName = "Anoos"},
                new Employee() { ID = 8, FirstName = "Hugh", LastName = "Mungus"},
                new Employee() { ID = 9, FirstName = "Anne", LastName = "Null"}
            };

            var listofusers1 = listofusers                

            

            foreach (string name in listofusers[em.FirstName])
            {
                Console.WriteLine(name);

            }

        }
    }
}
