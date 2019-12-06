using System;
using System.Collections.Generic;

namespace _56_exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1:


            //var nameList = new List<string>();

            //while (true)
            //{
            //    Console.WriteLine("Please enter a name.");
            //    var name = Console.ReadLine();

            //    if (String.IsNullOrEmpty(name))
            //    {
            //        break;
            //    }

            //    nameList.Add(name);
            //}

            //if(nameList.Count == 1)
            //{
            //    Console.WriteLine($"{nameList[0]} likes your post.");
            //}
            //else if(nameList.Count > 1 && nameList.Count < 3)
            //{
            //    Console.WriteLine($"{nameList[0]} and {nameList[1]} like your post.");
            //}
            //else if(nameList.Count > 2)
            //{
            //    Console.WriteLine($"{nameList[0]}, {nameList[1]} and {nameList.Count - 2} others like your post.");
            //}


            //-------------

            //Question 2:


            //Console.WriteLine("Please enter your name.");
            //var name = Console.ReadLine();

            //string[] nameReversedArray = new String[name.Length];

            //for (int i = 0; i < name.Length; i++)
            //{
            //    nameReversedArray[i] = name[i].ToString();
            //}

            //Array.Reverse(nameReversedArray);
            //var reversedName = String.Join("", nameReversedArray);


            //Console.WriteLine(reversedName);


            //-------------------


            //Question 3:

            //var numberList = new List<int>();

            //for (int i = 0; i < 5; i++)
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("Please enter a number.");
            //        var num = int.Parse(Console.ReadLine());

            //        if (numberList.Contains(num))
            //        {
            //            Console.WriteLine("That number already exists, please enter a different one.");
            //        } else
            //        {
            //            numberList.Add(num);
            //            break;
            //        }
            //    }
            //}

            //numberList.Sort();
            //Console.WriteLine();
            //foreach(var number in numberList)
            //{
            //    Console.WriteLine(number);
            //}


            //------------


            //Question 4:

            //var list = new List<int>();

            //while (true)
            //{
            //    Console.WriteLine("Please enter a number or type 'Quit' to exit.");
            //    var input = Console.ReadLine();

            //    if (input == "Quit")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        if (!list.Contains(int.Parse(input)))
            //            list.Add(int.Parse(input));
            //    }
            //}

            //foreach(var num in list)
            //    Console.WriteLine(num);


            //-------------------


            //Question 5:

            while(true)
            {
                Console.WriteLine("Please enter a list of comma seperated numbers of 5 or more");
                var input = Console.ReadLine();

                if (input.Length < 9)
                    Console.WriteLine("Invalid list. Please add 5 or more numbers.");
                else
                {
                    //display 3 smallest numbers in list

                    //create array
                    var stringList = input.Split(",");
                    var numberList = new List<int>();

                    foreach(var string1 in stringList)
                    {
                        numberList.Add(int.Parse(string1));
                    }

                    numberList.Sort();

                    Console.WriteLine(numberList[0] + " " + numberList[1] + " " + numberList[2]);
                }

            }


        }
    }
}
