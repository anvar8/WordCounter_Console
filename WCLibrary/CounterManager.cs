using System;
using System.Collections.Generic;
using System.Text;

namespace WCLibrary
{
    public class CounterManager
    {
        SourceFile source = null;
        OutputFile output = null;
        public void Init(FileType srcFile, FileType outputFile,
            WCStateHandler countWords,
            WCStateHandler extractWords,
            WCStateHandler saveFile,
            WCStateHandler saveDB,
            string sourceUrl, string outputUrl)
        {

            switch (srcFile)
            {
                case FileType.Txt:
                    source = new TxtFile(sourceUrl);
                    break;
            }
            switch (outputFile)
            {
                case FileType.Csv:
                    output = new CsvFile(outputUrl);
                    break;
            }
            if (source == null || output == null)
            {
                throw new Exception("Error creating source and output files");
            }

            source.WordsCounted += countWords;
            source.WordsExtracted += extractWords;
            output.SavedToFile += saveFile;
            output.SavedToDB += saveDB;
        }
        public bool HandleCount()
        {
            source.ExtractWords();
            source.CountWords();
            return true;
        }
        public bool SaveOutput()
        {
            output.SaveOutputFile();
            output.SaveOutputDB();
            return true;

        }
    }

    public enum FileType
    {
        Csv,
        Txt
    }
}
