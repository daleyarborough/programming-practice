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
            printChars(6);
            CheckValue checkValues = new CheckValue();
            Console.WriteLine("Please type your name...");
            checkValues.Name = Console.ReadLine();
            checkValues.ReturnIfContainsMyName(checkValues.Name);
        }

        public static void printChars(int num)
        {
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine(new String('#', i + 1).PadLeft(num));
            }
        }
    }
}
