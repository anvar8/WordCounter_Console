using System;
using WCLibrary_M;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch case to pick between file types
            var sourceUrl = @"C:\lorem.txt";
            var outputUrl = @"C:\output.csv";           
            //assume we chose .txt for src and .csv for output 
            IInputFile src = new InputTextFile(sourceUrl);
            IOutputFile output = new OutputCsvFile(outputUrl);
            CounterManager mgr = new CounterManager(src, output);
            mgr.HandleCount();
            Console.ReadLine();
        }
    }
}
