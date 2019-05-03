using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Model
{
    public class TextFile
    {
        public List<string> Words { get; set; } = new List<string>();

        public string FileUrl { get; set; }

        public Dictionary<string, int> WordCount { get; set; } = new Dictionary<string, int>();

        public TextFile(string fileUrl)
        {
            FileUrl = fileUrl;
        }
    }
}
