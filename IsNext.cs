using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_tdd
{
    internal static class IsNext
    {
        public static bool Space(string input, int index)
        {
            return input[index + 1] == ' ';
        }
    }
}
