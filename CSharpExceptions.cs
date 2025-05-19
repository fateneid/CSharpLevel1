using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLevel1
{
    internal class CSharpExceptions
    {

        public static void Exceptions()
        {

            Console.WriteLine("\n_______________________Exceptions________________________");

            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("_________________________________________________________");

        }


    }
}
