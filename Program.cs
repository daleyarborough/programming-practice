using System;
using System.Collections.Generic;

namespace programming_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Problems problems = new Problems();
            problems.isValid("aabbcd");
            problems.printChars(6);
            CheckValue checkValues = new CheckValue();
            Console.WriteLine("Please type your name...");
            checkValues.Name = Console.ReadLine();
            checkValues.ReturnIfContainsMyName(checkValues.Name);
        }

        
    }
}
