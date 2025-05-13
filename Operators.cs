using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLevel1
{
    internal class Operators
    {

        public static void AssignmentOperators()
        {

            Console.WriteLine("\n__________________Assignment Operators___________________");

            int x;

            // += Addition Assignment
            x = 10;
            x += 5; // x = x + 5
            Console.WriteLine("+= : " + x); // 15

            // -= Subtraction Assignment
            x = 10;
            x -= 5; // x = x - 5
            Console.WriteLine("-= : " + x); // 5

            // *= Multiplication Assignment
            x = 10;
            x *= 5; // x = x * 5
            Console.WriteLine("*= : " + x); // 50

            // /= Division Assignment
            x = 10;
            x /= 5; // x = x / 5
            Console.WriteLine("/= : " + x); // 2

            // %= Modulo Assignment
            x = 10;
            x %= 3; // x = x % 3
            Console.WriteLine("%= : " + x); // 1

            // &= Bitwise AND Assignment
            x = 10; // 1010
            x &= 5; // x = x & 5 => 1010 & 0101 = 0000
            Console.WriteLine("&= : " + x); // 0

            // |= Bitwise OR Assignment
            x = 10; // 1010
            x |= 5; // x = x | 5 => 1010 | 0101 = 1111
            Console.WriteLine("|= : " + x); // 15

            // ^= Bitwise XOR Assignment
            x = 10; // 1010
            x ^= 5; // x = x ^ 5 => 1010 ^ 0101 = 1111
            Console.WriteLine("^= : " + x); // 15

            // <<= Left Shift Assignment
            x = 2; // 0010
            x <<= 2; // x = x << 2 => 1000
            Console.WriteLine("<<= : " + x); // 8

            // >>= Right Shift Assignment
            x = 8; // 1000
            x >>= 2; // x = x >> 2 => 0010
            Console.WriteLine(">>= : " + x); // 2

            // => Lambda Operator (not an assignment, used in expressions)
            Func<int, int> square = y => y * y;
            Console.WriteLine("Lambda (=>) : " + square(5)); // 25

            Console.WriteLine("_________________________________________________________");

        }

        public static void ArithmeticOperators()
        {

            Console.WriteLine("\n__________________Arithmetic Operators___________________");

            int x = 4, y = 7;

            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine("-------------");
            Console.WriteLine("x + y = " + (x + y));
            Console.WriteLine("x - y = " + (x - y));
            Console.WriteLine("x * y = " + (x * y));
            Console.WriteLine("x / y = " + (x / y));
            Console.WriteLine("x % y = " + (x % y));

            Console.WriteLine("_________________________________________________________");

        }

        public static void RelationalOperators()
        {

            Console.WriteLine("\n__________________Relational Operators___________________");

            int x = 4, y = 7;

            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine("-------------");
            Console.WriteLine("x == y = " + (x == y));
            Console.WriteLine("x > y = " + (x > y));
            Console.WriteLine("x < y = " + (x < y));
            Console.WriteLine("x >= y = " + (x >= y));
            Console.WriteLine("x <= y = " + (x <= y));
            Console.WriteLine("x != y = " + (x != y));

            Console.WriteLine("_________________________________________________________");


        }

        public static void LogicalOperators()
        {

            Console.WriteLine("\n____________________Logical Operators____________________");

            bool x = true, y = false;

            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine("--------------------------------");

            Console.WriteLine($"x || x = {x || x}, x && x = {x && x}");
            Console.WriteLine($"x || y = {x || y}, x && y = {x && y}");
            Console.WriteLine($"y || x = {y || x}, y && x = {y && x}");
            Console.WriteLine($"y || y = {y || y}, y && y = {y && y}");

            Console.WriteLine("_________________________________________________________");

        }

        public static void UnaryOperators()
        {

            Console.WriteLine("\n_____________________Unary Operators_____________________");

            int number = 10;
            bool flag = true;

            Console.WriteLine($"number = {number}, flag = {flag}");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("+number = " + (+number));

            Console.WriteLine("-number = " + (-number));

            Console.WriteLine("++number = " + (++number));

            Console.WriteLine("--number = " + (--number));

            Console.WriteLine("!flag = " + (!flag));

            Console.WriteLine((number++));
            Console.WriteLine((number));

            Console.WriteLine((++number));
            Console.WriteLine((number));

            Console.WriteLine("_________________________________________________________");

        }

        public static void TernaryOperator()
        {

            Console.WriteLine("\n____________________Ternary Operator_____________________");

            int number = 12;
            string result;

            result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine("{0} is an {1}", number, result);

            Console.WriteLine("_________________________________________________________");

        }

        public static void BitwiseOperators()
        {

            Console.WriteLine("\n____________________Bitwise Operators____________________");

            int a = 4;    
            int b = 7;   

            Console.WriteLine($"~a: {~a}");        
            Console.WriteLine($"a & b: {a & b}");
            Console.WriteLine($"a | b: {a | b}");  
            Console.WriteLine($"a ^ b: {a ^ b}"); 
            Console.WriteLine($"a << 1: {a << 1}"); 
            Console.WriteLine($"a >> 1: {a >> 1}");

            Console.WriteLine("_________________________________________________________");

        }


    }
}
