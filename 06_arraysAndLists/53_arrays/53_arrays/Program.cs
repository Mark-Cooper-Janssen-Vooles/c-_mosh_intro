using System;

namespace _53_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 8, 2, 14, 6 };

            //length
            Console.WriteLine("Length: " + numbers.Length);

            //indexOf
            //method called on the class itself, means its a STATIC method!
            var index = Array.IndexOf(numbers, 3);
            Console.WriteLine("Index of 3: " + index);
            //if number doesn't exist in array, it returns -1.

            //clear
            Array.Clear(numbers, 0, 2);
            //starts at zero and clears the two behind it?!
            Console.WriteLine("Effect of Clear(): ");
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            //copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            //first arg array to copy from
            //2nd arg array to copy into
            //3rd arg, how many to copy
            Console.WriteLine("Effect of Copy(): ");
            foreach(var n in another)
            {
                Console.WriteLine(n);
            }

            //sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort: ");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }
            //orders it from smallest to largest!

            //reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse(): ");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }
            //orders from largest to smallest!

        }
    }
}
