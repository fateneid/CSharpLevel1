using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLevel1
{
    internal class UserInput
    {

        public static void GetUserInput()
        {

            Console.WriteLine("\n________________________ReadLine_________________________");

            Console.WriteLine("Enter username?");

            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);

            Console.WriteLine("_________________________________________________________");

        }

        public static void GetUserInputNumbers()
        {

            Console.WriteLine("\n__________________ReadLine and Numbers___________________");

            Console.WriteLine("Enter your age?");

            //if you dont convert you will get error, and if you enter string you will get error
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            Console.WriteLine("_________________________________________________________");

        }


    }
}
