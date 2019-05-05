using System;
using System.Collections.Generic;
using System.Text;

namespace WCLibrary_M
{
    public class CounterManager
    {
        private InputFile source;
        private OutputFile output;

        public CounterManager(InputFile s, OutputFile o)
        {
            source = s;
            output = o;
        }
        /*
         * do series of operations to extract file content
         * , extract words excluding punctuation into a string
         * , and count occurances of each unique word in the text content.
         * Save data content into a file. Save source/output references into db as a record
         */
        public void HandleCount()
        {
            var textContent = source.ExtractTextFromUrl();
            if (!string.IsNullOrEmpty(textContent))
            {
                source.ExtractWords(textContent);
                source.CountWords();
                output.sourceFile = source;
                Console.WriteLine(output.SaveFile());
                Console.WriteLine(output.SaveToDB());
                PeekContent();
            }
            
        }
        public void PeekContent()
        {
            var csv = new StringBuilder();
            //in your loop
            foreach (KeyValuePair<string, int> entry in source.WordCount)
            {
                var newLine = string.Format("{0},{1}", entry.Key, entry.Value);
                csv.AppendLine(newLine);
            }
            Console.WriteLine("Test output: ");
            Console.WriteLine(csv.ToString());
        }
        
        
    }
}
