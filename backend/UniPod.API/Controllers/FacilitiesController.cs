using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniPod.API.Data;
using UniPod.API.DTOs;
using UniPod.API.Models;

namespace UniPod.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FacilitiesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public FacilitiesController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetFacilities()
    {
        var facilities = await _context.Facilities
            .ToListAsync();

        return Ok(facilities);
    }

    [HttpPost]
    public async Task<IActionResult> CreateFacility(
        CreateFacilityDto dto)
    {
        var facility = new Facility
        {
            Id = Guid.NewGuid(),
            Name = dto.Name,
            Description = dto.Description,
            IsActive = true,
            CreatedAt = DateTime.UtcNow
        };

        _context.Facilities.Add(facility);

        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetFacility),
            new { id = facility.Id },
            facility);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetFacility(Guid id)
    {
        var facility = await _context.Facilities
            .FirstOrDefaultAsync(f => f.Id == id);

        if (facility == null)
            return NotFound();

        return Ok(facility);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateFacility(
        Guid id,
        UpdateFacilityDto dto)
    {
        var facility = await _context.Facilities
            .FirstOrDefaultAsync(f => f.Id == id);

        if (facility == null)
            return NotFound();

        facility.Name = dto.Name;
        facility.Description = dto.Description;
        facility.IsActive = dto.IsActive;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteFacility(Guid id)
    {
        var facility = await _context.Facilities
            .FirstOrDefaultAsync(f => f.Id == id);

        if (facility == null)
            return NotFound();

        _context.Facilities.Remove(facility);

        await _context.SaveChangesAsync();

        return NoContent();
    }
}