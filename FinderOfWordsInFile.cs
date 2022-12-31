using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_tdd
{
    internal class FinderOfWordsInFile
    {
        DictionaryOfWordsByFilesAndTokens wordDictionary = new DictionaryOfWordsByFilesAndTokens();
        public DictionaryOfWordsByFilesAndTokens Find(List<string> input)
        {
            WordIndexer findWords = new WordIndexer();
            for (int i = 0; i < input.Count; i++)
            {
                //Console.WriteLine(i);
                wordDictionary = findWords.FileIndexCalculator(input[i], i, wordDictionary);
            }
            var printer = new Printer();
            printer.Print(wordDictionary);
            return wordDictionary;
        }
    }
}
