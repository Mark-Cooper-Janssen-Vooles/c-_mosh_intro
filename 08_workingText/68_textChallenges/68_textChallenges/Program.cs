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

            //3rd challegE:
            //Console.WriteLine(thirdChallenge());

            //4th challenge:
            //Console.WriteLine(fourthChallenge());


            //5th challenge:
            Console.WriteLine("Enter an english word:");
            var aWord = Console.ReadLine().ToLower();

            int numberOfVowels = 0;

            for (int i = 0; i < aWord.Length; i++)
            {

                switch (aWord[i])
                {
                    case 'a':
                        numberOfVowels++;
                        break;
                    case 'e':
                        numberOfVowels++;
                        break;
                    case 'i':
                        numberOfVowels++;
                        break;
                    case 'o':
                        numberOfVowels++;
                        break;
                    case 'u':
                        numberOfVowels++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(numberOfVowels);

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

        static string thirdChallenge()
        {
            Console.WriteLine("Enter a time value in 24 hour time format, i.e. 19:00");

            var time = Console.ReadLine();

            var timeArray = time.Split(":");

            var hours = Convert.ToInt64(timeArray[0]);
            var minutes = Convert.ToInt64(timeArray[1]);

            if ((hours >= 0 && hours <= 24) && (minutes >= 0 && minutes <= 60))
            {
                return "Ok";
            }
            else
            {
                return "Invalid time";
            }

        }

        static string fourthChallenge()
        {
            Console.WriteLine("Enter a few words seperated by a space, i.e. 'number of students'");

            var someString = Console.ReadLine();


            var someArray = someString.Split(" ");
            var someList = new List<string>(someArray);

            for (int i = 0; i < someList.Count; i++)
            {
                someList[i] = someList[i].ToLower();

                someList[i] = char.ToUpper(someList[i][0]) + someList[i].Substring(1);
            }

            //join list
            var finalWord = String.Join("", someList);
            return finalWord;
        }

    }
}
