using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagementFromAdapter
{
    public class ToyotaAdapter : ICarControl
    {
        ToyotaControl _toyota;
        public ToyotaAdapter(ToyotaControl toyota) 
        {
            _toyota = toyota;
        }
        public void Start() => _toyota.StartEngine();
        public void Stop() => _toyota.EndOfEngineOperation();
        public void Accelate(int speed) => _toyota.SpeedUp();
        public void Brake() => _toyota.SlowDown();
        public string GetStatus() => "Tesla Status ...";

    }
}
