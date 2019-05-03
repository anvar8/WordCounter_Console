using System;
using System.Collections.Generic;
using System.Text;
using WCLibrary_M.Models;

namespace WCLibrary_M.Helpers
{
    public class DbHelper
    {
        private FileConversionRecord record;
        public DbHelper(string src, string dest)
        {
            record = new FileConversionRecord(src, dest);
        }
        public bool SaveToDB()
        {
            //save to database here 
            return true;
        }
    }
}
