using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Text.Json.JsonSerializer;

namespace search_tdd
{
    public class Printer
    {
        private readonly IWriter _writer;

        public Printer() : this(new ConsoleWriter())
        {
        }

        public Printer(IWriter writer)
        {
            _writer = writer;
        }

        public void Print(object input)
        {
            _writer.WriteLine(Serialize(input));
            _writer.WriteLine("-------------------");
        }
    }
}
