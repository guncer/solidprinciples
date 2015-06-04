using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldExample.v2
{
    public class ConsoleTextWriter:ITextWriter
    {
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
    }
}
