using System;
using System.Collections.Generic;
using System.Text;
using WCLibrary_M.Helpers;
using WCLibrary_M.Models;

namespace WCLibrary_M
{
    public class OutputFile : IFile // : IOutputFile
    {
        public InputFile sourceFile { get; set; }
        public string FileUrl { get; set; }
        public IContentHandler ContentHandler { get; set; }

        public OutputFile(string url, IContentHandler contentHandler)
        {
            FileUrl = url;
            ContentHandler = contentHandler;
        }

        public string SaveFile()
        {
            //save to file
            //save to file
            // return ContentHandler.SaveToFile(FileUrl);
            var content = new StringBuilder();
            //in your loop
            foreach (KeyValuePair<string, int> entry in sourceFile.WordCount)
            {
                var newLine = string.Format("{0},{1}", entry.Key, entry.Value);
                content.AppendLine(newLine);
            }
           
            return ContentHandler.SaveToFile(FileUrl, content.ToString());
           
        }

        public string SaveToDB()
        {
            //use db helper to save to db
            var dbHelper = new DbHelper();
            FileConversionRecord record = new FileConversionRecord(sourceFile.FileUrl, FileUrl);
            return dbHelper.SaveToDB(record);
        }
    }
}
