using System;
using System.Collections.Generic;

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
            List<string> stringlist = new List<string>();
            stringlist.Add("I");
            stringlist.Add("don't");
            stringlist.Add("really");
            stringlist.Add("know");
            stringlist.Add("what");
            stringlist.Add("I'm");
            stringlist.Add("doing");
            int listlength = stringlist.Count;


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
            Console.WriteLine("\nSelect an index of the Array");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > intlength)
            {
                Console.WriteLine("You selected an empty index, please try again.");
                goto Start1;
            }

            else
            {
                Console.WriteLine(intarray[n]);
            }

            Start2:
            Console.WriteLine("\nSelect an index of the List");
            int v = Convert.ToInt32(Console.ReadLine());
            if (v > listlength)
            {
                Console.WriteLine("You selected an empty index, please try again.");
                goto Start2;
            }

            else
            {
                Console.WriteLine(stringlist[v]);
            }

        }
    }
}
