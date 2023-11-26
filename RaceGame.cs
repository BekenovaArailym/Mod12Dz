using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public class RaceGame
    {
        public event Car.RaceHandler OnRaceFinish;

        public void StartRace(Car car)
        {
            car.OnFinish += FinishRace;
            car.StartRace();
        }

        private void FinishRace(Car car)
        {
            Console.WriteLine($"{car.Model} finished the race!");
            OnRaceFinish?.Invoke(car);
        }
    }
}