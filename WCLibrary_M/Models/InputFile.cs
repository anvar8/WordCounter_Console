using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using WCLibrary_M.Helpers;

namespace WCLibrary_M
{
    public class InputFile : IFile //: IInputFile
    {     

        public InputFile(string url, IContentHandler contentHandler)  {
            FileUrl = url;
            ContentHandler = contentHandler;
        }
        public List<string> Words { get; set; } 
            = new List<string>();
        public Dictionary<string, int> WordCount { get; set; } 
            = new Dictionary<string, int>();  
        public string FileUrl
        { get; set; }
        public IContentHandler ContentHandler { get ; set; }

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
            var text = ContentHandler.ExtractFromUrl(FileUrl);
            return text;
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
