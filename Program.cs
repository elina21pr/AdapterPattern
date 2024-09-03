using FleetManagementFromAdapter;
using System;

public class Program
{
   public static void Main(string[] args)
    {
        FleetManagement fleetManagement = new FleetManagement();

        TeslaControl teslaControl = new TeslaControl();
        fleetManagement.AddCar(new TeslaAdapter(teslaControl));

        ToyotaControl toyotaControl = new ToyotaControl();
        fleetManagement.AddCar(new ToyotaAdapter(toyotaControl));

        fleetManagement.ControlCars();
    }
}