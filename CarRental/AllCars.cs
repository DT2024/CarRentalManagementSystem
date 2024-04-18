using CarRental.Models.Entities;
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
    public partial class AllCars : Form
    {
        private readonly DatabaseCarRentalSystemContext dbContext;
        public AllCars()
        {
            InitializeComponent();
            dbContext = new DatabaseCarRentalSystemContext();
            LoadAvailableCars();
        }

        private void AllCars_Load(object sender, EventArgs e)
        {

        }
        private void LoadAvailableCars()
        {
            try
            {
                // Query to select cars with status displayed as "Available" or "Rented"
                var query = from car in dbContext.Cars
                            select new
                            {
                                CarMake = car.CarMake,
                                Model = car.CarModel,
                                Color = car.CarColor,
                                Mileage = car.CarMileage,
                                Price = car.CarPrice,
                                Status = car.Status == 1 ? "Available" : "Rented",
                                Year = car.CarYear
                            };

                // Clear existing rows in the DataGridView
                dataGridView1.Rows.Clear();

                // Add each car to the DataGridView
                foreach (var car in query)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells[0].Value = car.CarMake;
                    dataGridView1.Rows[rowIndex].Cells[1].Value = car.Model;
                    dataGridView1.Rows[rowIndex].Cells[2].Value = car.Color;
                    dataGridView1.Rows[rowIndex].Cells[3].Value = car.Mileage;
                    dataGridView1.Rows[rowIndex].Cells[4].Value = car.Price;
                    dataGridView1.Rows[rowIndex].Cells[5].Value = car.Status;
                    dataGridView1.Rows[rowIndex].Cells[6].Value = car.Year;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading cars. Please try again later.");
            }
        }
    }
}