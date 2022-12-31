using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_tdd
{
    internal static class DictionaryWordAdder
    {
        public static DictionaryOfWordsByFilesAndTokens AddWordIfExistsInDictionary(DictionaryOfWordsByFilesAndTokens addressesByFileIdByToken, string word, int i, int j)
        {
            addressesByFileIdByToken.dictionary[word].AddTokenIndices(i, j);
            return addressesByFileIdByToken;
        }
        public static DictionaryOfWordsByFilesAndTokens AddWordIfDoesntExistInDictionary(DictionaryOfWordsByFilesAndTokens addressesByFileIdByToken, string word, int i, int j)
        {
            DictionaryOfFilesAndTokens fileAndToken = new DictionaryOfFilesAndTokens();
            fileAndToken.SetTokenIndices(i, new List<int> { { j } });
            addressesByFileIdByToken.dictionary.Add(word, fileAndToken);
            return addressesByFileIdByToken;
        }
    }
}
