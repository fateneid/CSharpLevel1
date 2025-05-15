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
                Console.WriteLine("Element in index " + i + ": " + numbers[i]);
            }

            Console.WriteLine("_________________________________________________________");

        }


    }
}
