using System;

namespace _60_timeSpan
{
    class Program
    {
        static void Main(string[] args)
        {

            //CREATING TIMESPAN OBJECTS:

            //timespan represents a length of time
            var timeSpan = new TimeSpan(1, 2, 3);
            //this overload takes in 3 arguments, hours minutes seconds

            var timeSpan2 = new TimeSpan(1, 0, 0);

            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan2);

            //another way to create a timespan: 
            var timeSpan3 = TimeSpan.FromHours(1);

            Console.WriteLine(timeSpan3);

            //3rd way to create a timespan:
            //if you subtract two datetime objects, the result is a timespan.
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            var duration = end - start;
            Console.WriteLine(duration);

            //READING TIMESPAN PROPERTIES:
            Console.WriteLine("Minutes: " + timeSpan.Minutes); //returns minutes component of timespan object (i.e. 2 in this example, line 13)
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); //converts total timespan into minutes, i.e. 60 + 2 + 0.3

            //ADD TIMESPAN
            //similar to datetime, the timespan is immutable .. once you create it, you cannot change it.
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); //added 8 minutes to original timespan

            //SUBTRACT TIMESPAN
            Console.WriteLine("Subtract: " + timeSpan.Add(TimeSpan.FromMinutes(2)));

            //Conversion too and from strings:
            //simply call the ToString() method
            Console.WriteLine("To String:" + timeSpan.ToString());

            //to convert from string to timespan:
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
