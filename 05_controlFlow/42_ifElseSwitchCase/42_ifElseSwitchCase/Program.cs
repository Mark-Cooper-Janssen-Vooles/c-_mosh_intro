using System;

namespace _42_ifElseSwitchCase
{
    // below was moved to another file.
    //public enum Season
    //{
    //    Spring = 1,
    //    Summer = 2,
    //    Autumn = 3 ,
    //    Winter = 4
    //}
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.A;

            //switch (season)
            //{
            //    case Season.Autumn:
            //        Console.WriteLine("Its autumn and a beautiful season.");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("Its a perfect time to go to the beach!");
            //        break;
            //    default:
            //        Console.WriteLine("I don't understand that season!");
            //        break;
            //}

            switch (season)
            {
                //because below has duplicate code
                //case Season.Autumn:
                //    Console.WriteLine("We've got a promotion!");
                //    break;
                //case Season.Summer:
                //    Console.WriteLine("We've got a promotion!");
                //    break;

                //can simply do this:
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got a promotion!");
                    break;
                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }

            //--------------------

            //var hour = 10;

            //if (hour > 0 && hour < 12)
            //{
            //    Console.WriteLine("Its morning!");
            //}
            //else if (hour >= 12 && hour < 18)
            //{
            //    Console.WriteLine("Its afternoon!");
            //}
            //else
            //{
            //    Console.WriteLine("Its evening!");
            //}

            //-------------------

            //bool isGoldCustomer = true;
            ////float price;
            ////if (isGoldCustomer)
            ////{
            ////    price = 19.95f;
            ////}
            ////else
            ////{
            ////    price = 29.95f;
            ////}

            //float price = isGoldCustomer ? 19.95f : 29.95f;
            //Console.WriteLine(price);

            //-------------------


        }
    }
}
