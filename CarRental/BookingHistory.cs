using CarRental.Models.Entities;
using ProjectCarRentalSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{

    public partial class BookingHistory : Form
    {
        private readonly LoginFormSingleton loginFormSingleton = LoginFormSingleton.Instance;
        private UserView userViewForm;
        private List<object> bookingHistory;



        public BookingHistory(UserView userViewForm)
        {
            InitializeComponent();
            this.userViewForm = userViewForm;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookingHistory_Load(object sender, EventArgs e)
        {
            LoadBookingHistory();
        }
        private void LoadBookingHistory()
        {
            int userId = loginFormSingleton.LoggedInUserId;

            try
            {
                using (DatabaseCarRentalSystemContext dbContext = new DatabaseCarRentalSystemContext())
                {
                    var bookingHistory = dbContext.Bookings
                                        .Where(booking => booking.UserId == userId)
                                        .Join(dbContext.Cars,
                                            booking => booking.CarId,
                                            car => car.CarId,
                                            (booking, car) => new
                                            {
                                                booking.BookingId,
                                                booking.UserId,
                                                booking.TotalCost,
                                                BookingDate = new DateTime(booking.BookingDate.Year, booking.BookingDate.Month, booking.BookingDate.Day),
                                                booking.PickupDate,
                                                booking.ReturnDate,
                                                booking.PickupLocation,
                                                booking.ReturnLocation,
                                                car.CarMake,
                                                car.CarModel,
                                                car.CarId,
                                                booking.Status
                                            })
                                        .ToList<object>();  

                    // Assign to class-level variable
                    this.bookingHistory = bookingHistory;

               
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();

                  
                    dataGridView1.Columns.Add("CarMake", "Car Make");
                    dataGridView1.Columns.Add("CarModel", "Car Model");
                    dataGridView1.Columns.Add("TotalCost", "Total Cost");
                    dataGridView1.Columns.Add("BookingDate", "Booking Date");
                    dataGridView1.Columns.Add("PickupDate", "Pickup Date");
                    dataGridView1.Columns.Add("ReturnDate", "Return Date");
                    dataGridView1.Columns.Add("PickupLocation", "Pickup Location");
                    dataGridView1.Columns.Add("ReturnLocation", "Return Location");

               
                    foreach (var booking in bookingHistory)
                    {
                        int rowIndex = dataGridView1.Rows.Add();

                        if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
                        {
                            dataGridView1.Rows[rowIndex].Cells["CarMake"].Value = booking.GetType().GetProperty("CarMake").GetValue(booking, null);
                            dataGridView1.Rows[rowIndex].Cells["CarModel"].Value = booking.GetType().GetProperty("CarModel").GetValue(booking, null);
                            dataGridView1.Rows[rowIndex].Cells["TotalCost"].Value = ((double)booking.GetType().GetProperty("TotalCost").GetValue(booking, null)).ToString("C");
                            dataGridView1.Rows[rowIndex].Cells["BookingDate"].Value = ((DateTime)booking.GetType().GetProperty("BookingDate").GetValue(booking, null)).ToShortDateString();
                            dataGridView1.Rows[rowIndex].Cells["PickupDate"].Value = ((DateTime)booking.GetType().GetProperty("PickupDate").GetValue(booking, null)).ToShortDateString();
                            dataGridView1.Rows[rowIndex].Cells["ReturnDate"].Value = ((DateTime)booking.GetType().GetProperty("ReturnDate").GetValue(booking, null)).ToShortDateString();
                            dataGridView1.Rows[rowIndex].Cells["PickupLocation"].Value = booking.GetType().GetProperty("PickupLocation").GetValue(booking, null);
                            dataGridView1.Rows[rowIndex].Cells["ReturnLocation"].Value = booking.GetType().GetProperty("ReturnLocation").GetValue(booking, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading booking history: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                try
                {
                    using (DatabaseCarRentalSystemContext dbContext = new DatabaseCarRentalSystemContext())
                    {
                        // Get the booking to cancel
                        var bookingToCancel = bookingHistory[selectedIndex];
                        var bookingId = (int)bookingToCancel.GetType().GetProperty("BookingId").GetValue(bookingToCancel, null);
                        var bookingStatus = (int)bookingToCancel.GetType().GetProperty("Status").GetValue(bookingToCancel, null);
                        var carId = (int)bookingToCancel.GetType().GetProperty("CarId").GetValue(bookingToCancel, null);

                        // Check if booking status is 0 (available)
                        if (bookingStatus == 0)
                        {
                            // Update car status to 1 (available)
                            var car = dbContext.Cars.FirstOrDefault(c => c.CarId == carId);
                            if (car != null)
                            {
                                car.Status = 1;
                            }

                            // Remove the booking
                            var booking = dbContext.Bookings.Find(bookingId);
                            if (booking != null)
                            {
                                dbContext.Bookings.Remove(booking);
                            }

                            dbContext.SaveChanges();

                            // Reload the DataGridView in BookingHistory form
                            LoadBookingHistory();

                            // Update the DataGridView in UserView form
                            userViewForm.LoadAvailableCars();
                        }
                        else
                        {
                            MessageBox.Show("Cannot cancel the booking. The booking is not available.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while cancelling the booking: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to cancel.");
            }
        }
    }
}
