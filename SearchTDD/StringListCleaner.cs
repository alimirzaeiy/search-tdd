using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_tdd
{
    internal class StringListCleaner
    {
        public List<string> Strings(List<string> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    input[i] = input[i].Trim();
                    input[i] = input[i].Replace(",", "");
                    input[i] = input[i].Replace("[", "");
                    input[i] = input[i].Replace("]", "");
                    input[i] = input[i].Replace("\"", "");
                    input[i] = input[i].Replace(")", " ");
                    input[i] = input[i].Replace("(", " ");
                    input[i] = input[i].Replace("<", " ");
                    input[i] = input[i].Replace(">", " ");
                    input[i] = input[i].Replace("?", "");
                    input[i] = input[i].Replace("!", "");
                    input[i] = input[i].Replace(".", "");
                    input[i] = input[i].Replace("=", "");
                    input[i] = input[i].Replace("+", "");
                    input[i] = input[i].Replace("-", "");
                    input[i] = input[i].Replace("@", "");
                    input[i] = input[i].Replace("#", "");
                    input[i] = input[i].Replace("$", "");
                    input[i] = input[i].Replace("%", "");
                    input[i] = input[i].Replace("^", "");
                    input[i] = input[i].Replace("&", "");
                    input[i] = input[i].Replace("*", "");
                    input[i] = input[i].Replace("_", " ");
                    input[i] = input[i].Replace("\\", "");
                    input[i] = input[i].Replace("~", "");
                    input[i] = input[i].Replace("'", "");
                    input[i] = input[i].Replace("/", "");
                    input[i] = input[i].Replace("*", "");
                    input[i] = input[i].Replace("-", "");
                    input[i] = input[i].Replace(";", "");
                    input[i] = input[i].Replace(":", " ");
                    input[i] = input[i].Replace("|", "");
                    input[i] = input[i].Trim();
                    input[i] = input[i].ToUpper();
                }
            }
            return input;
        }
    }
}
