using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_tdd
{
    internal class Files
    {
        public List<string> list { get; set; } = new List<string>();
        public Files(List<string> strings)
        {
            StringListCleaner clean = new StringListCleaner();
            // تمیز سازی حروف
            list = clean.Strings(strings);

        }
    }
}
