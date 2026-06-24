namespace UniPod.API.Models;

public class FacilityImage
{
    public Guid Id { get; set; }

    public string ImageUrl { get; set; } = string.Empty;

    public string? Caption { get; set; }

    public DateTime UploadedAt { get; set; }
        = DateTime.UtcNow;

    public Guid FacilityId { get; set; }

    public Facility Facility { get; set; } = null!;
}