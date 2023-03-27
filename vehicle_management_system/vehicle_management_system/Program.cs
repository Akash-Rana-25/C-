namespace vehicle_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n register Your vehicle:");
            Console.WriteLine($"1 - Two Wheeler");
            Console.WriteLine($"2 - Four Wheeler ");

            string Choice = Console.ReadLine();


            switch (Choice)
            {
                case "1":

                    Console.WriteLine("Enter Vehicel ID: ");
                    int VehicalId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Vehicel Name: ");
                    string VehicalName= Console.ReadLine().ToString();

                    Console.WriteLine("Enter Vehicel Seating Capicity: ");
                    int VehicalSeatingCapacity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Vehicel Fuel Capicity: ");
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

                    Vehicle Two = new TwoWheeler(VehicalId,VehicalName, VehicalSeatingCapacity, VehicalFuelTankSize, VehicalHeadLightCount, VehicalTailLightCount,VehicalIndiatorCount , VehicalExhuastCount, VehicalwheelsCount);
                    Two.Start(); ;
                    Two.Display();
                    Two.Stop();
                    break;

                case "2":
                    Console.WriteLine("Enter Vehicel ID: ");
                    int FVehicalId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Vehicel Name: ");
                    string FVehicalName = Console.ReadLine().ToString();

                    Console.WriteLine("Enter Vehicel Seating Capicity: ");
                    int FVehicalSeatingCapacity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Vehicel Fuel Capicity: ");
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

                    Vehicle Four = new FourWheeler(FVehicalId, FVehicalName, FVehicalSeatingCapacity, FVehicalFuelTankSize, FVehicalHeadLightCount, FVehicalTailLightCount, FVehicalIndiatorCount, FVehicalExhuastCount, FVehicalwheelsCount);
;
                    Four.Start(); ;
                    Four.Display();
                    Four.Stop();
                    break;

                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }
    }
}