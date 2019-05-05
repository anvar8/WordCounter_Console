using System;
using WCLibrary_M;
using WCLibrary_M.Helpers;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //use switch statement to determine file type or get input parameter 

            var sourceUrl = @"C:\lorem.txt";
            var outputUrl = @"C:\output.csv";
            //assume we chose .txt for src and .csv for output file types 
            InputFile src = new InputFile(sourceUrl);
            OutputFile output = new OutputFile(outputUrl);

            //test swapping file types
            //IInputFile src = new InputFile(sourceUrl, new CSVContentHandler());
            //IOutputFile output = new OutputFile(outputUrl, new TextContentHandler());

            CounterManager mgr = new CounterManager(
                src,
                output,              
                new TextContentHandler(),
                new CSVContentHandler()
              );
            try
            {
                mgr.HandleCount();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
           
            Console.ReadLine();
        }
    }
}
