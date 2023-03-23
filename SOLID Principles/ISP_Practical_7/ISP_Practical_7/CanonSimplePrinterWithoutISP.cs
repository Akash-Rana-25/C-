using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Practical_7
{

    internal class CanonSimplePrinterWithoutISP : IPrinterTaskWithoutISP
    {
        public bool FaxContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PhotoCopyContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintContent(string content)
        {
            //code to print content
            Console.WriteLine($"Canon: Printing Content: {content}");
            return true;
        }

        public bool ScanContent(string content)
        {
            //code to scan content
            Console.WriteLine($"Canon: Scanning Content: {content}");
            return true;
        }
    }

}
