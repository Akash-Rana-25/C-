using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Practical_7
{
    internal class HPLaserJetPrinterWithoutISP : IPrinterTaskWithoutISP
    {
        public bool FaxContent(string content)
        {
            //code to scan content
            Console.WriteLine($"HP: Faxing Content: {content}");
            return true;
        }

        public bool PhotoCopyContent(string content)
        {
            //code to scan content
            Console.WriteLine($"HP: Photocopying Content: {content}");
            return true;
        }

        public bool PrintContent(string content)
        {
            //code to scan content
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
