using System;

namespace _46_foreachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //with for loop.. harder!

            var name = "Mark Janssen";

            //for(var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //-----------------

            foreach(var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[4] { 1, 2, 3, 4 };

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }


        }
    }
}
