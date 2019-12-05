using System;

namespace _33_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            ////hover over int and note that all primitive types are structures
            //int number;

            ////strings are classes! 
            //var firstName = "Mark";
            ////you can do something like this: (string keyword)
            //string lastName = "Janssen";
            ////or: (string class)
            //String lastName2 = "Janssen2";

            ////(below is also the same thing):
            //Int32 i;
            //int i2;


            var firstName = "Mark";
            var lastName = "Janssen";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Luke", "Nancy" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            //verbatim strings:
            var text = "Hi John,\nLook into the following paths:\nC:\\folder1\\folder2";
            Console.WriteLine(text);

            //with @prefix
            var text2 = @"Hi John,
                        Look into the following paths:
                        C:\folder1\folder2";
            Console.WriteLine(text2);

        }
    }
}
