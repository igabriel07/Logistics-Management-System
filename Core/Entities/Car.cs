public class Car : Vehicle {
    public const int EngineSize = 1400;
    public const decimal FuelConsumptionPer100Km = 6.5m;

    public override bool AllowsCoDriver => true;

    public override decimal CalculateFuelCost(decimal distance, IFuelPriceService fuelPriceService) {
        decimal fuelPrice = fuelPriceService.getFuelPrice("Petrol");
        
        return ((distance/100)*FuelConsumptionPer100Km)*fuelPrice;
    }
}