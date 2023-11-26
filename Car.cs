using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public class SportsCar : Car
    {
        public SportsCar(string model, int speed) : base(model, speed)
        {
            // Additional initialization specific to SportsCar if needed
        }

        public override void StartRace()
        {
            Console.WriteLine($"The {Model} sports car has started the race!");
            while (Position < 100)
            {
                OnRace();
            }
        }

        public override void OnRace()
        {
            Move();
            Console.WriteLine($"{Model} is at position {Position}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SportsCar ferrari = new SportsCar("Ferrari", 10);
            ferrari.OnFinish += FinishHandler;

            SportsCar lamborghini = new SportsCar("Lamborghini", 15);
            lamborghini.OnFinish += FinishHandler;

            ferrari.StartRace();
            lamborghini.StartRace();

            Console.ReadLine();
        }

        static void FinishHandler(Car car)
        {
            Console.WriteLine($"{car.Model} has finished the race!");
        }
    }
}