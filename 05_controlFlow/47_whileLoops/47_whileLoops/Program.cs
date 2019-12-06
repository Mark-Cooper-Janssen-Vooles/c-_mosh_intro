using System;

namespace _47_whileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //var i = 0;

            //while (i <= 10)
            //{
            //    if(i % 2 == 0)
            //        Console.WriteLine(i);

            //    //mosh prefers a for loop, because this being inside is messy.
            //    //typically its better to use a while loop when you don't know ahead of time how many times you'll do an iteration.
            //    i++;
            //}

            //i.e:

            //using break:
            //while (true)
            //{
            //    Console.Write("Type your name: ");
            //    var input = Console.ReadLine();

            //    if (String.IsNullOrWhiteSpace(input))
            //        break; //jumps out of loop.

            //    Console.WriteLine("Echo: " + input );
            //}

            //using continue:
            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Echo: " + input);
                    continue; //when program sees this, it will continue back to the beginning of the loop.
                }
                    

                break;
            }

            //no right or wrong.. just use your own judgement as to what is more readable / understandable (i prefer jus the break!!)


        }
    }
}
