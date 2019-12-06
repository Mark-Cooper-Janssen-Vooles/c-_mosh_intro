using System;

namespace _49_exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1:

            //var counter = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //        counter++;
            //}
            //Console.WriteLine(counter);


            //-------------------


            //Question 2:

            //var totalNumbers = 0;

            //while (true)
            //{
            //    Console.WriteLine("Please enter a number of 'ok' to exit: ");
            //    var response = Console.ReadLine();

            //    if (response == "ok")
            //        break;
            //    else
            //        totalNumbers += int.Parse(response);
            //}

            //Console.WriteLine(totalNumbers);


            //---------------------


            //Question 3:


            //Console.WriteLine("Please enter a number.");
            //var numOriginal = int.Parse(Console.ReadLine());

            //var timesBy = numOriginal;
            //var totalNum = 0;

            //for (int i = timesBy; i >= 1; i--)
            //{
            //    var calculation = (timesBy * timesBy - 1);
            //    totalNum += calculation;

            //    Console.WriteLine(totalNum);
            //}

            //Console.WriteLine($"!{numOriginal} = {totalNum}");



            //----------------------


            //Question 4:

            //var number = new Random();
            //var secretNumber = number.Next(1, 10);

            //Console.WriteLine("Secret number: " + secretNumber);

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Take a guess at the number between 1 and 10");
            //    var guess = int.Parse(Console.ReadLine());

            //    if(guess == secretNumber)
            //    {
            //        Console.WriteLine("Congratulations, you won!");
            //        break;
            //    }
            //}

            //----------------------


            //Question 5:

            Console.WriteLine("Enter a series of numbers seperated by a comma: ");
            var numbers = Console.ReadLine();
            var highestNumber = 0;
            Console.WriteLine(highestNumber);

            for (int i = 0; i < numbers.Length; i+= 2)
            {
                var currentNumber = int.Parse((numbers[i].ToString()));

                Console.WriteLine(currentNumber);

                if (currentNumber > highestNumber)
                    highestNumber = currentNumber;
            }

            Console.WriteLine(highestNumber);
        }
    }
}
