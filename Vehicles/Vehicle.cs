using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Vehicle
    {
        public void StartEngine (string nosieTomakeWhenStarting)
        {
            Console.WriteLine($"Starting engine: {nosieTomakeWhenStarting}");
        }

        public void StopEngine (string noiseToMakeWhenStopping)
        {
            Console.WriteLine($"Stopping engine: {noiseToMakeWhenStopping}");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Defualt implementation of the Drive method");
        }
    }
}
