using CarRental.Models.Entities;
using ProjectCarRentalSystem;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Booking = CarRental.Models.Entities.Booking;
using Car = CarRental.Models.Entities.Car;

namespace CarRental
{
    public partial class CustomerBooking : Form
    {
        private DateTime pickUpDate;
        private DateTime returnDate;
        private string pickUpLocation;
        private string returnLocation;
        private decimal carPrice;
        private int carId;
        private UserView userViewForm;
        public CustomerBooking(string carMake, string carModel, string carYear, decimal carPrice, UserView userViewForm)
        {
            InitializeComponent();

            textBox2.Text = carMake;
            textBox3.Text = carModel;
            textBox4.Text = carYear;
            textBox5.Text = carPrice.ToString("C");
            this.carPrice = carPrice;

            // Wire up the ValueChanged events
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            this.userViewForm = userViewForm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerBooking_Load(object sender, EventArgs e)
        {
            carId = GetCarIdFromDatabase(textBox2.Text, textBox3.Text, carPrice) ?? 0;
        }

        private int? GetCarIdFromDatabase(string carMake, string carModel, decimal carPrice)
        {
            int? carId = null;

            try
            {
                using (DatabaseCarRentalSystemContext dbContext = new DatabaseCarRentalSystemContext())
                {
                    Car car = dbContext.Cars.FirstOrDefault(c => c.CarMake == carMake && c.CarModel == carModel && (decimal)c.CarPrice == carPrice);

                    if (car != null)
                    {
                        carId = car.CarId;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching CarId: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return carId;
        }

        private void CalculateTotalPrice()
        {
          
                pickUpDate = dateTimePicker1.Value;
                returnDate = dateTimePicker2.Value;

                // Check if return date is before pickup date
                if (returnDate.Date < pickUpDate.Date)
                {
                    MessageBox.Show("Return date cannot be before pickup date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                TimeSpan totalDays = returnDate.Date - pickUpDate.Date;

                if (totalDays.TotalDays == 0)
                {
                    totalDays = TimeSpan.FromDays(1);
                }

                decimal totalPrice = carPrice * (decimal)totalDays.TotalDays;
                textBox1.Text = totalPrice.ToString("C");

              
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null && comboBox1.SelectedItem != null && comboBox2.SelectedItem != null) // To Ensure locations are selected
            {
                string selectedPayment = comboBox3.SelectedItem.ToString();
                string pickupLocation = comboBox1.SelectedItem.ToString();  // Capture pickup location
                string returnLocation = comboBox2.SelectedItem.ToString();  // Capture return location

                // Validate input
                decimal amount;
                if (decimal.TryParse(textBox1.Text.Replace("$", "").Replace(",", ""), out amount))
                {
                    string bookingSummary = $"Car: {textBox2.Text}, Model: {textBox3.Text}, Total Price: {textBox1.Text}";

                    switch (selectedPayment)
                    {
                        case "Credit Card":
                            CreditCardPrompt creditCardForm = new CreditCardPrompt(bookingSummary, amount);
                            if (creditCardForm.ShowDialog() == DialogResult.OK)
                            {
                                ProcessPayment(new CreditCard(), amount, pickupLocation, returnLocation);  // Pass locations
                            }
                            break;
                        case "Bitcoin":
                            BitcointPrompt bitcoinForm = new BitcointPrompt(bookingSummary,amount);
                            if (bitcoinForm.ShowDialog() == DialogResult.OK)
                            {
                                ProcessPayment(new Bitcoin(), amount, pickupLocation, returnLocation);  // Pass locations
                            }
                            break;
                        case "E-Transfer":
                            E_TransferPrompt eTransferForm = new E_TransferPrompt(bookingSummary, amount);
                            if (eTransferForm.ShowDialog() == DialogResult.OK)
                            {
                                ProcessPayment(new E_Transfer(), amount, pickupLocation, returnLocation);  // Pass locations
                            }
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select both pickup and return locations.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    private void ProcessPayment(IPayStrategy paymentMethod, decimal amount, string pickupLocation, string returnLocation)
    {
        PaymentSystem paymentSystem = new PaymentSystem(paymentMethod);

        try
        {
            paymentSystem.MakePayment((double)amount); // Pass the amount directly

            using (DatabaseCarRentalSystemContext dbContext = new DatabaseCarRentalSystemContext())
            {
                Booking newBooking = new Booking
                {
                    UserId = LoginFormSingleton.Instance.LoggedInUserId,
                    CarId = carId,
                    TotalCost = (double)amount,
                    BookingDate = DateOnly.FromDateTime(DateTime.Now),
                    PickupDate = pickUpDate,
                    ReturnDate = returnDate,
                    PickupLocation = pickupLocation,  // Use the captured pickup location
                    ReturnLocation = returnLocation,  // Use the captured return location
                    Status = 0
                };

                dbContext.Bookings.Add(newBooking);
                dbContext.SaveChanges();

                // Update car status to 0 (unavailable)
                var car = dbContext.Cars.FirstOrDefault(c => c.CarId == carId);
                if (car != null)
                {
                    car.Status = 0;
                    dbContext.SaveChanges();
                }

                MessageBox.Show("Booking saved and paid successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    userViewForm.LoadAvailableCars();
                }
        }
        catch (Exception ex)
        {
            
            string errorMessage = "An error occurred while processing the payment or saving the booking: " + ex.Message;
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
                errorMessage += "\nInner Exception: " + ex.Message;
            }
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
}
