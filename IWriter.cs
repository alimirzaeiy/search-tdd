using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_tdd
{
    public interface IWriter
    {
        /// <summary>
        /// It takes the input and prints it
        /// </summary>
        /// <param name="text">The text to be written</param>
        void WriteLine(string text);
    }
}
