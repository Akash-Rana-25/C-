using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Practical_7
{
    internal class Shopping
    {
        private IBankCard _bankCard;

        internal Shopping(IBankCard bankCard)
        {
            _bankCard = bankCard;
        }
        public void DoShopping(decimal amount)
        {
            Console.WriteLine($"Purchasing item of amount {amount}");
            _bankCard.DoTransacation(amount);
        }
    }
}
