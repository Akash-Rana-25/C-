using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Practical_7
{
    internal interface IPrintAndScan
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
    }
}
