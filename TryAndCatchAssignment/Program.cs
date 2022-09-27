using System;
using System.Collections.Generic;

namespace TryAndCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            int[] listarray = { 1, 7, 4, 10, 8 };
            //I convert the array into a list
            List<int> listint = new List<int>(listarray);

            //User input
            Console.Write("Pick a number: ");

            //Try block
            try
            {
                int input = int.Parse(Console.ReadLine());
                for (int i = 0; i < listint.Count; i++)
                {
                    decimal answer = Convert.ToDecimal(input) / Convert.ToDecimal(listint[i]);
                    Console.WriteLine($"{input} divided by {listint[i]} equals {answer}"); 
                }
            }

            //First catch block
            //No matter what I do, I couldn't throw up the "DivideByZeroException"
            catch (DivideByZeroException)
            {
                Console.WriteLine("Don't divide by zero.");
            }

            //Second catch block
            catch (FormatException)
            {
                Console.WriteLine("Format Exeption, please try something else.");
            }

            //Finally block
            finally
            {
                Console.WriteLine("Emerged from try/catch");
            }
        }
    }
}
