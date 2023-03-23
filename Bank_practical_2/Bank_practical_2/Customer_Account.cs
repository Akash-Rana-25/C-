using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_practical_2
{
    class Customer_Account
    {
        string bank_name = "SBI";
        long customer_accountNo;
        string customer_name;

        public Customer_Account(long acc_no, string c_name)
        {

            customer_accountNo = acc_no;
            customer_name = c_name;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Bank Name:" + bank_name);
            Console.WriteLine("Customer Name:" + customer_name);
            Console.WriteLine("cusomer Account no :" + customer_accountNo);

        }
    }
}
