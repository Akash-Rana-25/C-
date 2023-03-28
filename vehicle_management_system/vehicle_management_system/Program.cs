using System.ComponentModel;
using System.Text.RegularExpressions;

namespace vehicle_management_system
{
    internal class Program
    {
        public enum VehicleType
        {
            TwoWheeler = 1,
            FourWheeler = 2
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"\n register Your vehicle:");
            Console.WriteLine($"1 - Two Wheeler");
            Console.WriteLine($"2 - Four Wheeler ");

            string choice = Console.ReadLine();
            int intChoice = Convert.ToInt32( choice );
            VehicleType userSelected = (VehicleType)intChoice;


            switch (userSelected)
            {

                case VehicleType.TwoWheeler:

                    try
                    {
                        Console.WriteLine("\nEnter Vehicel ID: ");
                        int VehicalId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Vehicel Name: ");
                        string VehicalName = Console.ReadLine().ToString();

                        bool validation = Regex.IsMatch(VehicalName, @"^[a-zA-Z]+$");

                        Console.WriteLine("Enter Vehicel Seating Capicity: ");
                        int VehicalSeatingCapacity = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Vehicel Fuel Capicity (In Liter): ");
                        int VehicalFuelTankSize = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Number Of Head Lights In Vehicel  : ");
                        int VehicalHeadLightCount = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Number Of Tail Lights In Vehicel : ");
                        int VehicalTailLightCount = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Number Of Indicator In Vehicel : ");
                        int VehicalIndiatorCount = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Enter Number Of Exhuast In Vehicel : ");
                        int VehicalExhuastCount = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Enter Number Of Wheels In Vehicel : ");
                        int VehicalwheelsCount = Convert.ToInt32(Console.ReadLine());

                        if (validation) {
                            Vehicle Two = new TwoWheeler(VehicalId, VehicalName, VehicalSeatingCapacity, VehicalFuelTankSize, VehicalHeadLightCount, VehicalTailLightCount, VehicalIndiatorCount, VehicalExhuastCount, VehicalwheelsCount);

                            //Vehicle Two = new TwoWheeler(1, "activa", 2, 5, 1, 1, 4, 1, 2);

                            Two.Start(); ;
                            Two.Display();
                            Two.Stop();
                        }
                        else
                        {
                            Console.WriteLine("invalid String");
                        }
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Wrong input ");

                    }
                    break;

                case VehicleType.FourWheeler:
                    try
                    {
                        Console.WriteLine("Enter Vehicel ID: ");
                        int FVehicalId = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Vehicel Name: ");
                        string FVehicalName = Console.ReadLine().ToString();

                        bool validation1 = Regex.IsMatch(FVehicalName, @"^[a-zA-Z]+$");


                        Console.WriteLine("Enter Vehicel Seating Capicity: ");
                        int FVehicalSeatingCapacity = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Vehicel Fuel Capicity (in Liters): ");
                        int FVehicalFuelTankSize = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Number Of Head Lights In Vehicel  : ");
                        int FVehicalHeadLightCount = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Number Of Tail Lights In Vehicel : ");
                        int FVehicalTailLightCount = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Number Of Indicator In Vehicel : ");
                        int FVehicalIndiatorCount = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Enter Number Of Exhuast In Vehicel : ");
                        int FVehicalExhuastCount = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Enter Number Of Wheels In Vehicel : ");
                        int FVehicalwheelsCount = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Enter Number Of Speaker: ");
                        int FVehicalSpeakerCount = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Enter Number Of Seat Belt: ");
                        int FVehicalSeatBeltCount = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Enter Number Of Disc Brake: ");
                        int FVehicalDiscBrakeCount = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Enter Number Of Windows: ");
                        int FVehicalWindowsCounter = Convert.ToInt32(Console.ReadLine());

                        if (validation1) {
                            Console.WriteLine("Enter Fuel Type 1 For Petrol 2 For Diesel: ");
                            int FVehicalFuelType = Convert.ToInt32(Console.ReadLine());
                            Vehicle Four = new FourWheeler(FVehicalId, FVehicalName, FVehicalSeatingCapacity, FVehicalFuelTankSize, FVehicalHeadLightCount, FVehicalTailLightCount, FVehicalIndiatorCount, FVehicalExhuastCount, FVehicalwheelsCount, FVehicalSpeakerCount, FVehicalWindowsCounter, FVehicalSeatBeltCount, FVehicalDiscBrakeCount, FVehicalFuelType); ;

                            //Vehicle Four = new FourWheeler(1,"Swift",5,10,2,2,2,1,1,4,1,5,2,2);

                            Four.Start(); ;
                            Four.Display();
                            Four.Stop();
                        }
                        else
                        {
                            Console.WriteLine("invalid String");

                        }
                      
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Wrong input");

                    }
                    break;

                default:
                    Console.WriteLine("Wrong Input Only Two Types of vehicel are allowed");
                    break;
            }
        }
    }
}