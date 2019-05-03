using System;
using System.Collections.Generic;
using System.Text;
using WCLibrary_M.Helpers;

namespace WCLibrary_M
{
    public class OutputCsvFile : IOutputFile
    {
        public IInputFile sourceFile { get; set; }
        public string FileUrl { get; set; }

        public OutputCsvFile(string url)
        {
            FileUrl = url;
        }

        public bool SaveFile()
        {
            //save to url
            return true;
        }

        public bool SaveToDB()
        {
            //use db helper to save to db
            var dbHelper = new DbHelper(sourceFile.FileUrl, FileUrl);

            return dbHelper.SaveToDB();
        }
    }
}
