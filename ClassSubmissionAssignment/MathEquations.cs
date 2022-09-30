using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSubmissionAssignment
{
    //This is the static class
    public static class MathEquations
    {
        //The two methods below are being overloaded
        public static void Half(double x)
        {
            Console.WriteLine(x / 2);
        }

        public static void Half(out string y)
        {
            y = "Have a nice day!";
        }
    }
}
