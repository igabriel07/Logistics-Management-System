public class Parcel 
{
    public int ParcelId { get; init; }
    public int? RouteId { get; set; }
    public string TrackingNumber { get; set; }
    public string DeliveryAddress { get; set; }
    public string ReceiverName { get; set; }
    public string ReceiverPhone { get; set; }
    public string ReceiverEmail { get; set; }
    public decimal ParcelWeight { get; set; }
    public string CurrentStatus { get; set; }
    public DateTime ReceivedAt { get; set; }
    public DateTime? DeliveredAt { get; set; }
}