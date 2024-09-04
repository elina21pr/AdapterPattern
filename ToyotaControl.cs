using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagementFromAdapter
{
    public class ToyotaControl
    {
        public void StartEngine() => Console.WriteLine("Engine started");
        public void EndOfEngineOperation() => Console.WriteLine("Engine stopped");
        public void SpeedUp() => Console.WriteLine("Speeding up");
        public void SlowDown() => Console.WriteLine("Slowing down");

        public string GetToyotaStatus() => "Toyota is running smoothly";
    }
}
