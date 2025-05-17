using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLevel1
{
    internal class Arrays
    {

        public static void ArraysAreBound()
        {

            Console.WriteLine("\n____________________Arrays Are Bound_____________________");

            int[] nums = { 1, 2, 3 };
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            //ints[3] = 4;  //error because of trying to exceed the length of the array.

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }

            Console.WriteLine("\n_________________________________________________________");

        }

        public static void ArrayDeclaration()
        {

            Console.WriteLine("\n____________________Array Declaration____________________");

            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine("Element at index " + i + ": " + numbers[i]);
            }

            Console.WriteLine("_________________________________________________________");

        }

        public static void AccessArrayElements()
        {

            Console.WriteLine("\n__________________Access Array Elements__________________");

            //create an array
            int[] numbers = { 1, 2, 3 };

            //access first element
            Console.WriteLine("Element at first index : " + numbers[0]);

            //access second element
            Console.WriteLine("Element at second index : " + numbers[1]);

            //access third element
            Console.WriteLine("Element at third index : " + numbers[2]);

            //through loop
            Console.WriteLine("\nAccess array using loop:\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element at index {0} : {1} ", i, numbers[i]);
            }

            Console.WriteLine("_________________________________________________________");

        }

        public static void TwoDimensionalArray()
        {

            Console.WriteLine("\n___________________2 Dimensional Array___________________");

            //initializing 2D array
            int[ , ] numbers = { { 12, 13 }, { 55, 77 } };
            // or int [ , ] numbers = new int[2, 2] { { 12, 13 }, { 55, 77 } };

            // access first element from the first row
            Console.WriteLine("Element at index [0, 0] : " + numbers[0, 0]);

            // access first element from second row
            Console.WriteLine("Element at index [1, 0] : " + numbers[1, 0]);

            Console.WriteLine("Length of Rows: {0}", numbers.GetLength(0));
            Console.WriteLine("Length of Columns: {0}", numbers.GetLength(1));

            Console.WriteLine("_________________________________________________________");

        }

        public static void ForeachLoop()
        {

            Console.WriteLine("\n______________________foreach loop_______________________");

            Console.WriteLine("Example 1:");

            char[] myArray = { 'H', 'e', 'l', 'l', 'o' };

            foreach (char ch in myArray)
            {
                Console.WriteLine(ch);
            }


            Console.WriteLine("\nExample 2:");

            char[] gender = { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
            int male = 0, female = 0;
            foreach (char g in gender)
            {
                if (g == 'm')
                    male++;
                else if (g == 'f')
                    female++;
            }
            Console.WriteLine("Number of male = {0}", male);
            Console.WriteLine("Number of female = {0}", female);

            Console.WriteLine("_________________________________________________________");

        }

        public static void ArrayOperationsUsingSystemLinq()
        {

            Console.WriteLine("\n___________Array Operations using System.Linq____________");

            //Note that we used System.Linq above. 
            //provides us various methods to use in an array

            int[] numbers = { 51, -1, 2, 14, 18, 40, 178 };

            // get the minimum element
            Console.WriteLine("Smallest  Element: " + numbers.Min());

            // Max() returns the largest number in array
            Console.WriteLine("Largest Element: " + numbers.Max());

            // compute Count
            Console.WriteLine("Count : " + numbers.Count());

            // compute Sum
            Console.WriteLine("Sum : " + numbers.Sum());

            // compute the average
            Console.WriteLine("Average: " + numbers.Average());

            Console.WriteLine("_________________________________________________________");

        }


    }
}
