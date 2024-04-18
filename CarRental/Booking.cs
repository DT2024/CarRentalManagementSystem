using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarRentalSystem
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int UserID { get; set; }
        public int CarID { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string PickupLocation { get; set; }
        public string ReturnLocation { get; set; }
        public double TotalCost { get; set; }
        public int Status { get; set; }

        public Booking(int bookingID, int userID, int carID, DateTime bookingDate, DateTime pickupDate, DateTime returnDate, string pickupLocation, string returnLocation, double totalCost, int status)
        {
            BookingID = bookingID;
            UserID = userID;
            CarID = carID;
            BookingDate = bookingDate;
            PickupDate = pickupDate;
            ReturnDate = returnDate;
            PickupLocation = pickupLocation;
            ReturnLocation = returnLocation;
            TotalCost = totalCost;
            Status = status;
        }
    }
}
