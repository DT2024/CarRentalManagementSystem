using CarRental.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class UserView : Form
    {
        private readonly DatabaseCarRentalSystemContext dbContext;
        public UserView()
        {
            InitializeComponent();
            dbContext = new DatabaseCarRentalSystemContext();
            LoadAvailableCars();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadAvailableCars()
        {
            try
            {
                // Query to select available cars (status == 1)
                var query = from car in dbContext.Cars
                            where car.Status == 1
                            select new
                            {
                                car.CarMake,
                                car.CarModel,
                                car.CarYear,
                                car.CarColor,
                                car.CarPrice
                            };

                // Clear existing rows in the DataGridView
                dataGridView1.Rows.Clear();

                // Add each available car to the DataGridView
                foreach (var car in query)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells[0].Value = car.CarMake;
                    dataGridView1.Rows[rowIndex].Cells[1].Value = car.CarModel;
                    dataGridView1.Rows[rowIndex].Cells[2].Value = car.CarYear;
                    dataGridView1.Rows[rowIndex].Cells[3].Value = car.CarColor;
                    dataGridView1.Rows[rowIndex].Cells[4].Value = car.CarPrice.ToString("C"); ;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading available cars. Please try again later.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllCars cars = new AllCars();
            cars.Show();
        }

        private void UserView_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim().ToLower();

            List<Car> filteredCars = dbContext.Cars
                                            .Where(car => car.Status == 1 && car.CarMake.ToLower().Contains(searchText))
                                            .ToList();

            if (filteredCars.Any()) // Check if the list is not empty
            {
                UpdateDataGridView(filteredCars);
            }
            else
            {
                MessageBox.Show($"We don't have any cars with the make '{searchText}'.");
            }
        }
        private void UpdateDataGridView(List<Car> cars)
        {

            dataGridView1.Rows.Clear();


            foreach (var car in cars)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = car.CarMake;
                dataGridView1.Rows[rowIndex].Cells[1].Value = car.CarModel;
                dataGridView1.Rows[rowIndex].Cells[2].Value = car.CarYear;
                dataGridView1.Rows[rowIndex].Cells[3].Value = car.CarColor;
                dataGridView1.Rows[rowIndex].Cells[4].Value = car.CarPrice.ToString("C"); ;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();


            LoadAvailableCars();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Check if a row is selected
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string carMake = Convert.ToString(selectedRow.Cells["CarMake"].Value);
                string carModel = Convert.ToString(selectedRow.Cells["CarModel"].Value);
                string carYear = Convert.ToString(selectedRow.Cells["CarYear"].Value);

                string carPriceString = Convert.ToString(selectedRow.Cells["Price"].Value);

                // Remove the dollar sign and parse the string to decimal
                decimal carPrice;
                if (Decimal.TryParse(carPriceString, NumberStyles.Currency, CultureInfo.CurrentCulture, out carPrice))
                {
                    CustomerBooking customerBooking = new CustomerBooking(carMake, carModel, carYear, carPrice,this); // Pass selected car details to CustomerBooking form
                    customerBooking.Show();
                }
                else
                {
                    MessageBox.Show("Error parsing price. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please select a car from the list before booking.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BookingHistory form=new BookingHistory(this);
            form.Show();
        }
    }
}
