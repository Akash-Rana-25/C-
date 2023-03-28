using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_management_system
{
    internal class TwoWheeler : Vehicle
    {
        private readonly int _noOfHelmet=2;

    
        public TwoWheeler(int id,string name ,int seatingCapacity ,int fuelTankSize, int headLightCount ,int tailLightCount ,int indicatorCount , int exhuastCount ,int wheelsCount) : base(id ,name ,seatingCapacity,fuelTankSize,headLightCount,tailLightCount,indicatorCount,exhuastCount,wheelsCount) { 

        }

        public override void Start()
        {

            Console.WriteLine("\nStart The Engine");
            Console.WriteLine("Start The Driving");
        }

            public override void Stop()
        {
            Console.WriteLine("\nStop The Driving");
            Console.WriteLine("Stop The Engine");
        }
        public override void Display()
        {
            
            Console.WriteLine("\nNumber Of Helmet Require : "+_noOfHelmet);
            Console.WriteLine("id : "+id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Seating Capacity : " + seatingCapacity);
            Console.WriteLine("Fuel Tank Size : "+fuelTankSize+" Liter"); 
            Console.WriteLine("Head Light Counter : "+headLightCount);
            Console.WriteLine("Tail Light Counter : "+tailLightCount);
            Console.WriteLine("Indicator Count : "+ indiatorCount);
            Console.WriteLine("Exhuast Count : "+exhuastCount);
            Console.WriteLine("No Of Wheels : "+wheelsCount);
        }

    }
}
