using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_tdd
{
    internal static class EqualityOfTwoDictionaryOfIntAndIntList
    {
        public static bool Check(Dictionary<int, List<int>> dictionary1, Dictionary<int, List<int>> dictionary2)
        {
            bool result = true;
            for (int i = 0; i < dictionary1.Count; i++)
            {
                if (!dictionary1.ContainsKey(i)) continue;
                for (int j = 0; j < dictionary1[i].Count; j++)
                {
                    if (!dictionary1[i].Contains(j)) continue;
                    result = result & (dictionary1[i][j] == dictionary2[i][j]);
                    Console.WriteLine("ll : " + dictionary1[i][j] + " i : " + i + " j : " + " j " + "result : " + result);

                }
            }
            return result;
        }
    }
}
