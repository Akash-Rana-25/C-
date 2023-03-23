using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SRP_Practical_7
{
    internal class Logger
    {

        public static void LogError(string error)
        {
            Console.Error.WriteLine($"Log-Error message: {error}");
        }
        public static void LogSuccess(string message)
        {
            Console.WriteLine($"Log-Success message: {message}");

        }
    }
}
