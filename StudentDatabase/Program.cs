using System;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Brady Seme", Height = 6, Weight = 150 };
                                          

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
