using System;

namespace _37_referenceTypesAndValueTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //integers are primitive types, aka value types.
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
            //a will be 10 because when we take a value of one variable and assign it to another variable, a copy of that value is taken and stored in the target location in memory.
            //aka a clone is copied to b (not a reference), the two variables a and b are completely independent.


            //arrays are non-primitive reference types
            var array1 = new int[3] { 1, 2, 3};
            var array2 = array1;
            array2[0] = 0;

            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            //array1[0] is going to be 0. Because they are reference types, the variables just point to an object in the heap. when we copy them, their reference or "memory pointer" is copied, not the actual value.

        }
    }
}
