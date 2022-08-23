using System;

namespace congestion.calculator.Vehicles
{
    public interface Vehicle
    {
        int GetVehicleType();
    }

    public class VehicleDataDto
    {
        public DateTime[] dateTimes { get; set; }
        public string vehicleType { get; set; }
    }
}