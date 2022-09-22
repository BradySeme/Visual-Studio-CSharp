using System;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentSixParts
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the array
            string[] strarray = { "Hello", "Hi", "How are you" };

            //Prompts user to input a word
            Console.Write("Please input one word: ");
            string oneword = Console.ReadLine();

            //Loops through each word in the array and adds the users input to the end
            for (int i = 0; i < strarray.Length; i++)
            {
                strarray[i] = strarray[i] + " " + oneword;
            }

            //Displays each new string
            //My girlfriend wanted to name the variable ben lol if thats an issue then I can change it
            foreach (string ben in strarray)
            {
                Console.WriteLine(ben);
            }


            //Second step
            //-------------------------------------------------------------------------------
            bool isTrue = true;

            while (isTrue == true)
            {
                Console.WriteLine("The variable is true");
                //I added this vvvv to stop the program after 1 loop, before I added it was an infinite loop.
                isTrue = false;
            }



            //Third step
            //-------------------------------------------------------------------------------
            int[] intarray = new int[10];

            //I am using the comparison "<" here
            for (int v = 0; v < intarray.Length; v++)
            {
                intarray[v] = v;
            }

            //I am using the comparison "<=" here
            for (int f = 0; f <= 5; f++)
            {
                Console.WriteLine(intarray[f]);
            }


            //Fourth step
            //-------------------------------------------------------------------------------
            //My list of strings
            List<string> strlist = new List<string>();
            strlist.Add("Garfield");
            strlist.Add("Apples");
            strlist.Add("Saturn");
            strlist.Add("Christmas");

            //User input
            Console.WriteLine("What word are you searching for?");
            string theword = Console.ReadLine();
            int index = strlist.IndexOf(theword);

            //My loop that iterates through the list
            for (int a = 0; a < strlist.Count; a++)
            {
                //I noticed that a if a value does not exist in a list, then the index is -1
                if (index == -1)
                {
                    Console.WriteLine("Your word does not exist");
                    break;
                }

                else
                {
                    Console.WriteLine(index);
                    //Code breaks here
                    break;
                }
            }


            //Fifth step
            //-------------------------------------------------------------------------------
            //List of strings with two duplicates
            List<string> strlist1 = new List<string>();
            strlist1.Add("Garfield");
            strlist1.Add("Apples");
            strlist1.Add("Saturn");
            strlist1.Add("Christmas");
            strlist1.Add("Apples");

            //User input
            Console.WriteLine("What word are you searching for?");
            string theword1 = Console.ReadLine();

            //A loop that iterates through the list
            for (int a = 0; a < strlist1.Count; a++)
            {
                int index1 = strlist1.IndexOf(theword1);
                string tempvar = strlist1[a];

                //tempvar changes every loop and if it equals the users input then it displays the index of that word
                if (tempvar == theword1)
                {
                    Console.WriteLine(a);

                }


                if (index1 == -1)
                {
                    Console.WriteLine("your word does not exist");
                    //Same break statement from the previous step
                    break;
                }

            }


            //Six step
            //-------------------------------------------------------------------------------
            //List of strings with two duplicates
            List<string> strlist2 = new List<string>();
            strlist2.Add("Garfield");
            strlist2.Add("Apples");
            strlist2.Add("Saturn");
            strlist2.Add("Christmas");
            strlist2.Add("Apples");

            //User input
            Console.WriteLine("What word are you searching for?");
            string theword2 = Console.ReadLine();

            //A foreach loop
            //It displays both of the variables as duplicates, I feel like this would meet the requirement but if this wrong, then I can change it
            foreach (string name in strlist2)
            {
                if (name == theword2)
                {
                    Console.WriteLine($"{name} is not unique.");
                }

                else
                {
                    Console.WriteLine($"{name} is unique.");
                }
            }


        }
    }
}
