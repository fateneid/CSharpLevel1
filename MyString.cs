using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLevel1
{
    internal class MyString
    {

        public static void Strings()
        {

            Console.WriteLine("\n_________________________Strings_________________________");

            string S1 = "It's just a random string";

            Console.WriteLine(S1.Length);

            //this will take 5 characters staring position 2
            Console.WriteLine(S1.Substring(2, 5));
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1[2]);
            Console.WriteLine(S1.Insert(19, "La La La La "));
            Console.WriteLine(S1.Replace("m", "*"));
            Console.WriteLine(S1.IndexOf("m"));
            Console.WriteLine(S1.Contains("m"));
            Console.WriteLine(S1.Contains("x"));
            Console.WriteLine(S1.LastIndexOf("m"));

            string S2 = "Person1,Person2,Person3";

            string[] NamesList = S2.Split(',');

            Console.WriteLine(NamesList[0]);
            Console.WriteLine(NamesList[1]);
            Console.WriteLine(NamesList[2]);

            string S3 = "  Something  ";
            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimStart());
            Console.WriteLine(S3.TrimEnd());

            Console.WriteLine("_________________________________________________________");

        }

        public static void StringInterpolation()
        {

            Console.WriteLine("\n__________________String Interpolation___________________");

            string name = "Faten";
            string code = "104";
            string color = "Green";

            //You should use $ to identify an interpolated string 
            string fullName = $"Name: {name}, Code: {code}, Color: {color}";

            Console.WriteLine(fullName);

            Console.WriteLine("_________________________________________________________");

        }


    }
}
