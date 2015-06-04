using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldExample.v2
{
   public  class ConsoleMessageCollector:IMessageCollector
    {
       public string CollectMessageFromUser()
       {
           Console.Write("Type your message to the world: ");
           return Console.ReadLine();
       }
    }
}
