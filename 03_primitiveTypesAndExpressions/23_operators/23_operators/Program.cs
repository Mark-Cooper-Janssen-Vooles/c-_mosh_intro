using System;

namespace _23_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = 10;
            //var b = 3;

            //Console.WriteLine(a / b); // 13
            //Console.WriteLine(a / b); // results in 3. to get a decimal, need to cast both of these to a float.
            //Console.WriteLine((float)a / (float)b); //spits out 3.333333


            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(a + b * c); //from maths.. BIMDAS: 3 * 2 = 6 + 1 = 7

            Console.WriteLine((a + b) * c); //to change order use parenthesis = 9

            Console.WriteLine(a > b); //shows false
            Console.WriteLine(a == b ); //false
            Console.WriteLine(a != b); //true
            Console.WriteLine(!(a != b)); //false.. but two negatives is hard to comprehend. not good pracice!

            Console.WriteLine(c > b && c > a); //true
            Console.WriteLine(c > b && c == a ); //false
            Console.WriteLine(a > b || c == a ); //true or false == true
            Console.WriteLine(!(a > b) || c == a); //false



        }
    }
}
