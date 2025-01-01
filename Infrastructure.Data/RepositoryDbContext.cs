using Domain.Entities.Models;
using Infrastructure.Data.Configuration;
using Infrastructure.Data.Seeding;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Infrastructure.Data;

public class RepositoryDbContext(DbContextOptions options) : IdentityDbContext<User>(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);// required for identity migration to work properly.
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new RefreshTokenConfiguration());

        double[] boundingBox = { 89.095284, 23.882667, 89.160215, 23.910604 };
        var (parkingLots, parkingSpaces) = SeedParking.GenerateSeedData(10, 5, boundingBox);
        modelBuilder.Entity<ParkingLot>().HasData(parkingLots);
        modelBuilder.Entity<ParkingSpace>().HasData(parkingSpaces);

    }

    public required DbSet<RefreshToken> RefreshTokens { get; set; }
    public required DbSet<ParkingLot> ParkingLots { get; set; }
    public required DbSet<ParkingSpace> ParkingSpaces { get; set; }

}