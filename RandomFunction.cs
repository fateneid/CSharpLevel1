using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLevel1
{
    internal class RandomFunction
    {


        public static void RandomNumberFunction()
        {

            Console.WriteLine("\n_________________Random Number Function__________________");


            Random rnd = new Random();

            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(rnd.Next(10, 20)); // returns random integers >= 10 and < 20
            }


            Console.WriteLine("_________________________________________________________");

        }


    }
}
