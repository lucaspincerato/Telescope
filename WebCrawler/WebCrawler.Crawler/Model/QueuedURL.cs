using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler.Model
{
    internal class QueuedURL
    {
        public string URL { get; set; }
        public int priority { get; set; }

        internal QueuedURL(string URL, int Priority)
        {
            this.URL = URL;
            this.priority = Priority;
        }
    }
}
