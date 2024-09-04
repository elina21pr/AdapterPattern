using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagementFromAdapter
{
    public class FleetManagement
    {
        private List<ICarControl> _cars = new List<ICarControl>();
        public void AddCar(ICarControl car)
        {
            _cars.Add(car);
        }

        public void RemoveCar(ICarControl car)
        {
            _cars.Remove(car);
        }

        public void ControlCars()
        {
            foreach (var car in _cars)
            { 
                car.Start();
                car.Stop();
                car.Accelate(60);
                car.Brake();
                Console.WriteLine(car.GetStatus());
            }
        }
    }
}
