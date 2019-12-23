using System;
using System.Collections.Generic;

namespace _68_textChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st challenge:
            //Console.WriteLine(firstChallenge() );

            //2nd challenge:
            //Console.WriteLine(secondChallenge() );




        }
        static string firstChallenge()
        {
            Console.WriteLine("Enter numbers seperated by a hypen i.e. 3-4-2-1");
            var numbers = Console.ReadLine();

            var numberArray = numbers.Split("-");

            var intList = new List<int>();

            foreach (var item in numberArray)
            {
                intList.Add(Convert.ToInt32(item));
            }


            var truthArray = new List<bool>();

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (i + 1 < numberArray.Length)
                {
                    var truthLogic =
                    (intList[i] == (intList[i + 1] + 1)) ||
                    (intList[i] == (intList[i + 1] - 1));

                    if (truthLogic)
                    {
                        truthArray.Add(true);
                    }
                    else
                    {
                        truthArray.Add(false);
                    }
                }
            }


            if (truthArray.Contains(false))
                return "Not Consecutive";
            else
                return "Consecutive";
        }

        static string secondChallenge()
        {


            Console.WriteLine("Enter numbers seperated by a hypen i.e. 3-4-2-1");
            var numbers = Console.ReadLine();

            if (String.IsNullOrEmpty(numbers))
                return "Exiting program";
            else
            {
                var numbersStringArray = numbers.Split("-");
                var numbersStringList = new List<string>(numbersStringArray);

                var duplicates = false;

                for (int i = 0; i < numbersStringList.Count; i++)
                {
                    var item = numbersStringList[i];

                    //numbersStringList.Remove(item);

                    numbersStringList.RemoveAt(i);

                    if (numbersStringList.Contains(item))
                    {
                        duplicates = true;
                    }
                }

                ////ERRORED: cant remove an item in a foreach loop lol
                //foreach (var item in numbersStringList)
                //{
                //    numbersStringList.Remove(item);

                //    if (numbersStringList.Contains(item))
                //    {
                //        duplicates = true;
                //    }
                //}

                if (duplicates == true)
                {
                    return "Duplicate";
                } else
                {
                    return "No Dpulicates";
                }
            }
        }

    }
}
