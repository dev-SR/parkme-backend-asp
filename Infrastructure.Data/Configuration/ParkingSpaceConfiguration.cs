using System;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ParkingSpaceConfiguration : IEntityTypeConfiguration<ParkingSpace>
{
    public void Configure(EntityTypeBuilder<ParkingSpace> builder)
    {
        builder.Property(d => d.VehicleType).HasConversion<string>();//Converting enum to string
        builder.HasIndex(p => new { p.SectionName, p.SpotNumber, p.ParkingLotId })
               .IsUnique();


    }
}
