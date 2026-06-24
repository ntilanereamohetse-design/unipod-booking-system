using Microsoft.EntityFrameworkCore;
using UniPod.API.Models;

namespace UniPod.API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<BookingMachine>()
            .HasKey(bm => new
            {
                bm.BookingId,
                bm.MachineId
            });
    }

    public DbSet<Facility> Facilities => Set<Facility>();
    public DbSet<Machine> Machines => Set<Machine>();
    public DbSet<Booking> Bookings => Set<Booking>();
    public DbSet<BookingMachine> BookingMachines => Set<BookingMachine>();
}