namespace UniPod.API.Models;

public class Machine
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    // Foreign Key
    public Guid FacilityId { get; set; }

    // Navigation Property
    public Facility Facility { get; set; } = null!;

    public ICollection<BookingMachine> BookingMachines
    { get; set; } = new List<BookingMachine>();
}