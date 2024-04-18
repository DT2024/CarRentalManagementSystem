using System;
using System.Collections.Generic;

namespace CarRental.Models.Entities;

public partial class Car
{
    public int CarId { get; set; }

    public string CarMake { get; set; }

    public string CarModel { get; set; }

    public int CarYear { get; set; }

    public string CarColor { get; set; }

    public int CarMileage { get; set; }

    public double CarPrice { get; set; }

    public int Status { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
