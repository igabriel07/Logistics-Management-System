public class Motorcycle : Vehicle {
    public const int EngineSize = 300;
    public const decimal FuelConsumptionPer100Km = 3.0m;

    public override decimal CalculateFuelCost(decimal distance, IFuelPriceService fuelPriceService) {
        decimal fuelPrice = fuelPriceService.getFuelPrice("Petrol");
        
        return ((distance/100)*FuelConsumptionPer100Km)*fuelPrice;
    }
}