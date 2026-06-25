public abstract class Vehicle {

    public int VehicleId{ get; init; }
    public string LicencePlate{ get; set; }
    public char VehicleType{ get; set; }
    public string CurrentStatus{ get; set; }

    public virtual bool RequiresCoDriver => false;
    public virtual bool AllowsCoDriver => false;

    public abstract decimal CalculateFuelCost(decimal distance, IFuelPriceService fuelPriceService);
}