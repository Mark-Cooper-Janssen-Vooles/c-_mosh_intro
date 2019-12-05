using System;

namespace _31_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]); //initialized to 0 by default
            Console.WriteLine(numbers[2]); //same as above.

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]); //initialized to false by default
            Console.WriteLine(flags[2]); //same same


            var names = new string[3] { "Jack", "John", "Mary" };

        }
    }
}
