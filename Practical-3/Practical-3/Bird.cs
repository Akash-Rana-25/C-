using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{
    class Bird
    {
        public void Voice()
        {
            Console.WriteLine("Tur Tur");

        }
    }
    class Duck : Bird
    {
        public void Voice()
        {
            Console.WriteLine("Quack Quack");
        }
    }
    
}
