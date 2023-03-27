using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    static class Hostel
    {
        static string hostelName = "om";
        static string hostelAddress = "anand";
        static string hostelType = "Boys";

        internal static void PrintInfo()
        {
            Console.WriteLine("Hostel Name:" + hostelName);
            Console.WriteLine("Hostel Address:" + hostelAddress);
            Console.WriteLine("Hostel Type :" + hostelType);
        }
       
    }
}
