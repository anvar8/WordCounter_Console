using System;
using System.Collections.Generic;
using System.Text;

namespace WCLibrary_M.Models
{
    public class FileConversionRecord
    {
        public FileConversionRecord()
        {

        }
        public FileConversionRecord(string srcUrl, string outputUrl)
        {
            Source = srcUrl;
            Output = outputUrl;
        }
        public int Id { get; set; }
        public string Source { get; set; }
        public string Output { get; set; }
    }
}
