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
            if (wordDictionary.dictionary.ContainsKey(word)) 
            {
                var printer = new Printer();
                printer.Print(wordDictionary.dictionary[word]);
                return wordDictionary.dictionary[word];
            }else
            {
                Console.WriteLine("word not found");
                return (null);
            }
            
        }
    }
}
