using System;

namespace ConstructorSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Create a const variable."
            const string word = "Hello ";
            //"Create a variable using the keyword 'var'."
            var word2 = "World!";
            Console.WriteLine(word + word2);

            User sample = new User();

            Console.WriteLine(sample.name + " " + sample.age);
            
            User sample2 = new User("Brady", 21);

            Console.WriteLine(sample2.name + " " + sample2.age);

        }
    }
}
