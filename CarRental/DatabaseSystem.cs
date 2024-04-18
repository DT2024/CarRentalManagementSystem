using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ProjectCarRentalSystem
{
    public class DatabaseSystem
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Taken\Desktop\Group5.DataStructures\CarRental\CarRental\CarRental\DatabaseCarRentalSystem.mdf;Integrated Security=True";
        public string GetUserInfo(string username)
        {
            string userInfo = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserName, Role, Email FROM Users WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string userName = reader["UserName"].ToString();
                    string role = reader["Role"].ToString();
                    string email = reader["Email"].ToString();

                    userInfo = $"Username:{userName}Role:{role}Email:{email}";
                }

                reader.Close();
            }

            return userInfo;
        }

        public bool IsUsernameExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public bool RegisterUser(string firstName, string lastName, string username, string email, string password, int phone, string address, string role, int roleId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Users (Username, Password, Role, FirstName, LastName, Email, PhoneNumber, Address, RoleID) " +
                                        "VALUES (@Username, @Password, @Role, @FirstName, @LastName, @Email, @PhoneNumber, @Address, @RoleID)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Role", role);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNumber", phone);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@RoleID", roleId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
               
                System.Windows.Forms.MessageBox.Show("Failed to register user. Error: " + ex.Message);
                return false;
            }
        }

        public List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CarID, CarMake, CarModel, CarYear, CarColor, CarMileage, CarPrice, Status FROM Cars";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int carID = reader.GetInt32(0);
                    string make = reader.GetString(1);
                    string model = reader.GetString(2);
                    int year = reader.GetInt32(3);
                    string color = reader.GetString(4);
                    int mileageDouble = reader.GetInt32(5);
                    float mileage = (float)mileageDouble;
                    double priceDouble = reader.GetDouble(6);
                    float price = (float)priceDouble;
                    int status = reader.GetInt32(7);

                    Car car = new Car(carID, make, model, year, color, mileage, price, status);
                    cars.Add(car);
                }

                reader.Close();
            }

            return cars;
        }

        public bool AddCar(Car car)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Cars (CarMake, CarModel, CarYear, CarColor, CarMileage, CarPrice, Status) " +
                                   "VALUES (@Make, @Model, @Year, @Color, @Mileage, @Price, @Status)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Make", car.Make);
                    command.Parameters.AddWithValue("@Model", car.Model);
                    command.Parameters.AddWithValue("@Year", car.Year);
                    command.Parameters.AddWithValue("@Color", car.Color);
                    command.Parameters.AddWithValue("@Mileage", car.Mileage);
                    command.Parameters.AddWithValue("@Price", car.Price);
                    command.Parameters.AddWithValue("@Status", car.Status);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add car. Error: " + ex.Message);
                return false;
            }
        }

        public bool EditCar(Car car)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Cars SET CarMake = @Make, CarModel = @Model, CarYear = @Year, CarColor = @Color, CarMileage = @Mileage, " +
                                   "CarPrice = @Price, Status = @Status WHERE CarID = @CarID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Make", car.Make);
                    command.Parameters.AddWithValue("@Model", car.Model);
                    command.Parameters.AddWithValue("@Year", car.Year);
                    command.Parameters.AddWithValue("@Color", car.Color);
                    command.Parameters.AddWithValue("@Mileage", car.Mileage);
                    command.Parameters.AddWithValue("@Price", car.Price);
                    command.Parameters.AddWithValue("@Status", car.Status);
                    command.Parameters.AddWithValue("@CarID", car.CarID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to edit car. Error: " + ex.Message);
                return false;
            }
        }

        public bool DeleteCar(int carId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // First, delete all bookings associated with the customer
                    string deleteBookingsQuery = "DELETE FROM Bookings WHERE CarID = @CarID";
                    SqlCommand deleteBookingsCommand = new SqlCommand(deleteBookingsQuery, connection);
                    deleteBookingsCommand.Parameters.AddWithValue("@CarID", carId);

                    connection.Open();
                    deleteBookingsCommand.ExecuteNonQuery();

                    string query = "DELETE FROM Cars WHERE CarID = @CarID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CarID", carId);


                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete car. Error: " + ex.Message);
                return false;
            }
        }

        ////////////////////////////////////////customer///////////////////////////////////////////
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, UserName, Password, Role, FirstName, LastName, Email, PhoneNumber, Address, RoleID FROM Users";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int userId = reader.GetInt32(0);
                    string userName = reader.GetString(1);
                    string password = reader.GetString(2);
                    string role = reader.GetString(3);
                    string firstName = reader.GetString(4);
                    string lastName = reader.GetString(5);
                    string email = reader.GetString(6);
                    int phoneNumber = reader.GetInt32(7);
                    string address = reader.GetString(8);
                    int roleId = reader.GetInt32(9);

                    Customer customer = new Customer(userId, userName, password, role, firstName, lastName, email, phoneNumber, address, roleId);
                    customers.Add(customer);
                }

                reader.Close();
            }

            return customers;
        }
        public bool AddCustomer(Customer customer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Users (UserName, Password, Role, FirstName, LastName, Email, PhoneNumber, Address, RoleID) " +
                           "VALUES (@UserName, @Password, @Role, @FirstName, @LastName, @Email, @PhoneNumber, @Address, @RoleID)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserName", customer.UserName);
                    command.Parameters.AddWithValue("@Password", customer.Password);
                    command.Parameters.AddWithValue("@Role", customer.Role);
                    command.Parameters.AddWithValue("@FirstName", customer.FirstName);
                    command.Parameters.AddWithValue("@LastName", customer.LastName);
                    command.Parameters.AddWithValue("@Email", customer.Email);
                    command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", customer.Address);
                    command.Parameters.AddWithValue("@RoleID", customer.RoleID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add customer. Error: " + ex.Message);
                return false;
            }
        }

        public bool EditCustomer(Customer customer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Users SET UserName = @UserName, Password = @Password, " +
                                   "FirstName = @FirstName, LastName = @LastName, Email = @Email, " +
                                   "PhoneNumber = @PhoneNumber, Address = @Address WHERE UserID = @UserID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserName", customer.UserName);
                    command.Parameters.AddWithValue("@Password", customer.Password);
                    command.Parameters.AddWithValue("@FirstName", customer.FirstName);
                    command.Parameters.AddWithValue("@LastName", customer.LastName);
                    command.Parameters.AddWithValue("@Email", customer.Email);
                    command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", customer.Address);
                    command.Parameters.AddWithValue("@UserID", customer.UserID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to edit customer. Error: " + ex.Message);
                return false;
            }
        }

        public bool DeleteCustomer(int userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // First, delete all bookings associated with the customer
                    string deleteBookingsQuery = "DELETE FROM Bookings WHERE UserID = @UserID";
                    SqlCommand deleteBookingsCommand = new SqlCommand(deleteBookingsQuery, connection);
                    deleteBookingsCommand.Parameters.AddWithValue("@UserID", userId);

                    connection.Open();
                    deleteBookingsCommand.ExecuteNonQuery();

                    string query = "DELETE FROM Users WHERE UserID = @UserID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete customer. Error: " + ex.Message);
                return false;
            }
        }

        ////////////////////////////////////////booking///////////////////////////////////////////
        public List<Booking> GetBookingsWithStatusZero()
        {
            List<Booking> bookings = new List<Booking>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT BookingID, UserID, CarID, BookingDate, PickupDate, ReturnDate, PickupLocation, ReturnLocation, TotalCost, Status " +
                               "FROM Bookings WHERE Status = 0";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int bookingID = reader.GetInt32(0);
                    int userID = reader.GetInt32(1);
                    int carID = reader.GetInt32(2);
                    DateTime bookingDate = reader.GetDateTime(3);
                    DateTime pickupDate = reader.GetDateTime(4);
                    DateTime returnDate = reader.GetDateTime(5);
                    string pickupLocation = reader.GetString(6);
                    string returnLocation = reader.GetString(7);
                    double totalCost = reader.GetDouble(8);
                    int rawStatus = reader.GetInt32(9);

                    Booking booking = new Booking(bookingID, userID, carID, bookingDate, pickupDate, returnDate, pickupLocation, returnLocation, totalCost, rawStatus);
                    bookings.Add(booking);
                }

                reader.Close();
            }

            return bookings;
        }
        public List<Booking> GetBookingsWithStatusOne()
        {
            List<Booking> bookings = new List<Booking>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT BookingID, UserID, CarID, BookingDate, PickupDate, ReturnDate, PickupLocation, ReturnLocation, TotalCost, Status " +
                               "FROM Bookings WHERE Status = 1";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int bookingID = reader.GetInt32(0);
                    int userID = reader.GetInt32(1);
                    int carID = reader.GetInt32(2);
                    DateTime bookingDate = reader.GetDateTime(3);
                    DateTime pickupDate = reader.GetDateTime(4);
                    DateTime returnDate = reader.GetDateTime(5);
                    string pickupLocation = reader.GetString(6);
                    string returnLocation = reader.GetString(7);
                    double totalCost = reader.GetDouble(8);
                    int rawStatus = reader.GetInt32(9);

                    Booking booking = new Booking(bookingID, userID, carID, bookingDate, pickupDate, returnDate, pickupLocation, returnLocation, totalCost, rawStatus);
                    bookings.Add(booking);
                }

                reader.Close();
            }

            return bookings;
        }

        public List<Booking> GetBookingsWithStatusTwo()
        {
            List<Booking> bookings = new List<Booking>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT BookingID, UserID, CarID, BookingDate, PickupDate, ReturnDate, PickupLocation, ReturnLocation, TotalCost, Status " +
                               "FROM Bookings WHERE Status = 2";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int bookingID = reader.GetInt32(0);
                    int userID = reader.GetInt32(1);
                    int carID = reader.GetInt32(2);
                    DateTime bookingDate = reader.GetDateTime(3);
                    DateTime pickupDate = reader.GetDateTime(4);
                    DateTime returnDate = reader.GetDateTime(5);
                    string pickupLocation = reader.GetString(6);
                    string returnLocation = reader.GetString(7);
                    double totalCost = reader.GetDouble(8);
                    int rawStatus = reader.GetInt32(9);

                    Booking booking = new Booking(bookingID, userID, carID, bookingDate, pickupDate, returnDate, pickupLocation, returnLocation, totalCost, rawStatus);
                    bookings.Add(booking);
                }

                reader.Close();
            }

            return bookings;
        }

        public bool UpdateBookingStatusToAccepted(int bookingID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Bookings SET Status = 1 WHERE BookingID = @BookingID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BookingID", bookingID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update booking status. Error: " + ex.Message);
                return false;
            }
        }

        public bool UpdateBookingStatusToCancelled(int bookingID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Bookings SET Status = 2 WHERE BookingID = @BookingID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BookingID", bookingID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update booking status. Error: " + ex.Message);
                return false;
            }
        }

        ////////////////////////////////////////end///////////////////////////////////////////
    }
}
