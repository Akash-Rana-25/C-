using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SRP_Practical_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Single Responsibility Principle:
            //A class should have only one reason to change
            //Every class or module should have single responsibility, and that responsibility should be entirely encapsulated by class
            //Each class and module should focus on single task only
            //Everything in class should be related to that single purpose

            // Without SRP
            UserWithoutSRP user = new UserWithoutSRP();
            user.Register("karan", "karan@123", "Karan Raj");
            user.Login("karan", "karan@123");

            //Now there is a problem: In future if we want to change Logging mechanism or Email related functions than user class needs to be changed which is violating SRP principle

            // With SRP
            UserWithSRP userWithSRP = new UserWithSRP();
            Console.WriteLine();
            userWithSRP.Register("karan", "karan@123", "Karan Raj");
            userWithSRP.Login("karan", "karan@123");
        }
    }
}