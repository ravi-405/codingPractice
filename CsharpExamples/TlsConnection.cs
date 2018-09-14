using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsharpExamples
{
    class TlsConnection
    {
        static void Main()
        {
            var feeddata = XDocument.Load("https://www.houstonchronicle.com/default/feed/Houston-Chronicle-MSN-Premium-Feed-1967.php");
        }
    }
}
