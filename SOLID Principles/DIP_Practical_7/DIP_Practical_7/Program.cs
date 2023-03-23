using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DIP_Practical_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dependency Inversion Principle:
            //High level modules should not depend on low level module.
            //Both should depend on abstraction
            //Abstraction should not depend on details, but details should depend on abstraction
            //The interaction between high level and low level modules should be thought of as an abstract interaction between them

            //Without DIP
            Console.WriteLine();
            CreditCardWithoutDIP creditCard = new CreditCardWithoutDIP();
            ShoppingWithoutDIP shoppingAtMall = new ShoppingWithoutDIP(creditCard);
            shoppingAtMall.DoPurchase(10000);

            //Now there is a problem: ShoppingWithoutDIP directly depend on CreditCardWithoutDIP which violates DIP, if we want to use Debit card in future we have to manually make modification in ShoppingWithoutDIP, We can use card in Shopping with abstraction

            //With DIP
            Console.WriteLine();
            IBankCard sbiCreditCard = new CreditCard();
            IBankCard sbiDebitCard = new CreditCard();
            Shopping shoppingAtCroma = new Shopping(sbiDebitCard);
            shoppingAtCroma.DoShopping(20000);

            Shopping shoppingAtDmart = new Shopping(sbiCreditCard);
            shoppingAtDmart.DoShopping(500);


        }
    }
}