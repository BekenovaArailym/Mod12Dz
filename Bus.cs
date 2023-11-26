using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public class Bus : Car
    {
        public Bus(string model, int speed) : base(model, speed) { }

        public override void StartRace()
        {
            Console.WriteLine($"{Model} starts the race!");
            Move();
        }

        public override void OnRace()
        {
            Move();
        }
    }
}