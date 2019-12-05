using System;

namespace _20_typeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 1;
            //int i = b;
            // //works fine:
            //Console.WriteLine(i);

            //----------

            //doesn't work: needs a cast to force, might lose data.
            //int b = 1;
            //byte i = (byte)b;

            //Console.WriteLine(i);

            ////if we make b 1000, a byte can only hold 255.
            //int b = 1000;
            //byte i = (byte)b;

            //Console.WriteLine(i); //prints out "232", because data loss!

            //---------

            //string number = "1234";
            ////int i = (int)number; //says "cannot convert type string to int", means we need to use the convert class or .Parse
            //int i = Convert.ToInt32(number);

            //Console.WriteLine(i);

            //string number = "1234";
            //byte i = Convert.ToByte(number);
            ////a byte does not have enough storage, so dotnet crashes.
            ////need to wrap in try catch block!

            //Console.WriteLine(i);

            //------------------

            //type try and hit tab:
            //{
            //    string number = "1234";
            //    byte i = Convert.ToByte(number);
            //    //a byte does not have enough storage, so dotnet crashes.

            //    Console.WriteLine(i);
            //}
            //catch (Exception ex)
            //{
            //    //if exception happens, this block runs, preventing applicaiton from crashing.

            //    Console.WriteLine("The number could not be converted to a byte.");
            //}


            //----------

            try
            {
                string stringg = "true";
                bool b = Convert.ToBoolean(stringg);

                Console.WriteLine(b);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hmm");
            }

        } 


    }
}
