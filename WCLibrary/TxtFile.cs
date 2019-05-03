using System;
using System.Collections.Generic;
using System.Text;

namespace WCLibrary
{
    public class TxtFile : SourceFile
    {
        public TxtFile (string url) : base (url) { }
        protected internal override void CountWords()
        {
            //seed list demo
            List<string> words = new List<string>();
            string[] ranWords = { "hello", "world", "is", "pretty" };
            for (var i = 0; i < 100; i++)
            {
                var rand = new Random();
                int idx = rand.Next(0, ranWords.Length);
                words.Add(ranWords[idx]);
            }
            base.OnWordsExtracted(words);
        }

    }
}
