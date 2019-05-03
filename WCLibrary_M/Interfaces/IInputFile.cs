using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WCLibrary_M
{
    public interface IInputFile : IFile
    {
        List<string> Words { get; set; }
        Dictionary<string, int> WordCount { get; set; }
        string ExtractTextFromUrl();
        void ExtractWords(string text);
        void CountWords();
    }
}
