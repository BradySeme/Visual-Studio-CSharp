using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSubmissionAssignment
{
    //"Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose."
    public class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("Press a key to exit...");
            Console.ReadKey();
        }
    }
}
