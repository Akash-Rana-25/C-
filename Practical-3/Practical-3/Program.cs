using System.Xml.Linq;

namespace Practical_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team T=new Team();
            T.Printinfo();
            
            Bird mybird = new Bird();
            //Duck myduck=new Bird();  This will Throw error beacuse we can not create object from base class using derived Class
            Duck myduck= new Duck();

            mybird.Voice();
            myduck.Voice();

            Laptop laptop= new Laptop();
            laptop.Brand = " Lenovo";
            laptop.Modal = " Thinpad";

            laptop.LaptopDetails();
            //laptop.MotherBordDetail() Can not acces private method 


        }

    }


}