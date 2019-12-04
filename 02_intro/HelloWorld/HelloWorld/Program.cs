//if we want to use classes defined in a different namespace, we need to import it here.
using System; //system is a namespace in .net framework which gives us access to lots of basic utility classes and primitive types
using System.Collections.Generic; //used to work with collections, lists and so on
using System.Linq; //used to work with data. covered in advanced course.
using System.Text; //used to work with text when coding etc.
using System.Threading.Tasks; //used to build multi-threaded applications.


//when we write code in the namespace "helloworld", we have access to any code defined in that namespace. 
namespace HelloWorld
{
    //every console app you make has program as its default class.
    class Program
    {
        //by default we have a method called main inside program. it is the entry point to the application. CLR executes the code inside main method, where it kicks off.

            //void means the method does not return anything.(no output)
        static void Main(string[] args)
        {//curly braces mean "block of code".
            Console.WriteLine("Hello World!");
        }
    }
}
