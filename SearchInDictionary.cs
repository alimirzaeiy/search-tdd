using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_tdd
{
    internal static class SearchInDictionary
    {
        public static DictionaryOfFilesAndTokens It(string word, DictionaryOfWordsByFilesAndTokens wordDictionary)
        {
            Console.Write(word + " : ");
            word = word.ToUpper();
            Print.it(wordDictionary.dictionary[word]);
            return wordDictionary.dictionary[word];
        }
    }
}
