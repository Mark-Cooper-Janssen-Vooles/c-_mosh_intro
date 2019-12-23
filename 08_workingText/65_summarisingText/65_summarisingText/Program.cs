using System;
using System.Collections.Generic;

namespace _65_summarisingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentance = "This is going to be a really really really really long text";
            var summary = StringUtility.SummariseText(sentance);
            Console.WriteLine(summary);
        }
    }
}
