using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLevel1
{
    internal class CSharpMethods
    {

        static void PrintHi()
        {
            Console.WriteLine("Hi ^_^");
        }

        static void PrintInfo(string Name, byte ID)
        {
            Console.WriteLine("Name = {0} , ID = {1}", Name, ID);
        }

        static void PrintInfo2(string Name, byte ID, string Color = "White")
        {
            Console.WriteLine("Name = {0} , ID = {1}, Color = {2}", Name, ID, Color);
        }

        static string GetColor()
        {
            return "Green";

        }

        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        static int Sum(int Num1, int Num2)

        {
            return Num1 + Num2;
        }

        static int Sum(int Num1, int Num2, int Num3)

        {
            return Num1 + Num2 + Num3;
        }

        static int Sum(int Num1, int Num2, int Num3, int Num4)

        {
            return Num1 + Num2 + Num3 + Num4;
        }

        public static void Methods()
        {

            Console.WriteLine("\n_________________________Methods_________________________");

            PrintHi();
            PrintInfo("Person1", 70);
            PrintInfo2("Person2", 10);
            PrintInfo2("Person3", 40, "Green");
            Console.WriteLine("My fav color is {0}.", GetColor());
            //see the order of sending parameters is not important.
            MyMethod(child3: "Omar", child1: "Saqer", child2: "Hamza");
            //Method Overloading
            Console.WriteLine(Sum(10, 20));
            Console.WriteLine(Sum(10, 20, 30));
            Console.WriteLine(Sum(10, 20, 30, 40));

            Console.WriteLine("\n_________________________________________________________");

        }


    }
}
