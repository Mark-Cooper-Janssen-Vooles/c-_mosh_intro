using System;
namespace _65_summarisingText
{
    public class StringUtility
    {
        //this method has to be static because our main method is static. in order to call this from the main method, it has to be static as well. 
        public static string SummariseText(string text, int maxLength = 20)
        {
            //const int maxLength = 20;

            if (text.Length < maxLength)
                return text;
            else
            {
                var words = text.Split(' ');
                var totalCharacters = 0;

                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }

                var summary = String.Join(' ', summaryWords) + "...";
                return summary;
            }
        }
    }
}
