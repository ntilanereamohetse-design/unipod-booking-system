namespace UniPod.API.Models;

public class Facility
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<Machine> Machines { get; set; }
        = new List<Machine>();

    public ICollection<Booking> Bookings { get; set; }
        = new List<Booking>();

    public ICollection<FacilityImage> Images { get; set; }
        = new List<FacilityImage>();
}