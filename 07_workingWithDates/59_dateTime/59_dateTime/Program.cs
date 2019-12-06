using System;

namespace _59_dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //dateTime is defined in the system namespace
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now; //a static property of dateTime structure.
            var today = DateTime.Today; //if you just want todays date, irrespective of the time

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            //date time objects in c# are immutable, aka once you create them... you cannot change them. So how do you modify them?

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            //a datetime object has a bunch of methods for converting it to a date or time string.

            Console.WriteLine(now.ToLongDateString()); //returns "Friday, 6th of december 2019"
            Console.WriteLine(now.ToShortDateString()); //returns "6/12/19"

            Console.WriteLine();

            Console.WriteLine(now.ToLongTimeString()); //returns "4:18:25 pm"
            Console.WriteLine(now.ToShortTimeString()); //returns "4:18 pm"


            //to display both date AND time:
            Console.WriteLine(now.ToString());
            //with format specifier
            Console.WriteLine(now.ToString("yyyy-MM-dd HH-mm"));
        }
    }
}
