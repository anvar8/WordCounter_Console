using System;
using System.Collections.Generic;
using System.Text;

namespace WCLibrary_M
{
    public class CounterManager
    {
        IInputFile source;
        IOutputFile output;

        public CounterManager(IInputFile s, IOutputFile o)
        {
            source = s;
            output = o;
        }

        public void HandleCount()
        {
            var textContent = source.ExtractTextFromUrl();
            source.ExtractWords(textContent);
            source.CountWords();
            output.sourceFile = source;
            if (output.SaveFile()) {
                Console.WriteLine("Successfully saved to file");
                if (output.SaveToDB())
                {
                    Console.WriteLine("Successfully saved to db");
                    PeekContent();
                }
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
            Console.WriteLine(csv.ToString());
        }
        
        
    }
}
