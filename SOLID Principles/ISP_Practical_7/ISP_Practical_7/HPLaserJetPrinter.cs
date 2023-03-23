using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Practical_7
{
    internal class HPLaserJetPrinter : IPrintAndScan, IFax, IPhotoCopy
    {
        public bool FaxContent(string content)
        {
            //code to fax content
            Console.WriteLine($"HP: Faxing Content: {content}");
            return true;
        }

        public bool PhotoCopyContent(string content)
        {
            //code to photocopy content
            Console.WriteLine($"HP: Photocopying Content: {content}");
            return true;
        }

        public bool PrintContent(string content)
        {
            //code to print content
            Console.WriteLine($"HP: Printing Content: {content}");
            return true;
        }

        public bool ScanContent(string content)
        {
            //code to scan content
            Console.WriteLine($"HP: Scanning Content: {content}");
            return true;
        }
    }
}
