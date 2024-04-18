using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarRentalSystem
{
    public class Customer
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // Admin, User, etc.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public int RoleID { get; set; }

        // Constructor
        public Customer(int userID, string userName, string password, string role, string firstName, string lastName, string email, int phoneNumber, string address, int roleID)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
            Role = role;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            RoleID = roleID;
        }

    }
}
