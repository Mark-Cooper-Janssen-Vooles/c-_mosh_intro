using System;

namespace _18_variablesAndConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte number = 2;
            //int count = 10;
            //float totalPrice = 20.95f;
            ////note in c# we declare characters in single quotes:
            //char character = 'A';
            ////strings enclosed in double quotes:
            //string firstName = "Mark";
            //bool isWorking = true;

            //         //everything that is blue is a keyword.

            //Console.WriteLine(number);
            //         //shortcut: cw + tab;
            //         Console.WriteLine(count);
            //         Console.WriteLine(totalPrice);
            //         Console.WriteLine(character);
            //         Console.WriteLine(firstName);
            //         Console.WriteLine(isWorking);



            //in c# we have a keyword called var, which makes variable declerations easier. instead of typing byte or int etc, can use var.
            //lets c# compiler detect the data type.
            //can hover over the var to see what type compiler will treat it as.

            ////number is treated differently, as an int and not as a byte. have to be explicit if you really want a byte. 
            //var number = 2;
            //var count = 10;
            //var totalPrice = 20.95f;
            ////note in c# we declare characters in single quotes:
            //var character = 'A';
            ////strings enclosed in double quotes:
            //var firstName = "Mark";
            //var isWorking = true;

            ////everything that is blue is a keyword.

            //Console.WriteLine(number);
            ////shortcut: cw + tab;
            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(firstName);
            //Console.WriteLine(isWorking);

            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            //Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;
            //cannot do: (because its a constant)
            //Pi = 1;

        }
    }
}
