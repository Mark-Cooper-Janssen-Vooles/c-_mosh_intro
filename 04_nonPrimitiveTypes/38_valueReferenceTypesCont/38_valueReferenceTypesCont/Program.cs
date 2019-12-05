using System;

namespace _38_valueReferenceTypesCont
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //value type
            var number = 1;
            Increment(number);
            Console.WriteLine(number); //outputs 1.

            //reference type
            var mark = new Person();
            mark.Age = 28;
            MakeOld(mark);
            Console.WriteLine(mark.Age); //should output 38?!
        }

        public static void Increment(int number)
        {
            number += 10;
            //new number is incremented by 10 and then destroyed straight away, since this is a value type and this method is void so doesn't return anything!
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
