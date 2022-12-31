using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_tdd
{
    internal class DictionaryOfWordsByFilesAndTokens
    {
        public Dictionary<string, DictionaryOfFilesAndTokens> dictionary { get; set; } = new Dictionary<string, DictionaryOfFilesAndTokens>();
    }
}
