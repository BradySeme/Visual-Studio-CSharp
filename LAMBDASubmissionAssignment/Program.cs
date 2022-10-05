using System;
using System.Collections.Generic;
using System.Linq;

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
                new Employee() { ID = 9, FirstName = "Chris", LastName = "Pratt"}
            };


            List<Employee> listofusers2 = new List<Employee>();
            

            foreach (Employee employee in listofusers)
            {
                if (employee.FirstName == "Joe")
                {
                    listofusers2.Add(employee);
                }

            }

            List<Employee> listofusers3 = new List<Employee>();

            listofusers3 = listofusers.Where(p => p.FirstName == "Joe").ToList();

            foreach(Employee employee1 in listofusers3)
            {
                Console.WriteLine(employee1.FirstName);
            }

            List<Employee> listofusers4 = new List<Employee>();

            listofusers4 = listofusers.Where(P => P.ID <= 5).ToList();
        }
    }
}
