using System;
using System.Collections.Generic;
using System.Text;
using WCLibrary_M.Helpers;

namespace WCLibrary_M
{
    public interface IFile
    {
        string FileUrl { get; set; }
        IContentHandler ContentHandler { get; set; }
    }
}
