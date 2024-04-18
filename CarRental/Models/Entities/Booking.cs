using System;
using System.Collections.Generic;

namespace CarRental.Models.Entities;

public partial class Booking
{
    public int BookingId { get; set; }

    public int UserId { get; set; }

    public int CarId { get; set; }

    public DateOnly BookingDate { get; set; }

    public DateTime PickupDate { get; set; }

    public DateTime ReturnDate { get; set; }

    public string PickupLocation { get; set; }

    public string ReturnLocation { get; set; }

    public double TotalCost { get; set; }

    public int Status { get; set; }

    public virtual Car Car { get; set; }

    public virtual User User { get; set; }
}
