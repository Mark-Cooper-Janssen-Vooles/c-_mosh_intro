using System;

namespace _43_exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1:

            //Console.WriteLine("Please enter a number between 1 and 10.");
            //var answer = int.Parse(Console.ReadLine());

            //if (answer >= 0 && answer <= 10)
            //    Console.WriteLine("Valid");
            //else
            //    Console.WriteLine("Invalid");

            //--------------

            //Question 2:

            //Console.WriteLine("Please enter two numbers");
            //var num1 = int.Parse(Console.ReadLine());
            //var num2 = int.Parse(Console.ReadLine());

            //if(num1 > num2)
            //    Console.WriteLine(num1);
            //else
            //    Console.WriteLine(num2);

            //--------------

            //Question 3:

            //Console.WriteLine("Please enter the width and height of an image");
            //Console.WriteLine("What is the width?");
            //var width = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the height?");
            //var height = int.Parse(Console.ReadLine());

            //if(width > height)
            //    Console.WriteLine("The image is landscape");
            //else if (width == height)
            //    Console.WriteLine("The image is neither");
            //else
            //    Console.WriteLine("The image is portrait");

            //--------------

            //Question 4:

            Console.WriteLine("What is the speed limit?");
            var speedLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("What speed are you going?");
            var currentSpeed = int.Parse(Console.ReadLine());

            var overBy = currentSpeed - speedLimit;
            var demeritPoints = overBy / 5;

            if (currentSpeed < speedLimit
                || demeritPoints == 0)
                Console.WriteLine("OK");
            else if (currentSpeed > speedLimit && demeritPoints < 12)
                Console.WriteLine($"Loss of {demeritPoints} demerit points");
            else
                Console.WriteLine("License suspended.");

        }
    }
}
