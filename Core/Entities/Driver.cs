public class Driver {
    public int DriverId { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string LicenceNumber { get; set; }
    public bool LicenceCategoryA { get; set; }
    public bool LicenceCategoryB { get; set; }
    public bool LicenceCategoryC { get; set; }
    public bool IsActive { get; set; }
    public DateTime HiredAt { get; set; }
}