using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{

    // Abstraction 
    class Laptop
    {
        private string brand;
        private string model;

        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }
        public string Modal
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public void LaptopDetails()
        {
            Console.WriteLine("Laptop brand is" + brand);
            Console.WriteLine("Laptop modal is" + model);
        }
        private void MotherBoradinfo()
        {
            Console.WriteLine("MotherBorad Information ");
        }


    }
}
