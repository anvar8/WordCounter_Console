using System;
using System.Collections.Generic;
using System.Text;

namespace WCLibrary
{
    //public delegate void WCStateHandler (object sender);
    public delegate void OutputStateHander(object sender);
    public delegate void SrcStateHandler(object sender, SourceEventArgs e);
    public class SourceEventArgs
    {
        public List<string> Words { get; private set; }
        public Dictionary<string, int> WordCount { get; private set; }
        public SourceEventArgs(List<string> words, Dictionary<string, int> wordCount)
        {
            Words = words;
            WordCount = wordCount;
        }

    }

}
