using Domain.Entities.Models;
using Infrastructure.Data.Configuration;
using Infrastructure.Data.Seeding;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Infrastructure.Data;

public class RepositoryDbContext(DbContextOptions options) : IdentityDbContext<MyUser, MyRole, Guid>(options)
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
        modelBuilder.ApplyConfiguration(new ParkingSpaceConfiguration());
        modelBuilder.ApplyConfiguration(new BookingsConfiguration());

        //http://bboxfinder.com/#0.000000,0.000000,0.000000,0.000000
        var kushtiaBoundingBox = new BoundingBox(
            swLng: 89.095284,
            swLat: 23.882667,
            neLng: 89.160215,
            neLat: 23.910604
        );

        var (parkingLots, parkingSpaces) = SeedParking.GenerateSeedData(30, 8, kushtiaBoundingBox);
        modelBuilder.Entity<ParkingLot>().HasData(parkingLots);
        modelBuilder.Entity<ParkingSpace>().HasData(parkingSpaces);

        var dhakaBoundingBox = new BoundingBox(
            swLng: 90.325247,
            swLat: 23.732319,
            neLng: 90.455109,
            neLat: 23.788251
        );

        var (parkingLotsDhaka, parkingSpacesDhaka) = SeedParking.GenerateSeedData(30, 8, dhakaBoundingBox);
        modelBuilder.Entity<ParkingLot>().HasData(parkingLotsDhaka);
        modelBuilder.Entity<ParkingSpace>().HasData(parkingSpacesDhaka);


        var demoUser = new MyUser()
        {
            Id = Guid.NewGuid(),
            UserName = "faker",
            FirstName = "faker",
            LastName = "faker",
            NormalizedUserName = "FAKER",
            Email = "faker@example.com",
            NormalizedEmail = "FAKER@example.com",
            EmailConfirmed = true,
            PasswordHash = "1234567890",
            SecurityStamp = "1234567890",
            ConcurrencyStamp = "1234567890",
            PhoneNumber = "1234567890",
        };
        modelBuilder.Entity<MyUser>().HasData(demoUser); // seed users>

        modelBuilder.Entity<Booking>().HasData(SeedBooking.GenerateSeedData(20, demoUser.Id,
                                                                            parkingSpaces.Concat(parkingSpacesDhaka)));

    }

    public required DbSet<RefreshToken> RefreshTokens { get; set; }
    public required DbSet<ParkingLot> ParkingLots { get; set; }
    public required DbSet<ParkingSpace> ParkingSpaces { get; set; }

    public required DbSet<Booking> Bookings { get; set; }
    public required DbSet<TimeLine> TimeLines { get; set; }

}