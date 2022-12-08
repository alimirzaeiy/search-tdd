using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Text.Json.JsonSerializer;

namespace search_tdd
{
    internal static class Print
    {
        public static void it(object input)
        {
            Console.WriteLine(Serialize(input));
            Console.WriteLine("-------------------");
        }
    }
}
