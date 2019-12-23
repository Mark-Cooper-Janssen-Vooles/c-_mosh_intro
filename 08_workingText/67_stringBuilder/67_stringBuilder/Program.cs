using System;
using System.Text;

namespace _67_stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //var builder = new StringBuilder(); //you can specify a starting string but this is optional.
            //var builder = new StringBuilder("Hello World");
            //builder.Append('-', 10); //appends the character "-" 10 times
            //builder.AppendLine(); //breaks into a new line
            //builder.Append("Header"); //appends the word header
            //builder.AppendLine();
            //builder.Append('-', 10);

            //builder.Replace('-', '+'); //replaces all '-' with '+'

            //builder.Remove(0, 10); //removes the first 10 characters

            //builder.Insert(0, new string('-', 10)); //starts at index 0 and adds 10 "-"'s 

            //Console.WriteLine(builder);


            //a stringbuilder returns a string builder. so we can chain all our methods together to make the code cleaner.

            var builder = new StringBuilder("Hello World");
            builder.Append('-', 10)
                    .AppendLine()
                    .Append("Header")
                    .AppendLine()
                    .Append('-', 10)
                    .Replace('-', '+')
                    .Remove(0, 10)
                    .Insert(0, new string('-', 10));

            Console.WriteLine(builder);



            //the important thing to remember is that searching a string builder will be difficult. no inbuilt methods


            ///can display characters etc like this though:
            ///
            Console.WriteLine(builder[0]);

        }
    }
}
