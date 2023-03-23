using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ISP_Practical_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Interface Segregation Principle:
            //No clients should be forced to depend on methods it does not use
            //One fat interface should be split into many smaller and relevant interfaces so clients can know about the interface that are relevant to them

            //Without ISP
            Console.WriteLine();
            IPrinterTaskWithoutISP hpLaserJetPrinterWithoutISP = new HPLaserJetPrinterWithoutISP();
            hpLaserJetPrinterWithoutISP.PrintContent("Hello World");
            hpLaserJetPrinterWithoutISP.ScanContent("Hello World");
            hpLaserJetPrinterWithoutISP.FaxContent("Hello World");
            hpLaserJetPrinterWithoutISP.PhotoCopyContent("Hello World");

            IPrinterTaskWithoutISP canonSimplePrinterWithoutISP = new CanonSimplePrinterWithoutISP();
            canonSimplePrinterWithoutISP.PrintContent("Hello world");
            canonSimplePrinterWithoutISP.ScanContent("Hello world");

            //Now there is a problem: canon simple printer doesn't support faxing and photocopying but as it implements IPrintTaskWithoutISP it has to implement all methods and going to throw NotImplementedException, which violates ISP, as canon printer unnecessarily have to implement unwanted methods

            //With ISP
            Console.WriteLine();
            IPrintAndScan hpLaserJetPrinterPrintAndScan = new HPLaserJetPrinter();
            hpLaserJetPrinterPrintAndScan.PrintContent("Hello World");
            hpLaserJetPrinterPrintAndScan.ScanContent("Hello World");

            IFax hpLaserJetPrinterFax = new HPLaserJetPrinter();
            hpLaserJetPrinterFax.FaxContent("hello world");

            IPhotoCopy hpLaserJetPrinterPhotoCopy = new HPLaserJetPrinter();
            hpLaserJetPrinterPhotoCopy.PhotoCopyContent("hello world");

            IPrintAndScan canonSimplePrinterPrintAndScan = new CanonSimplePrinter();
            canonSimplePrinterPrintAndScan.PrintContent("hello world");
            canonSimplePrinterPrintAndScan.ScanContent("hello world");
        }
    }
}