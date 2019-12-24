using System;
using System.IO;

namespace _75_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            var somePath = @"/users/mark/test/hello_cli.txt";

            //low level processing:
            var dotIndex = somePath.IndexOf('.');
            var extension = somePath.Substring(dotIndex);

            //can instead use a method:
            var theExtension = Path.GetExtension(somePath);
            Console.WriteLine(theExtension);

            Console.WriteLine("File name: " + Path.GetFileName(somePath));
            Console.WriteLine("File name without Extension: " + Path.GetFileNameWithoutExtension(somePath));

            Console.WriteLine("File directory name: " + Path.GetDirectoryName(somePath));
        }
    }
}
