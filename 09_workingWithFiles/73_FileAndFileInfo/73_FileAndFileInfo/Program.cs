using System;
using System.IO;

namespace _73_FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c\somefile.jpg";
            //first agument: what to copy
            //2nd argument: where to copy to
            //3rd argument: if it exists, to override 
            File.Copy(@"C:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);

            //delete this file at a specified path
            File.Delete(path);


            //takes a path and returns are boolean
            if (File.Exists(path))
            {
                //do something
            }

            //returns a string
            var content = File.ReadAllText(path);


            //using FileInfo instance: 
            var fileInfoVar = new FileInfo(path);

            //takes a path to copy it into:
            fileInfoVar.CopyTo(@"d\anotherfile\myfile.jpg");

            fileInfoVar.Delete(); //no params
            if (fileInfoVar.Exists) //.exists is not a method but a property in this instance
            {
                //do something
            }

            fileInfoVar.OpenRead(); //openread a different way of reading the file. Not recommended! 
        }
    }
}
