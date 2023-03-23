using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Practical_7
{
    internal class CreditCardWithoutDIP
    {
        public void DoTransacation(decimal amount)
        {
            Console.WriteLine($"Payment of {amount} using credit card");
        }
    }
}
