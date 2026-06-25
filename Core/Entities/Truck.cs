public class Truck : Vehicle {
    public const int EngineSize = 3500;
    public const decimal FuelConsumptionPer100Km = 11.5m;

    public override bool RequiresCoDriver => true;
    public override bool AllowsCoDriver => true;

    public override decimal CalculateFuelCost(decimal distance, IFuelPriceService fuelPriceService) {
        decimal fuelPrice = fuelPriceService.getFuelPrice("Diesel");
        
        return ((distance/100)*FuelConsumptionPer100Km)*fuelPrice;
    }
}