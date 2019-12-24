using System;
using System.IO;

namespace _76_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText(@"/users/mark/test/hello_cli.txt");

            //challenge 1:
            var wordArray = text.Split(" ");
            Console.WriteLine( wordArray.Length );

            var longestWord = "";
            foreach (var word in wordArray)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine(longestWord);
        }
    }
}
