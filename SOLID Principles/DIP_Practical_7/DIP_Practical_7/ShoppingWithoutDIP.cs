using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Practical_7
{
    internal class ShoppingWithoutDIP
    {
        private CreditCardWithoutDIP creditCard;

        public ShoppingWithoutDIP(CreditCardWithoutDIP creditCard)
        {
            this.creditCard = creditCard;
        }
        public void DoPurchase(decimal amount)
        {
            Console.WriteLine($"Purchasing item of amount {amount}");
            creditCard.DoTransacation(amount);
        }

    }
}
