using System;
using System.Collections.Generic;
using System.Text;

namespace WCLibrary
{
    public abstract class OutputFile : IFile
    {
        public string FileUrl { get; set; }
        protected internal event WCStateHandler SavedToFile;
        protected internal event WCStateHandler SavedToDB;
        public OutputFile(string url)
        {
            FileUrl = url;
        }

        private void CallEvent(WCStateHandler handler)
        {
            if (handler != null)
                handler(this);

        }
        protected virtual void OnSaveFile()
        {
            CallEvent(SavedToFile);
        }
        protected virtual void OnSaveDB()
        {
            CallEvent(SavedToDB);
        }

        public virtual void SaveOutputFile()
        {
            //do word extraction
            OnSaveFile();
        }
        public virtual void SaveOutputDB()
        {
            OnSaveDB();
        }

    }
}
