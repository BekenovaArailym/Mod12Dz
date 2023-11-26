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
        public SportsCar(string model, int speed) : base(model, speed) { }

        public override void StartRace()
        {
            Console.WriteLine($"The {Model} sports car is revved up and ready to race!");
            Move();
        }

        public override void OnRace()
        {
            Move();
        }
    }
}