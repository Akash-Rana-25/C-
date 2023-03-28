namespace vehicle_management_system
{
    abstract class Vehicle
    {
        public Vehicle(int id, string name, int seatingCapacity, int fuelTankSize, int headLightCount, int tailLightCount, int indiatorCount, int exhuastCount, int wheelsCount)
        {
            this.id = id;
            this.name = name;
            this.seatingCapacity = seatingCapacity;
            this.fuelTankSize = fuelTankSize;
            this.headLightCount = headLightCount;
            this.tailLightCount = tailLightCount;
            this.indiatorCount = indiatorCount;
            this.exhuastCount = exhuastCount;
            this.wheelsCount = wheelsCount;
        }

        public abstract void Start();
        public abstract void Stop();

        public abstract void Display();

       

        protected readonly int id;
        protected readonly string? name;
        protected readonly int seatingCapacity;
        protected readonly int fuelTankSize;
        protected readonly int headLightCount;
        protected readonly int tailLightCount;
        protected readonly int indiatorCount;
        protected readonly int exhuastCount;
        protected readonly int wheelsCount;

    }


}