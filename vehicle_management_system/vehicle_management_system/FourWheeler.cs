using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_management_system
{
    internal class FourWheeler : Vehicle
    {
        protected readonly int speakerCount;
        protected readonly int windowsCounter;
        protected readonly int seatBeltCounter;
        protected readonly int discBrakeCount;

       private enum FuelType
        {
            Petrol = 1,
            Diesel = 2
        }
        public FourWheeler(int id, string name, int seatingCapacity, int fuelTankSize, int headLightCount, int tailLightCount, int indicatorCount, int exhuastCount, int wheelsCount) : base(id, name, seatingCapacity, fuelTankSize, headLightCount, tailLightCount, indicatorCount, exhuastCount, wheelsCount)
        {

            speakerCount= 1;
            windowsCounter= 4;
            seatBeltCounter = 5;
            discBrakeCount = 2;

        }
        public override void Start()
        {
            Console.WriteLine("\nRelease hand brake");
            Console.WriteLine("Start The Engine");
            Console.WriteLine("Start The Driving");
        }
        public override void Stop()
        {
            Console.WriteLine("\nStop The Driving");
            Console.WriteLine("Stop The Engine");
            Console.WriteLine("Engage hand brake");
        }
        public override void Display()
        {
            //Console.WriteLine("VehicleType :" + VehicleType);

            Console.WriteLine("\nid :" + id);
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Seating Capacity :" + seatingCapacity);
            Console.WriteLine("Fuel Tank Size :" + fuelTankSize);
            Console.WriteLine("Head Light Counter :" + headLightCount);
            Console.WriteLine("Tail Light Counter :" + tailLightCount);
            Console.WriteLine("Indicator Count :" + indiatorCount);
            Console.WriteLine("Exhuast Count :" + exhuastCount);
            Console.WriteLine("No Of Wheels :" + wheelsCount);

            Console.WriteLine("No Of Speaker :" + speakerCount);
            Console.WriteLine("No Of Windows :" + windowsCounter);
            Console.WriteLine("No Of Seat Belt :" + seatBeltCounter);
            Console.WriteLine("No Of Disc Brake :" + discBrakeCount);






        }

    }

}
