using System;
using _28_classes.Math;

namespace _28_classes
{
    class Program
    {
        //best practice to break classes into their own files:

        //public class Person
        //{
        //    public string firstName;
        //    public string lastName;
        //    public void Introduce()
        //    {
        //        Console.WriteLine($"My name is: {firstName} {lastName}");
        //    }
        //}
        static void Main(string[] args)
        {
            var mark = new Person();
            mark.firstName = "Mark";
            mark.lastName = "Janssen";
            mark.Introduce();


            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 3);
            Console.WriteLine(result);

            //WriteLine method is defined as static! better to use calculator as static in this case too lol.
        }
    }
}
