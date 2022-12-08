using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_tdd
{
    internal class FindIndexesOfWords
    {
        public DictionaryOfWordsByFilesAndTokens FindIndexAndFillDictionary(int i, int cursor, string str, ListOfIndexes listOfIndexes, Words words, DictionaryOfWordsByFilesAndTokens addressesByFileIdByToken)
        {
            for (int j = 0; cursor <= str.LastIndexOf(" ");)
            {
                cursor = str.IndexOf(" ", cursor);
                if (IsNext.Space(str, cursor))
                {
                    cursor++;
                    continue;
                }

                listOfIndexes.indexes.Add(cursor);
                words.list = WordSepearatorByIndexNumber.FindWordBetweenTwoIndex(str, j, words.list, listOfIndexes);
                addressesByFileIdByToken = TokenAdder.AddNewTokentoTokenDictionary(words.list[j], i, j, addressesByFileIdByToken, listOfIndexes);
                if (cursor == str.LastIndexOf(" "))
                {
                    j++;
                    words.list = WordSepearatorByIndexNumber.FindLastWords(str, j, words.list, cursor);
                    addressesByFileIdByToken = TokenAdder.AddNewTokentoTokenDictionary(words.list[j], i, j, addressesByFileIdByToken, listOfIndexes);
                }
                cursor++;
                j++;
            }
            return addressesByFileIdByToken;
        }
    }
}
