using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCounter.Model
{
    public class CounterManager
    {
        public TextFile SrcFile { get; }
        public CsvFile OutputFile { get;}

        public CounterManager()
        {
            SrcFile = new TextFile(@"C:\Users\Public\Documents\lorem.txt");
            OutputFile = new CsvFile(@"C:\Users\Public\Documents\output.csv");
        }

        public CounterManager(string inputUrl, string outputUrl)
        {
            SrcFile = new TextFile(inputUrl);
            OutputFile = new CsvFile(outputUrl);
        }

        public void Count()
        {
            ExtractWords();
            CountWords();
        }
        public void CountWords()
        {
            //creates dictionary <string, int> to store words and their counts
            foreach (var word in SrcFile.Words)
            {
                if (!SrcFile.WordCount.ContainsKey(word.ToString().Trim()))
                {
                    SrcFile.WordCount.Add(word, 1);
                }
                else
                {
                    SrcFile.WordCount[word] += 1;
                }
            }
            Console.WriteLine(SrcFile.WordCount);
        }

        public void ExtractWords()
        {
           
            string[] ranWords = { "hello", "world", "is", "pretty" };
            for (var i = 0; i < 100; i++)
            {
                var rand = new Random();
                var idx = rand.Next(0, ranWords.Length);
                SrcFile.Words.Add(ranWords[idx]);
            }
            Console.WriteLine(SrcFile.Words);
            //note: returns false if file is reached, but permission denied.
            //if (!File.Exists(SrcFile.FileUrl))
            //{
            //    string text = File.ReadAllText(SrcFile.FileUrl);
            //    //get rid of punctuation
            //    text = Regex.Replace(text, @"[^\w\s]", "");
            //    //turn into an array
            //    if (text.Length > 0)
            //    {
            //        SrcFile.Words = new List<string>(text.Split(' '));
            //    }
            //}
            //else
            //{
            //    throw new Exception($"File not found at {SrcFile.FileUrl}");
            //    //seed to test
              

            //}
        }

        public void SaveCountResult()
        {
            this.SaveCountResultFile(SrcFile.WordCount);
            this.SaveCountResultDB(SrcFile.WordCount);
        }
        private void SaveCountResultFile(Dictionary<string, int> resultDict)
        {
            //before your loop
            var csv = new StringBuilder();
            //in your loop
            foreach (KeyValuePair<string, int> entry in resultDict)
            {
                var newLine = string.Format("{0},{1}", entry.Key, entry.Value);
                csv.AppendLine(newLine);
            }
            File.WriteAllText(OutputFile.FileUrl, csv.ToString());
        }
        private void SaveCountResultDB(Dictionary<string, int> resultDict)
        {
            var record = new FileCountRecord(SrcFile, OutputFile);
            //dbHelper.SaveRecord(record);
        }
    }
}
