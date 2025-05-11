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
            Console.WriteLine("\n::::::::::::::::::::::::WriteLine::::::::::::::::::::::::");
            Console.WriteLine("Hello World!");
            Console.WriteLine("My Name is Faten");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is an easy language to learn :-)");
            Console.WriteLine("The sum of 10 + 20 is " + (10 + 20));
            Console.WriteLine("The sum of 10 + 20 is " + 10 + 20 + " without brackets");
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

        }

        public static void Comment()
        {

            Console.WriteLine("\n:::::::::::::::::::::::::Comment:::::::::::::::::::::::::");

            //this is a single line comment 

            Console.Write("I Love C# ^^");

            /*

             This is 
             a multiple line
             comment.

             */
            Console.WriteLine("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

        }

        public static void Variables()
        {

            Console.WriteLine("\n::::::::::::::::::::::::Variables::::::::::::::::::::::::");

            string MyName = "Faten";
            Console.WriteLine(MyName);

            int x = 10; int y = 20;

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            Console.WriteLine("x + y = " + x + y + " <= wrong ans"); //wrong
            Console.WriteLine("x + y = " + (x + y));

            double MyDouble = 25.89D;
            char MyLetter = 'F';
            bool MyBool = true;

            Console.WriteLine("MyDouble = " + MyDouble);
            Console.WriteLine("MyLetter = " + MyLetter);
            Console.WriteLine("MyBool = " + MyBool);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            Console.WriteLine("\n::::::::::::::::Implicitly TypedVariables::::::::::::::::");

            var l = 10;
            var m = 10.5;
            var n = "Faten";
            Console.WriteLine("L = {0}, M = {1}, N = {2}", l, m, n);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

        }

        public static void NumbersDatatypes()
        {

            Console.WriteLine("\n::::::::::::::::::::Numbers Datatypes::::::::::::::::::::");

            //Byte
            byte b1 = 255;
            //  byte b2 = -128;// compile-time error: Constant value '-128' cannot be converted to a 'byte'
            sbyte sb1 = -128;
            sbyte sb2 = 127;
            Console.WriteLine("\nByte:");
            Console.WriteLine("Min={0} , Max={1}", Byte.MinValue, Byte.MaxValue);


            Console.WriteLine("\nSByte:");
            Console.WriteLine("Min={0} , Max={1}", SByte.MinValue, SByte.MaxValue);

            //Short
            short s1 = -32768;
            short s2 = 32767;
            // short s3 = 35000;//Compile-time error: Constant value '35000' cannot be converted to a 'short'

            ushort us1 = 65535;
            //  ushort us2 = -32000; //Compile-time error: Constant value '-32000' cannot be converted to a 'ushort'

            Console.WriteLine("\nShort:");
            Console.WriteLine("Min={0} , Max={1}", Int16.MinValue, Int16.MaxValue);

            Console.WriteLine("\nUShort:");
            Console.WriteLine("Min={0} , Max={1}", UInt16.MinValue, UInt16.MaxValue);

            //int
            int i = -2147483648;
            int j = 2147483647;
            //  int k = 4294967295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.

            uint ui1 = 4294967295;
            // uint ui2 = -1; //Compile-time error: Constant value '-1' cannot be converted to a 'uint'

            Console.WriteLine("\nInt:");
            Console.WriteLine("Min={0} , Max={1}", Int32.MinValue, Int32.MaxValue);

            Console.WriteLine("\nUInt:");
            Console.WriteLine("Min={0} , Max={1}", UInt32.MinValue, UInt32.MaxValue);

            //Long
            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;

            ulong ul1 = 18223372036854775808ul;
            ulong ul2 = 18223372036854775808UL;

            Console.WriteLine("\nLong:");
            Console.WriteLine("Min={0} , Max={1}", Int64.MinValue, Int64.MaxValue);

            Console.WriteLine("\nULong:");
            Console.WriteLine("Min={0} , Max={1}", UInt64.MinValue, UInt64.MaxValue);


            //Float
            float f1 = 123456.5F;
            float f2 = 1.123456f;

            Console.WriteLine("\nFloat:");
            Console.WriteLine("Min={0} , Max={1}", float.MinValue, float.MaxValue);


            //double
            double d1 = 12345678912345.5d;
            double d2 = 1.123456789123456d;

            Console.WriteLine("\nDouble:");
            Console.WriteLine("Min={0} , Max={1}", double.MinValue, double.MaxValue);


            //Decimal
            //The decimal type has more precision and a smaller range
            //than both float and double,
            //and so it is appropriate for financial and monetary calculations.
            decimal d3 = 123456789123456789123456789.5m;
            decimal d4 = 1.1234567891345679123456789123m;

            Console.WriteLine("\nDecimal:");
            Console.WriteLine("Min={0} , Max={1}", decimal.MinValue, decimal.MaxValue);


            //Scientific Notation
            //Use e or E to indicate the power of 10 
            //as exponent part of scientific notation with float, double or decimal.

            double d = 0.12e2;
            Console.WriteLine(d);  // 12;

            float f = 123.45e-2f;
            Console.WriteLine(f);  // 1.2345

            decimal m = 1.2e6m;
            Console.WriteLine(m);  // 1200000

            //hex & Binary
            int hex = 0x2F;
            int binary = 0b_0010_1111;

            Console.WriteLine(hex);
            Console.WriteLine(binary);


            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

        }

        public static void DefaultValues()
        {

            Console.WriteLine("\n::::::::::::::::::::::DefaultValues::::::::::::::::::::::");

            //get default value using default(type)
            int i = default(int); // 0
            float f = default(float);// 0
            decimal d = default(decimal);// 0
            bool b = default(bool);// false
            char c = default(char);// '\0'

            // C# 7.1 onwards
            //get default value using default
            int i2 = default; // 0
            float f2 = default;// 0
            decimal d2 = default;// 0
            bool b2 = default;// false
            char c2 = default;// '\0'

            Console.WriteLine("i = {0}, f = {1}, d = {2}, b = {3}, c = {4}", i, f, d, b, c);
            Console.WriteLine("i2 = {0}, f2 = {1}, d2 = {2}, b2 = {3}, c2 = {4}", i2, f2, d2, b2, c2);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

        }

        //Enums
        enum enWeekDays
        {
            Monday,     // 0
            Tuesday,    // 1
            Wednesday,  // 2
            Thursday,   // 3
            Friday,     // 4
            Saturday,   // 5
            Sunday      // 6
        }

        //if you set a value , it will auto number everything after it.
        enum enCategories
        {
            Electronics,    // 0
            Food,           // 1
            Automotive = 6, // 6
            Arts,           // 7
            BeautyCare,     // 8
            Fashion         // 9
        }

        //Enum can have any numarical data type byte, sbyte, short, ushort, int, uint, long, or ulong
        //but not string
        enum enCategories2 : byte
        {
            Electronics = 1,
            Food = 5,
            Automotive = 6,
            Arts = 10,
            BeautyCare = 11,
            Fashion = 15
        }

        public static void Enum()
        {

            Console.WriteLine("\n::::::::::::::::::::::::::Enums::::::::::::::::::::::::::");

            enWeekDays WeekDays = enWeekDays.Friday;
            Console.WriteLine(WeekDays);
            Console.WriteLine("Friday's order is {0}", (int)enWeekDays.Friday);

            enCategories Categories = enCategories.Arts;
            Console.WriteLine(Categories);

            enCategories2 Categories2 = enCategories2.BeautyCare;
            Console.WriteLine(Categories2);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

        }

        public static void NullableTypes()
        {

            Console.WriteLine("\n::::::::::::::::::::::NullableTypes::::::::::::::::::::::");

            //  Nullable<int> can be assigned any value
            //  from -2147483648 to 2147483647, or a null value.

            Nullable<int> i = null;
            Console.WriteLine("null int: {0}",i);

            string s = null;
            Console.WriteLine("null string: {0}", s);

            /*
             * Integral types (e.g., int, long, short, byte, uint, ulong, ushort, sbyte)
             * Floating-point types (e.g., float, double)
             * Decimal type (decimal)
             * Boolean type (bool)
             * Character type (char)
             * Structs (custom value types)
             * Reference types like string, object, or any class types cannot be used with Nullable<T>.
               They are inherently nullable without needing the Nullable<T> wrapper.
             */

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::");


        }

        public static void AnonymousType()
        {
            Console.WriteLine("\n::::::::::::::::::::::AnonymousType::::::::::::::::::::::");

            //you dont specify any type here , automatically will be specified
            var student = new { Id = 40, FirstName = "Some", LastName = "One" };

            Console.WriteLine("\nExample1:\n");
            Console.WriteLine(student.Id); 
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName); 

            //You can print like this:
            Console.WriteLine(student);

            //anonymous types are read-only
            //you cannot change the values of properties as they are read-only.

            // student.Id = 4;//Error: cannot change value
            // student.FirstName = "Lila";//Error: cannot change value

            //An anonymous type's property can include another anonymous type.
            var student2 = new
            {
                Id = 20,
                FirstName = "Another",
                LastName = "One",
                Address = new { Id = 1, City = "Egypt", Country = "Ciro" }
            };

            Console.WriteLine("\nExample2:\n");
            Console.WriteLine(student2.Id);
            Console.WriteLine(student2.FirstName);
            Console.WriteLine(student2.LastName);

            Console.WriteLine(student2.Address.Id);
            Console.WriteLine(student2.Address.City);
            Console.WriteLine(student2.Address.Country);
            Console.WriteLine(student2.Address);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

        }

        struct stStudent
        {
            public string FirstName;
            public string LastName;
        }

        public static void Struct()
        {

            Console.WriteLine("\n:::::::::::::::::::::::::Struct :::::::::::::::::::::::::");

            //A struct object can be created with or without the new operator,
            //same as primitive type variables.

            stStudent Student;
            stStudent Student2 = new stStudent();

            Student.FirstName = "Some";
            Student.LastName = "One";
            Console.WriteLine(Student.FirstName);
            Console.WriteLine(Student.LastName);

            Student2.FirstName = "Another";
            Student2.LastName = "One";
            Console.WriteLine(Student2.FirstName);
            Console.WriteLine(Student2.LastName);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

        }


    }
}
