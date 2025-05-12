using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLevel1
{
    internal class MyDateTime
    {

        public static void SetDateTime()
        {

            Console.WriteLine("\n_______________________SetDateTime_______________________");

            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            //assigns year, month, day
            DateTime dt2 = new DateTime(2023, 12, 31);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2023, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2023, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            DateTime dt5 = DateTime.MinValue; //1/1/0001 12:00:00 AM
            DateTime dt6 = DateTime.MaxValue; //12/31/9999 11:59:59 PM

            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);
            Console.WriteLine(dt5);
            Console.WriteLine(dt6);

            Console.WriteLine("_________________________________________________________");

        }

        public static void CurrentDatetime()
        {

            Console.WriteLine("\n_____________________CurrentDatetime_____________________");

            DateTime dt1 = DateTime.Now;
            Console.WriteLine(dt1);

            Console.WriteLine("_________________________________________________________");

        }

        public static void GetTicks()
        {

            Console.WriteLine("\n__________________________Ticks__________________________");

            //number of 100-nanosecond intervals that have elapsed
            //since January 1, 0001, at 00:00:00.000 in the Gregorian calendar. 

            Console.WriteLine(DateTime.MinValue.Ticks);  //min value of ticks
            Console.WriteLine(DateTime.MaxValue.Ticks); // max value of ticks

            Console.WriteLine("_________________________________________________________");

        }

        public static void DateTimeStaticFields()
        {

            Console.WriteLine("\n_________________DateTime Static Fields__________________");

            DateTime currentDateTime = DateTime.Now;  //returns current date and time
            DateTime todaysDate = DateTime.Today; // returns today's date
            DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time
            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime

            Console.WriteLine("currentDateTime: " + currentDateTime);
            Console.WriteLine("Today: " + todaysDate);
            Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);
            Console.WriteLine("minDateTimeValue: " + minDateTimeValue);
            Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);

            Console.WriteLine("_________________________________________________________");

        }

        public static void GetTimeSpan()
        {
            Console.WriteLine("\n________________________TimeSpan_________________________");

            DateTime dt = new DateTime(2023, 2, 21);

            // Hours, Minutes, Seconds
            TimeSpan ts = new TimeSpan(49, 25, 34);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Seconds);

            //this will add time span to the date.
            DateTime newDate = dt.Add(ts);
            Console.WriteLine(newDate);

            DateTime dt1 = new DateTime(2023, 2, 21);
            DateTime dt2 = new DateTime(2023, 2, 25);

            //Subtraction of two dates results in TimeSpan
            TimeSpan result = dt2.Subtract(dt1);
            Console.WriteLine(result.Days);

            Console.WriteLine("_________________________________________________________");

        }

        public static void Operators()
        {

            Console.WriteLine("\n_______________________Operators_________________________");

            DateTime dt1 = new DateTime(2015, 12, 20);
            DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(dt2 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(dt2 - dt1);  //377.05:10:20
            Console.WriteLine(dt1 == dt2); //False
            Console.WriteLine(dt1 != dt2); //True
            Console.WriteLine(dt1 > dt2);  //False
            Console.WriteLine(dt1 < dt2);  //True
            Console.WriteLine(dt1 >= dt2); //False
            Console.WriteLine(dt1 <= dt2); //True

            Console.WriteLine("_________________________________________________________");

        }

        public static void StringToDateTime()
        {

            Console.WriteLine("\n___________________String To DateTime____________________");

            var str = "6/12/2023";
            DateTime dt;

            var isValidDate = DateTime.TryParse(str, out dt);

            if (isValidDate)
                Console.WriteLine(dt);
            else
                Console.WriteLine($"{str} is not a valid date string");

            //invalid string date
            var str2 = "6/65/2023";
            DateTime dt2;

            var isValidDate2 = DateTime.TryParse(str2, out dt2);

            if (isValidDate2)
                Console.WriteLine(dt2);
            else
                Console.WriteLine($"{str2} is not a valid date string");

            /* 
             
              - Parse(), ParseExact() converts string to DateTime but if it was invalid,
                it will throw an exception error. 
              - TryParse(), TryParseExact() converts string to DateTime but if it was invalid,
                it will return False instead of an error. 
              - So, it's recommended to use TryParse() or TryParseExact().

             */

            Console.WriteLine("_________________________________________________________");

        }


    }
}
