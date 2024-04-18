using System;
using System.Collections.Generic;

namespace CarRental.Models.Entities;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string Role { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public int PhoneNumber { get; set; }

    public string Address { get; set; }

    public int? RoleId { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
