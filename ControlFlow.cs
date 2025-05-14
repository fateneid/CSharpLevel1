using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLevel1
{
    internal class ControlFlow
    {

        public static void IfElseStatement()
        {

            Console.WriteLine("\n____________________if-then Statement____________________");

            int x = 10; int y = 20;

            if (x == 10 && y <= 20)
            {
                Console.WriteLine("yes x = 10 and y<=20");
            }

            Console.WriteLine("_________________________________________________________");

            Console.WriteLine("\n_________________if-then-else Statement__________________");

            if (x == 11)
            {
                Console.WriteLine("yes x = 11 ");
            }
            else
            {
                Console.WriteLine("yes x != 11 ");
            }

            Console.WriteLine("_________________________________________________________");

            Console.WriteLine("\n________________if-then-else if Statement________________");

            int number = 12;

            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }
            else if (number > 5)
            {
                Console.WriteLine("{0} is greater than 5", number);
            }
            else
            {
                Console.WriteLine("{0} is equal to 5");
            }

            Console.WriteLine("_________________________________________________________");


        }

        public static void SwitchStatement()
        {

            Console.WriteLine("\n____________________switch Statement_____________________");

            Console.WriteLine("\nExample1: switch Statement");

            char ch;
            Console.WriteLine("Enter a letter?");
            ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch))
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }

            Console.WriteLine("\nExample2: Grouped Cases");

            //switch statement with grouped cases
            switch (Char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }


            Console.WriteLine("\nExample3: Simple calculator");

            char op;
            double first, second, result;

            Console.Write("Enter first number: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            op = (char)Console.Read();

            switch (op)
            {
                case '+':
                    result = first + second;
                    Console.WriteLine("{0} + {1} = {2}", first, second, result);
                    break;

                case '-':
                    result = first - second;
                    Console.WriteLine("{0} - {1} = {2}", first, second, result);
                    break;

                case '*':
                    result = first * second;
                    Console.WriteLine("{0} * {1} = {2}", first, second, result);
                    break;

                case '/':
                    result = first / second;
                    Console.WriteLine("{0} / {1} = {2}", first, second, result);
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;

            }

            Console.WriteLine("\nExample4: String Compare");

            string Name = "Mona";
            //You can compare string as well using switch
            switch (Name.ToLower())
            {
                case "mona":

                    Console.WriteLine("Yes Mona");
                    break;

                case "lila":

                    Console.WriteLine("Yes Lila");
                    break;

                default:
                    Console.WriteLine("No Name Matched!");
                    break;

            }


            Console.WriteLine("_________________________________________________________");


        }

        public static void TernaryOperator()
        {

            Console.WriteLine("\n____________________Ternary Operator_____________________");

            int number = 3;
            bool isEven;

            isEven = (number % 2 == 0) ? true : false;

            Console.WriteLine(number + " is an " + (isEven ? "Even" : "Odd"));

            Console.WriteLine("_________________________________________________________");

        }

        public static void ForLoop()
        {

            Console.WriteLine("\n________________________for loop_________________________");

            Console.WriteLine("\nForward Loop:");

            for (int i = 1; i <= 10; i++)

            {

                Console.WriteLine(i);

            }

            Console.WriteLine("\nBackword Loop:");

            for (int i = 10; i >= 1; i--)

            {

                Console.WriteLine(i);

            }


            Console.WriteLine("\nNested Loops:");

            for (int i = 1; i <= 10; i++)

            {

                for (int j = 0; j < 10; j++)

                {

                    Console.WriteLine("i={0} and j={1}", i, j);

                }

            }

            Console.WriteLine("_________________________________________________________");

        }

        public static void WhileLoop()
        {

            Console.WriteLine("\n_______________________while loop________________________");

            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("C# while Loop: Iteration {0}", i);
                i++;
            }

            Console.WriteLine("_________________________________________________________");

        }

        public static void DoWhileLoop()
        {

            Console.WriteLine("\n_____________________do...while loop_____________________");

            int i = 1;
            do
            {
                Console.WriteLine("C# while Loop: Iteration {0}", i);
                i++;

            } while (i <= 5);


            Console.WriteLine("_________________________________________________________");

        }

        public static void BreakStatement()
        {

            Console.WriteLine("\n_____________________Break Statement_____________________");

            int i = 1;
            do
            {

                Console.WriteLine("C# while Loop: Iteration {0}", i);

                if (i == 3)
                    break;

                i++;

            } while (i <= 5);


            Console.WriteLine("_________________________________________________________");

        }

        public static void ContinueStatement()
        {

            Console.WriteLine("\n____________________Continue Statement___________________");

            for (int i = 1; i <= 5; ++i)
            {

                if (i == 3)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("_________________________________________________________");

        }


    }
}
