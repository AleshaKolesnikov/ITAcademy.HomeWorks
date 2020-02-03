using System;

namespace HW._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle[] motorcycles = new Motorcycle[5];
            motorcycles[0] = Motorcycle.CreateMotorcycle(1, "Honda", "RX", 2010, 35_000);
            motorcycles[1] = Motorcycle.CreateMotorcycle(2, "BMW", "XDW", 2015, 12_000);
            motorcycles[2] = Motorcycle.CreateMotorcycle(3, "Opel", "L1", 2017, 10_000);
            motorcycles[3] = Motorcycle.CreateMotorcycle(4, "Minsk", "KK", 2013, 25_000);
            motorcycles[4] = Motorcycle.CreateMotorcycle(5, "Mercsedes", "GT", 2019, 5_000);

            Motorcycle.GetMotorcycles(motorcycles[4]);
            Motorcycle.UpdateMotorcycle(motorcycles[4], 5_555);
            Motorcycle.GetMotorcycles(motorcycles[4]);

            Motorcycle.DeleteMotorcycle(ref motorcycles[0]);
            Motorcycle.GetMotorcycles(motorcycles[0]);

            Motorcycle.GetMotorcycleById(motorcycles, 2);
        }
    }
}
