using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagementFromAdapter
{
    public interface ICarControl
    {
        public void Start();
        public void Stop();
        public void Accelate(int speed);
        public void Brake();
        public string GetStatus();
    }

    
}
