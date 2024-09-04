using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagementFromAdapter
{
    public class TeslaControl
    {
        public void PowerOf() => Console.WriteLine("Power off");
        public void PowerOn() => Console.WriteLine("Power on");
        public void IncreaseSpeed(int kmh) => Console.WriteLine($"Increasing speed by {kmh} km/h");
        public void UseBrake() => Console.WriteLine($"Using brake");

        public string GetTeslaStatus() => "Tesla is in good condition";

    }
}
