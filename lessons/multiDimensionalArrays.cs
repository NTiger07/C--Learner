using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            String[,] ParkingLot = {{ "Mustang", "Explorer", "GT" },
                                    { "Creta", "Sonata", "SantaFe" },
                                    { "Corolla", "Avensis", "Camry" }
                                   };

            ParkingLot[2, 0] = "Random Car";

            // foreach (String car in ParkingLot)
            // {
            //     Console.WriteLine(car);
            // }

            for (int i = 0; i < ParkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < ParkingLot.GetLength(1); j++)
                {
                    Console.Write(ParkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

