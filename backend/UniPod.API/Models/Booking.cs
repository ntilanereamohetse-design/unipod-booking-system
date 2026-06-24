namespace UniPod.API.Models;

public class Booking
{
    public Guid Id { get; set; }

    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string IdeaTitle { get; set; } = string.Empty;

    public string? ReviewComments { get; set; }

    public DateTime? ReviewedAt { get; set; }

    public string IdeaDescription { get; set; } = string.Empty;

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public BookingStatus Status { get; set; }
        = BookingStatus.Pending;

    public DateTime CreatedAt { get; set; }
        = DateTime.UtcNow;

    public Guid FacilityId { get; set; }

    public Facility Facility { get; set; } = null!;

    public ICollection<BookingMachine> BookingMachines
    { get; set; } = new List<BookingMachine>();
}