using System.ComponentModel.DataAnnotations;
using Shared.Enums;

namespace Domain.Entities.Models;

public class ParkingLot
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required string Address { get; set; }
    [Range(-180, 180)]
    public required double Longitude { get; set; }
    [Range(-90, 90)]
    public required double Latitude { get; set; }

    public virtual ICollection<ParkingSpace> ParkingSpaces { get; set; } = null!;
}


public class ParkingSpace
{
    public Guid Id { get; set; }
    public required VehicleType VehicleType { get; set; }
    public required string SectionName { get; set; } // A, B, C
    public required int SpotNumber { get; set; }
    public required double PricePerHour { get; set; }
    public Guid ParkingLotId { get; set; }
    public virtual ParkingLot ParkingLot { get; set; } = null!;
    public virtual ICollection<Booking> Bookings { get; set; } = null!;
}




public class Booking
{
    public Guid Id { get; set; }

    public required string VehicleNumber { get; set; }
    public string? PhoneNumber { get; set; }
    public required double PricePerHour { get; set; }
    public required DateTime StartDate { get; set; }
    [CustomValidation(typeof(Booking), "ValidateEndDate")]
    public required DateTime EndDate { get; set; }

    public Guid UserId { get; set; }
    public virtual MyUser User { get; set; } = null!;
    public Guid ParkingSpaceId { get; set; }
    public virtual ParkingSpace ParkingSpace { get; set; } = null!;


    public required double TotalPrice { get; set; }
    public required string Passcode { get; set; }
    public required BookingStatus Status { get; set; } = BookingStatus.PENDING;
    public string? StripePaymentSessionId { get; set; }


    public virtual ICollection<TimeLine> TimeLines { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public static ValidationResult? ValidateEndDate(DateTime endDate, ValidationContext context)
    {
        var instance = context.ObjectInstance as Booking;
        if (instance != null && endDate <= instance.StartDate)
        {
            return new ValidationResult("EndDate must be greater than StartDate.");
        }
        return ValidationResult.Success;
    }

}

public class TimeLine
{
    public Guid Id { get; set; }

    public Guid BookingId { get; set; }
    public virtual Booking Booking { get; set; } = null!;
    public required TimeLineValue TimeLineValue { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

}