using System;

namespace AssignmentArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strarray = { "I", "like", "sour", "jelly", "beans" };
            int strlength = strarray.Length;
            int[] intarray = { 6, 4, 10, 200, 3, 453056};
            int intlength = intarray.Length;

            Start:
            Console.WriteLine("Select an index of the Array");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i > strlength)
            {
                Console.WriteLine("You selected an empty index, please try again.\n");
                goto Start;
            }

            else
            {
                Console.WriteLine(strarray[i]);
            }

            Start1:
            Console.WriteLine("Select an index of the Array");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > intlength)
            {
                Console.WriteLine("You selected an empty index, please try again.\n");
                goto Start1;
            }

            else
            {
                Console.WriteLine(intarray[n]);
            }



        }
    }
}
