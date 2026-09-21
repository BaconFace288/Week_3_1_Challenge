using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_1_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetUserAge();
        }

        static void GetUserAge()
        {
            // Requirements
            /*
             * 1. Create a try/catch block to handle exceptions that may occur when parsing the user's input.
             * 2. If the user enters a non-integer value, catch the exception and display an error message.
             * 3. If the user enters a negative integer, display an error message indicating that age cannot be negative.
             * 4. Add recursion to allow the user to re-enter their age until a valid input is provided.
             */
            Console.WriteLine("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = int.Parse(ageInput);
            Console.WriteLine($"You are {age} years old.");
        }
    }
}
