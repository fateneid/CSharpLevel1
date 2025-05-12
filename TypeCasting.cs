using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLevel1
{
    internal class TypeCasting
    {

        public static void ImplicitCasting()
        {

            Console.WriteLine("\n____________________Implicit Casting_____________________");

            //Implicit casting is done automatically
            //when passing a smaller size type to a larger size type

            int myInt = 17;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 17
            Console.WriteLine(myDouble);   // Outputs 17

            Console.WriteLine("_________________________________________________________");

        }

        public static void ExplicitCasting()
        {

            Console.WriteLine("\n____________________Explicit Casting_____________________");

            //Explicit casting must be done manually
            //by placing the type in parentheses in front of the value.

            double myDouble = 17.58;
            int myInt = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble);   // Outputs 17.58
            Console.WriteLine(myInt);      // Outputs 17

            Console.WriteLine("_________________________________________________________");

        }

        public static void TypeConversionMethods()
        {

            Console.WriteLine("\n_________________Type Conversion Methods_________________");

            //It is also possible to convert data types explicitly by using built-in methods,
            //such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString,
            //Convert.ToInt32(int) and Convert.ToInt64(long)

            int myInt = 20;
            double myDouble = 7.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            Console.WriteLine(Convert.ToInt32(myBool));    // convert bool to int

            Console.WriteLine("_________________________________________________________");

        }

        enum enWeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public static void EnumsConversion()
        {

            Console.WriteLine("\n____________________Enums Conversion_____________________");

            Console.WriteLine(enWeekDays.Friday); //output: Friday 
            int day = (int)enWeekDays.Friday; //enum to int conversion
            Console.WriteLine(day); //output: 4 

            var wd = (enWeekDays)5; //int to enum conversion
            Console.WriteLine(wd); //output: Saturday 

            Console.WriteLine("_________________________________________________________");

        }


    }
}
