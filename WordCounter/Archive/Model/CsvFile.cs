using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Model
{
    public class CsvFile
    {
        public string FileUrl { get; set; }
        public CsvFile(string outputUrl)
        {
            this.FileUrl = outputUrl;
        }

    }
}
