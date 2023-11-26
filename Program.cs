using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using CarLib;

namespace Mod12Dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RaceGame raceGame = new RaceGame();

            var cars = new List<Car>();
            SportsCar sportsCar = new SportsCar("Lamborghini", 5);
            SedanCar sedanCar = new SedanCar("Honda", 4);
            Truck truck = new Truck("Ford", 3);
            Bus bus = new Bus("Volkswagen", 2);

            cars.Add(sportsCar);
            cars.Add(sedanCar);
            cars.Add(truck);
            cars.Add(bus);

            raceGame.OnRaceFinish += Winner;

            raceGame.StartRace(cars[0]);
            raceGame.StartRace(cars[1]);
            raceGame.StartRace(cars[2]);
            raceGame.StartRace(cars[3]);

            while (sportsCar.Position < 100 && sedanCar.Position < 100 && truck.Position < 100 && bus.Position < 100)
            {
                cars[0].OnRace();
                cars[1].OnRace();
                cars[2].OnRace();
                cars[3].OnRace();
                int s;

                for (int j = 0; j < cars.Count; j++)
                {
                    s = 0;
                    for (int k = j + 1; k < cars.Count; k++)
                    {
                        if (cars[j].Position > cars[k].Position)
                        {
                            s += 1;
                        }
                    }
                    int place = cars.Count - s;

                    Console.WriteLine($"{cars[j].Model} finished in {Ordinal(place)} place! Position: {cars[j].Position}");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void Winner(Car car)
        {
            Console.WriteLine($"{car.Model} is the winner!");
        }

        // Helper method to get ordinal numbers (1st, 2nd, 3rd, etc.)
        private static string Ordinal(int num)
        {
            if (num <= 0)
                return num.ToString();

            switch (num % 100)
            {
                case 11:
                case 12:
                case 13:
                    return num + "th";
            }

            switch (num % 10)
            {
                case 1:
                    return num + "st";
                case 2:
                    return num + "nd";
                case 3:
                    return num + "rd";
                default:
                    return num + "th";
            }
        }
    }
}