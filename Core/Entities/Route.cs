public class Route {
    public int RouteId { get; init; }
    public int? DriverId { get; set; }
    public int? CoDriverId { get; set; }
    public int? VehicleId { get; set; }
    public string CurrentStatus { get; set; }
    public DateTime? StartedAt { get; set; }
    public DateTime? EndedAt { get; set; }
}