using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Model
{
    public class FileCountRecord
    {
        public FileCountRecord()
        {

        }
        public FileCountRecord(TextFile src, CsvFile dest)
        {
            this.Source = src.FileUrl;
            this.Output = dest.FileUrl;
        }
        public int Id { get; set; }
        public string Source { get; set; }
        public string Output { get; set; }
    }
}
