namespace congestion.calculator.Vehicles
{
    public enum VehicleTypes
    {
        Motorcycle = 0,
        Bus = 1,
        Emergency = 2,
        Diplomat = 3,
        Foreign = 4,
        Military = 5,
        Tractor = 6,
        Car = 7
    }

    public enum TollFreeVehicles
    {
        Motorcycle = VehicleTypes.Motorcycle,
        Bus = VehicleTypes.Bus,
        Emergency = VehicleTypes.Emergency,
        Diplomat = VehicleTypes.Diplomat,
        Foreign = VehicleTypes.Foreign,
        Military = VehicleTypes.Military
    }
}

