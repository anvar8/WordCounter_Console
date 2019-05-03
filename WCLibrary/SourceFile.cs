using System;
using System.Collections.Generic;
using System.Text;

namespace WCLibrary
{
    public abstract class SourceFile : IFile
    {
        public string FileUrl {
            get;
            set;
        }
        public SourceFile (string url)
        {
            FileUrl = url;
        }

        //public List<string> Words { get; set; }

        //protected internal event WCStateHandler WordsExtracted;
        //protected internal event WCStateHandler WordsCounted;
        //private void CallEvent ( WCStateHandler handler)
        //{
        //    if (handler != null)            
        //        handler(this);

        //}
        protected internal event SrcStateHandler WordsExtracted;
        protected internal event SrcStateHandler WordsCounted;
    
        protected virtual void OnWordsExtracted (SourceEventArgs e)
        {
          
            WordsExtracted(this, e);
        }
        protected virtual void OnWordsCounted (SourceEventArgs e)
        {
            WordsCounted(this, e);
        }
        protected virtual internal void CountWords ()
        {

        }
      

    }
}
