using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_tdd
{
    internal static class TokenAdder
    {
        public static DictionaryOfWordsByFilesAndTokens AddNewTokentoTokenDictionary(string word, int i, int j, DictionaryOfWordsByFilesAndTokens addressesByFileIdByToken, ListOfIndexes listOfIndices)
        {
            if (addressesByFileIdByToken.dictionary.ContainsKey(word))
            {
                addressesByFileIdByToken = DictionaryWordAdder.AddWordIfExistsInDictionary(addressesByFileIdByToken, word, i, j);
            }
            else
            {
                addressesByFileIdByToken = DictionaryWordAdder.AddWordIfDoesntExistInDictionary(addressesByFileIdByToken, word, i, j);
            }
            return addressesByFileIdByToken;
        }
    }
}
