using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldExample.v2;

namespace HelloWorldExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            IMessageCollector messageCollector=new ConsoleMessageCollector();
            ITextWriter textWriter=new ConsoleTextWriter();
            PublicMessage message=new PublicMessage(messageCollector,textWriter);
            message.Shout();
            Console.ReadKey();

            IMessageCollector messageCollector1 = new ConsoleMessageCollector();
            ITextWriter textWriter1 = new LogWriter(new DefaultLogger(), new ConsoleTextWriter());
            PublicMessage publicMessage1 = new PublicMessage(messageCollector1, textWriter1);
            publicMessage1.Shout();

            Console.ReadKey();
        }
    }
}
