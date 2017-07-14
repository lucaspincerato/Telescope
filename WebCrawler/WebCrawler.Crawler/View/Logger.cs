using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler
{
    internal class Logger
    {
        internal static void Log(string message)
        {
            Console.WriteLine(DateTime.Now + ": " + message + "\n");
        }
    }
}
