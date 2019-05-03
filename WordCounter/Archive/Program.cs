
namespace WordCounter
{
    class Program1
    {

        //static void Main(string[] args)
        //{
        //    var sourceUrl = @"C:\lorem.txt";
        //    var outputUrl = @"C:\output.csv";
        //    //switch case to pick between file types
        //    //assume we chose .txt for src and .csv for output 
        //    //IInputFile src = new InputTextFile(sourceUrl);
        //    //IOutputFile output = new OutputCsvFile(outputUrl);
        //    //CounterManager mgr = new CounterManager(src, output);
        //    //mgr.HandleCount();
        //    //mgr.Init(FileType.Txt, 
        //    //    FileType.Csv,
        //    //    CountWordsHandler, 
        //    //    ExtractWordsHander, 
        //    //    SaveToFileHandler,
        //    //    SaveToDBHandler,
        //    //    sourceUrl, outputUrl);
        //    //mgr.HandleCount();
        //    Console.ReadLine();
        //}
        //private static void CountWordsHandler(object sender)
        //{

        //}

        //private static void ExtractWordsHander(object sender)
        //{

        //}

        //private static void SaveToFileHandler(object sender)
        //{

        //}

        //private static void SaveToDBHandler(object sender)
        //{

        //}

        //static void CountWords()
        //{
        //    CounterManager mgr = new CounterManager();
        //    if (!string.IsNullOrEmpty(mgr.SrcFile.FileUrl))
        //    {
        //        try
        //        {
        //            //extract words and count number of words
        //            mgr.Count();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }

        //        if (mgr.SrcFile.WordCount.Count > 0)
        //        {
        //            //save csv on computer (for testing) and database
        //            try
        //            {
        //                mgr.SaveCountResult();
        //                foreach (KeyValuePair<string, int> c in mgr.SrcFile.WordCount)
        //                {
        //                    Console.WriteLine($"{c.Key} : {c.Value}");
        //                }


        //                //  return Newtonsoft.Json.JsonConvert.SerializeObject(mgr.SrcFile.WordCount);
        //            }
        //            catch (Exception e)
        //            {
        //                Console.WriteLine(e.Message);
        //                //return e.Message;
        //            }

        //        }
        //    } else
        //    {
        //        Console.WriteLine("no file found");
        //        //new xception("No file found");
        //        //  return $"no file found at {fileUrl}";
        //    }

        //}
    }
}
