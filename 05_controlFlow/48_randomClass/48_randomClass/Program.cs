using System;

namespace _48_randomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //we use this class to generate random numbers.

            var random = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    //Console.WriteLine(random.Next()); //huge number!

            //    Console.WriteLine(random.Next(1, 10)); //random number between 1 and 10.
            //}


            //computers don't understand characters, they understand numbers.
            //Console.WriteLine((int)'a'); //i.e. this shows the ASCII code.


            //for (int i = 0; i < 10; i++)
            //{
            //    //cast ascii numbers to a character!
            //    //Console.Write((char)random.Next(97, 122));

            //    //could also do:
            //    Console.Write((char)('a' + random.Next(0, 24)));
            //}


            
            const int passwordLength = 10;
            var buffer = new char[passwordLength];

            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 24));
            }

            var password = new String(buffer);

            Console.WriteLine(password);

        }
    }
}
