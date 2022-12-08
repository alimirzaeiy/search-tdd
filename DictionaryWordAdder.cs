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
            if (addressesByFileIdByToken.dictionary[word].TokenKeyValues.ContainsKey(i))
            {
                addressesByFileIdByToken.dictionary[word].TokenKeyValues[i].Add(j);
            }
            else
            {
                addressesByFileIdByToken.dictionary[word].TokenKeyValues.Add(i, new List<int> { { j } });
            }
            return addressesByFileIdByToken;
        }
        public static DictionaryOfWordsByFilesAndTokens AddWordIfDoesntExistInDictionary(DictionaryOfWordsByFilesAndTokens addressesByFileIdByToken, string word, int i, int j)
        {
            DictionaryOfFilesAndTokens fileAndToken = new DictionaryOfFilesAndTokens();
            fileAndToken.TokenKeyValues.Add(i, new List<int> { { j } });
            addressesByFileIdByToken.dictionary.Add(word, fileAndToken);
            return addressesByFileIdByToken;
        }
    }
}
