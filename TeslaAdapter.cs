using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagementFromAdapter
{
    public class TeslaAdapter : ICarControl
    {

        private TeslaControl _tesla;

        public TeslaAdapter(TeslaControl tesla)
        {
            _tesla = tesla;
        }

        public void Start() => _tesla.PowerOf();
        public void Stop() => _tesla.PowerOn();
        public void Accelate(int speed) => _tesla.IncreaseSpeed(speed);
        public void Brake() => _tesla.UseBrake();
        public string GetStatus() => "Tesla Status ...";

    }

}
