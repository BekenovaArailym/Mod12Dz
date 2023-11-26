using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public class Truck : Car
    {
        public Truck(string model, int speed) : base(model, speed) { }

        public override void StartRace()
        {
            Console.WriteLine($"The {Model} truck is ready to hit the road!");
            Move();
        }

        public override void OnRace()
        {
            Move();
        }
    }
}
