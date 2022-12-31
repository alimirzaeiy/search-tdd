using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_tdd
{
    internal static class WordSepearatorByIndexNumber
    {
        public static List<string> FindWordBetweenTwoIndex(string str, int j, List<string> words, ListOfIndexes listOfIndexes)
        {
            if (j == 0)
            {
                words.Add(str.Substring(0, listOfIndexes.indexes[j]));
                Console.WriteLine("word is :" + words[0] + " j : " + listOfIndexes.indexes[j]);
            }
            else words.Add(str.Substring(listOfIndexes.indexes[j - 1] + 1, listOfIndexes.indexes[j] - listOfIndexes.indexes[j - 1] - 1));
            return words;
        }

        public static List<string> FindLastWords(string str, int j, List<string> words, int Cursor)
        {
            Console.WriteLine("last Word is : " + str.Substring(Cursor + 1, str.Length - Cursor - 1));
            words.Add(str.Substring(Cursor + 1, str.Length - Cursor - 1));
            return words;
        }
    }
}
