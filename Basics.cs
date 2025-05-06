using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLevel1
{
    internal class Basics
    {

        public static void Output()
        {
            Console.WriteLine("::::::::::::::::::::::::WriteLine::::::::::::::::::::::::");
            Console.WriteLine("Hello World!");
            Console.WriteLine("My Name is Faten");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is an easy language to learn :-)");
            Console.WriteLine("The sum of 10 + 20 is " + (10 + 20));
            Console.WriteLine("The sum of 10 + 20 is " + 10 + 20 + "without brackets");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            Console.WriteLine("\n::::::::::::::::::::::::::Write::::::::::::::::::::::::::");
            Console.Write("Hello World!");
            Console.Write(" My Name is Faten");
            Console.Write(" and I am Learning C#.");
            Console.WriteLine("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            Console.WriteLine("\n:::::::::::::::::::::FormattedString:::::::::::::::::::::");
            Console.WriteLine("{0} {1}", "Welcome to", "ProgrammingAvices");
            Console.WriteLine("Hi! My Name is: {0} and I live in {1} ", "Faten", "Egypt");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            Console.WriteLine("\n::::::::::::::::::::Escape Characters::::::::::::::::::::");
            Console.WriteLine("Useful Escape Characters:\n");

            //Newline
            Console.WriteLine("Newline:");
            Console.WriteLine("Welcome to \n ProgrammingAvices\n");

            //Tab
            Console.WriteLine("Tab:");
            Console.WriteLine("Welcome to\tProgrammingAvices\n");

            //Backspace
            Console.WriteLine("Backspace:");
            Console.WriteLine("Welcome to \bProgrammingAvices\n");

            //Single quote
            Console.WriteLine("Single Quote:");
            Console.WriteLine("Welcome to \' ProgrammingAvices \'\n");

            //Double quote
            Console.WriteLine("Double Quote:");
            Console.WriteLine("Welcome to \" ProgrammingAvices \"\n");

            //Backslash
            Console.WriteLine("Backslash:");
            Console.WriteLine("Welcome to \\ ProgrammingAvices \\\n");

            //Alert
            Console.WriteLine("Alert:");
            Console.WriteLine("\a");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            Console.ReadKey();

        }


    }
}
