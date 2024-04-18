using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System;
using CarRental.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProjectCarRentalSystem
{
    public class LoginFormSingleton
    {
        private static LoginFormSingleton instance;
        private static readonly object lockObject = new object();
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Taken\Desktop\Group5.DataStructures\CarRental\CarRental\CarRental\DatabaseCarRentalSystem.mdf;Integrated Security=True";
        private int loggedInUserId;

        public int LoggedInUserId
        {
            get { return loggedInUserId; }
            private set { loggedInUserId = value; }
        }
        private LoginFormSingleton() { }

        public static LoginFormSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new LoginFormSingleton();
                        }
                    }
                }
                return instance;
            }
        }

        public bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username COLLATE SQL_Latin1_General_CP1_CS_AS AND Password = @Password COLLATE SQL_Latin1_General_CP1_CI_AS";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                StoreLoggedInUserId(username);

                return count > 0;
            }
        }

        public int CheckRole(string username, string password)
        {
            int role = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT RoleID FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                       
                        role = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return role;
        }

        public List<object> GetBookingHistory(int userId)
        {
            List<object> bookingHistory = new List<object>();

            try
            {
                using (DatabaseCarRentalSystemContext dbContext = new DatabaseCarRentalSystemContext())
                {
                    bookingHistory = dbContext.Bookings
                                    .Where(booking => booking.UserId == userId)
                                    .Join(dbContext.Cars,
                                        booking => booking.CarId,
                                        car => car.CarId,
                                        (booking, car) => new
                                        {
                                            booking.BookingId,
                                            booking.UserId,
                                            booking.TotalCost,
                                            booking.BookingDate,
                                            booking.PickupDate,
                                            booking.ReturnDate,
                                            booking.PickupLocation,
                                            booking.ReturnLocation,
                                            car.CarMake,
                                            car.CarModel
                                        })
                                    .ToList<object>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return bookingHistory;
        }
        private void StoreLoggedInUserId(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryUserId = "SELECT UserID FROM Users WHERE Username = @Username";
                SqlCommand commandUserId = new SqlCommand(queryUserId, connection);
                commandUserId.Parameters.AddWithValue("@Username", username);

                connection.Open();
                loggedInUserId = (int)commandUserId.ExecuteScalar();
            }
        }

    }
}
