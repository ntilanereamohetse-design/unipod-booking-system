namespace UniPod.API.Models;

public class BookingMachine
{
    public Guid BookingId { get; set; }

    public Booking Booking { get; set; } = null!;

    public Guid MachineId { get; set; }

    public Machine Machine { get; set; } = null!;
}