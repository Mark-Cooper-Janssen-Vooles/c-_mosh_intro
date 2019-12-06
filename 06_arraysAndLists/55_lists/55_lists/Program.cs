using System;
using System.Collections.Generic;

namespace _55_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            //in an array we don't have an add method.
            //in a list you can add as many as you'd like
            numbers.AddRange(new int[3] { 5, 6, 7 });
            //says "IEnumerable<int>
            //whenever you see something prefixed with I, that means interface. Covered in the 2nd part of the course.
            // basically whenever you see I for now, you can use an array or a list there.
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            Console.WriteLine(numbers.IndexOf(1)); //returns 0 (the index of the first 1)
            Console.WriteLine(numbers.LastIndexOf(1)); //returns 4 (the index of the last 1)


            Console.WriteLine("Count: " + numbers.Count); //returns number of objects in the list. currently 8

            //numbers.Remove(1); //note this removes the first 1 it finds and only that one.
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //to remove all the 1's:
            //foreach (var number in numbers)
            //{
            //    if(number == 1)
            //    {
            //        numbers.Remove(number);
            //    }
            //    //when removing an object from a list inside a for each block, may get an unhandled exception.

            //    //in c# we are not allowed to modify a collection inside a foreach loop.
            //    //need to use a normal for loop instead (wtf lol)
            //}

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var number in numbers)
                Console.WriteLine(number);

            //remove all elements from the list:
           
            numbers.Clear();
            Console.WriteLine("total after .Clear(): " + numbers.Count);
        }
    }
}
