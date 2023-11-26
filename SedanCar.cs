using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public class SedanCar : Car
    {
        public SedanCar(string model, int speed) : base(model, speed) { }

        public override void StartRace()
        {
            Console.WriteLine($"The {Model} sedan is ready to race!");
            Move();
        }

        public override void OnRace()
        {
            Move();
        }
    }
}