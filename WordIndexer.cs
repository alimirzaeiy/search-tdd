using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_tdd
{
    internal class WordIndexer
    {
        public DictionaryOfWordsByFilesAndTokens FileIndexCalculator(string str, int i, DictionaryOfWordsByFilesAndTokens addressesByFileIdByToken)
        {
            Cursor index = new Cursor();
            Words words = new Words();
            ListOfIndexes listOfIndices = new ListOfIndexes();
            FindIndexesOfWords findIndexOfWords = new FindIndexesOfWords();
            index.position = 0;
            addressesByFileIdByToken = findIndexOfWords.FindIndexAndFillDictionary(i, index.position, str, listOfIndices, words, addressesByFileIdByToken);
            return addressesByFileIdByToken;
        }
    }
}
