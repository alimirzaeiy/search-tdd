using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_tdd
{
    public class indexing
    {
        DictionaryOfWordsByFilesAndTokens wordDictionary = new DictionaryOfWordsByFilesAndTokens();
        FinderOfWordsInFile indexByFile = new FinderOfWordsInFile();
        public indexing(List<string> strs)
        {
            NewFile(strs);
        }

        internal void NewFile(List<string> strings)
        {
            Files files = new Files(strings);
            strings = files.list;
            // ایندکس گذاری
            wordDictionary = indexByFile.Find(strings);
        }

        public DictionaryOfFilesAndTokens Search(string word)
        {
            var result = SearchInDictionary.It(word, wordDictionary);
            return result;
        }
    }
}
