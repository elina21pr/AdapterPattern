using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagementFromAdapter
{
    public class ToyotaControl
    {
        public void StartEngine() { }
        public void EndOfEngineOperation() { }
        public void SpeedUp() { }
        public void SlowDown() { }

        string GetToyotaStatus => "Toyota Status ...";
    }
}
