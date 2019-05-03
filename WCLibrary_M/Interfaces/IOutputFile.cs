using System;
using System.Collections.Generic;
using System.Text;

namespace WCLibrary_M
{
    public interface IOutputFile : IFile
    {
        IInputFile sourceFile { get; set; }
        bool SaveFile();
        bool SaveToDB();
    }
}
