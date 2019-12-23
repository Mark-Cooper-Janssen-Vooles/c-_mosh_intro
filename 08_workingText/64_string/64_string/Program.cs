using System;

namespace _64_string
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Mark Janssen ";
            Console.WriteLine($"Trim: '{fullName.Trim()}'"); //removes white space from the end of the name.
            Console.WriteLine($"ToUpper: '{fullName.ToUpper()}'");
            //strings are immutable. I.e. each method on the string class returns a new string, it does not modify the original string.

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            //easier way using the split method:

            var names = fullName.Split(' ');
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);

            var newName = fullName.Replace("Mark", "Marcos");

            Console.WriteLine(newName);

            if (String.IsNullOrEmpty(" ")) //wont display. newer method introduced is down below 
                Console.WriteLine("Invalid");

            if(String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid null/white space");

            var str = "25";
            var age = Convert.ToInt32(str); //or .ToByte since noone can be older than 255 years old
            Console.WriteLine(age);

            float price = 29.95f;
            price.ToString(); //every object in c# has a .ToString method.
            //can call without argument, and simply returns a string display of this number. but if we want to format it as currency ...

            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0")); //rounds it to $30
            Console.WriteLine(price.ToString("C1")); //rounds to $30
        }
    }
}
