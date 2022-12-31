using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace search_tdd
{
    public class MapOfIndexedWordsByFile
    {
        public Dictionary<string, Dictionary<int, List<int>>> Dictionary { get; set; }
        public Dictionary<int, List<int>> Search(string keyword)
        {
            //throw new NotImplementedException();
            return Dictionary[keyword];
        }
        public MapOfIndexedWordsByFile()
        {

        }
        public MapOfIndexedWordsByFile(Dictionary<string, Dictionary<int, List<int>>> dictionary)
        {
            Dictionary = dictionary;
        }
    }
}
