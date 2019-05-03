using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WCLibrary_M
{
    public class InputTextFile : IInputFile
    {
        public InputTextFile(string url)  {
            FileUrl = url;
        }
        public List<string> Words { get; set; } 
            = new List<string>();
        public Dictionary<string, int> WordCount { get; set; } 
            = new Dictionary<string, int>();  
        public string FileUrl
        { get; set; }

        public void CountWords()
        {
            //creates dictionary <string, int> to store words and their counts
            foreach (var word in Words)
            {
                if (!WordCount.ContainsKey(word.ToString().Trim()))
                {
                    WordCount.Add(word, 1);
                }
                else
                {
                    WordCount[word] += 1;
                }
            }
        }

        public string ExtractTextFromUrl()
        {
            //extract text from url .txt file
            return "Contrary to popular" +
                " belief, Lorem Ipsum is" +
                " not simply random text." +
                " It has roots in a piece of " +
                "classical Latin literature from " +
                "45 BC, making it over 2000 years " +
                "old. Richard McClintock, a Latin " +
                "professor at Hampden-Sydney College " +
                "in Virginia, looked up one of the more" +
                " obscure Latin words, consectetur, from a Lorem " +
                "Ipsum passage, and going through the cites " +
                "of the word in classical literature, discovered " +
                "the undoubtable source. Lorem Ipsum comes from sections " +
                "1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum" +
                " (The Extremes of Good and Evil) by Cicero, written in 45 " +
                "BC. This book is a treatise on the theory of ethics, very " +
                "popular during the Renaissance. The first line of Lorem Ipsum, " +
                "Lorem ipsum dolor sit amet.., comes from a line in section 1.10.32." +
                "The standard chunk of Lorem Ipsum used since the 1500s is reproduced " +
                "below for those interested. Sections 1.10.32 and 1.10.33 from " +
                "de Finibus Bonorum et Malorum by Cicero are also reproduced in " +
                "their exact original form, accompanied by English versions " +
                "from the 1914 translation by H.Rackham.";
        }

        public void ExtractWords(string text)
        {            
            //get rid of punctuation
            text = Regex.Replace(text, @"[^\w\s]", "");
            //turn into an array
            Words = new List<string>(text.Split(' '));
        }

      
    }
}
