using System;
using System.IO;

namespace _74_directoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //takes a path as argument
            Directory.CreateDirectory(@"/users/mark/testing_c#");

            //takes path, search pattern, and another method that resharper should provide 
            var files = Directory.GetFiles(@"/users/mark/c#_mosh_beginner", "*.*", SearchOption.AllDirectories);
            //in this case the search pattern is "all files". * before the . means the file name, and * after the . means the file type. Could also do something like "*.jpg"
            //will return an array
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            //will print all files and all files in every subdirectory starting from c:\projects\csharp

            //var directories = Directory.GetDirectories(@"c:\projects\csharp");

            Directory.Exists("...path");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories(//takes search pattern and search option);

        }
    }
}
