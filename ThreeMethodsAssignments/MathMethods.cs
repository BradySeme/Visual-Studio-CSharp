using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeMethodsAssignments
{
    class MathMethods
    {
        //This is the methods that adds the input by 4
        public int Plus(int input)
        {
            int answer = input + 4;
            return answer;
        }

        //This is the methods that subtracts the input by 4
        public int Minus(int input)
        {
            int answer = input - 4;
            return answer;
        }

        //This is the methods that multiplies the input by 4
        public int Multiply(int input)
        {
            int answer = input * 4;
            return answer;
        }
    }
}
