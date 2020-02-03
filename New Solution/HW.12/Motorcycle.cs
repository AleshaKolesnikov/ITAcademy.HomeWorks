using System;
using System.Collections.Generic;
using System.Text;

namespace HW._12
{
    class Motorcycle
    {
        int Id { get; set; }
        string Name { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        int Odometer { get; set; }

        public static Motorcycle CreateMotorcycle(int ID, string name, string model, int year, int odometer)
        {
            Motorcycle moto = new Motorcycle();
            moto.Id = ID;
            moto.Name = name;
            moto.Model = model;
            moto.Year = year;
            moto.Odometer = odometer;
            return moto;
        }

        public static Motorcycle DeleteMotorcycle(ref Motorcycle moto)
        {
            moto = null;
            return moto;
        }

        public static void GetMotorcycles(Motorcycle moto)
        {
            if (moto != null)
            {
                Console.WriteLine($"ID - {moto.Id};\nName - {moto.Name};\n" +
                    $"Model - {moto.Model};\nYear - {moto.Year};\nOdometer - {moto.Odometer}\n");
            }
            else Console.WriteLine("Motorcycle not set or deleted\n");
        }

        public static Motorcycle UpdateMotorcycle(Motorcycle moto, int odometer)
        {
            moto.Odometer = odometer;
            return moto;
        }

        public static void GetMotorcycleById(Motorcycle[] motos, int ID)
        {
            Motorcycle comparedMoto = null;
            for (int i = 0; i < motos.Length; i++)
            {
                if (motos[i] != null && motos[i].Id == ID)
                {
                    comparedMoto = motos[i];
                    GetMotorcycles(motos[i]);
                }
            }
            if (comparedMoto == null)
                Console.WriteLine("Not found. Perhaps, specified ID don't exist");
        }
    }
}
