using System;

namespace _35_enums_vs
{
    //since enum is a new type, it needs to be defined at the namespace level.
    public enum ShippingMethod
    {
        //if we don't set a value, the first one will be set to 0 and incremented by 1 to there.
        //best practice always set values!!
        //RegularAirMail,
        //RegisteredAirMail,
        //Express

        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            //cast enum to int to display.
            Console.WriteLine((int)method);

            //can also go the other way! cast it to shipping method.
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            //convert enum to string:
            //every object in c# has a method called ToString. Technically you can convert anything to a string without doing any extra work. 
            Console.WriteLine(method.ToString());

            //be default, Console.WriteLine alwas calls the ToString method on anything you pass to it!
            Console.WriteLine(method);

            //if you have a string and want to convert it to an enum..:
            var aString = "Express";
            //Console.WriteLine((ShippingMethod)aString); //wont work! need to parse!

            //as a pragmtic tip, whenever you see the type object, you can use the 'type of' operator.
            //Enum.Parse(typeof(ShippingMethod), aString); //this returns an object, so need to cast to ...
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), aString);
            // ^ this is how you cast a string to an enum!
        }


    }
}
