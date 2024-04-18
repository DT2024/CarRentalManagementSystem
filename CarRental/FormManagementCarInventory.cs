using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjectCarRentalSystem
{
    public partial class FormManagementCarInventory : Form
    {
        private DatabaseSystem databaseSystem;
        public FormManagementCarInventory()
        {
            InitializeComponent();
            databaseSystem = new DatabaseSystem();
        }

        private void ClearInputFields()
        {
            textBoxMake.Text = "";
            textBoxModel.Text = "";
            textBoxYear.Text = "";
            textBoxColor.Text = "";
            textBoxMileage.Text = "";
            textBoxPrice.Text = "";
            comboBoxStatus.SelectedIndex = -1;
        }

        private void DisplayCarsOnDataGridView()
        {
           
            List<Car> cars = databaseSystem.GetAllCars();

            dataGridViewCars.Rows.Clear();

          
            foreach (Car car in cars)
            {
                string statusText = car.Status == 0 ? "Rented" : "Available";
                
                dataGridViewCars.Rows.Add(
                    car.CarID,
                    car.Make,
                    car.Model,
                    car.Year,
                    car.Color,
                    car.Mileage,
                    car.Price,
                    statusText
                );
            }
        }

        private void dataGridViewCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCars.Rows[e.RowIndex];

            
                textBoxMake.Text = row.Cells["Make"].Value.ToString();
                textBoxModel.Text = row.Cells["Model"].Value.ToString();
                textBoxYear.Text = row.Cells["Year"].Value.ToString();
                textBoxColor.Text = row.Cells["Color"].Value.ToString();
                textBoxMileage.Text = row.Cells["Mileage"].Value.ToString();
                textBoxPrice.Text = row.Cells["Price"].Value.ToString();
                comboBoxStatus.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        }

        private void FormManagementCarInventory_Load(object sender, EventArgs e)
        {
            // Define columns for the DataGridView
            dataGridViewCars.ColumnCount = 8;
            dataGridViewCars.Columns[0].Name = "CarID";
            dataGridViewCars.Columns[1].Name = "Make";
            dataGridViewCars.Columns[2].Name = "Model";
            dataGridViewCars.Columns[3].Name = "Year";
            dataGridViewCars.Columns[4].Name = "Color";
            dataGridViewCars.Columns[5].Name = "Mileage";
            dataGridViewCars.Columns[6].Name = "Price";
            dataGridViewCars.Columns[7].Name = "Status";

            dataGridViewCars.CellClick += dataGridViewCars_CellContentClick;
            // Display cars on the DataGridView
            DisplayCarsOnDataGridView();
            //DisplayCarsOnDataGridView();
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled in
            if (string.IsNullOrWhiteSpace(textBoxMake.Text) ||
                string.IsNullOrWhiteSpace(textBoxModel.Text) ||
                string.IsNullOrWhiteSpace(textBoxYear.Text) ||
                string.IsNullOrWhiteSpace(textBoxColor.Text) ||
                string.IsNullOrWhiteSpace(textBoxMileage.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
                comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Retrieve car information from user inputs
            string make = textBoxMake.Text;
            string model = textBoxModel.Text;
            int year;
            if (!int.TryParse(textBoxYear.Text, out year) || year >= DateTime.Now.Year)
            {
                MessageBox.Show("Please enter a valid year that is less than the current year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string color = textBoxColor.Text;
            // Validate mileage
            float mileage;
            if (!float.TryParse(textBoxMileage.Text, out mileage))
            {
                MessageBox.Show("Please enter a valid mileage (numeric value).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate price
            float price;
            if (!float.TryParse(textBoxPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price (numeric value).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int status = 1;
            if (comboBoxStatus.SelectedItem != null)
            {
                if (comboBoxStatus.SelectedItem.ToString() == "Rented")
                {
                    status = 0;
                }
            }

            // Check if a car with the same details already exists in the database
            bool carExists = databaseSystem.GetAllCars().Any(car =>
                car.Make.Equals(make, StringComparison.OrdinalIgnoreCase) &&
                car.Model.Equals(model, StringComparison.OrdinalIgnoreCase) &&
                car.Year == year &&
                car.Color.Equals(color, StringComparison.OrdinalIgnoreCase) &&
                car.Mileage == mileage &&
                car.Price == price &&
                car.Status == status);

            if (carExists)
            {
                MessageBox.Show("A car with the same details already exists in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new car using user inputs
            Car car = new CarBuilder()
                .SetMake(make)
                .SetModel(model)
                .SetYear(year)
                .SetColor(color)
                .SetMileage(mileage)
                .SetPrice(price)
                .SetStatus(status)
                .Build();

            // Add the car to the database
            databaseSystem.AddCar(car);

            MessageBox.Show("Car added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields
            ClearInputFields();
            // Refresh the DataGridView to display the newly added car
            DisplayCarsOnDataGridView();
        }

        private void buttonEditCar_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a car to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve the selected car's ID
            int selectedCarID = Convert.ToInt32(dataGridViewCars.SelectedRows[0].Cells["CarID"].Value);

            // Retrieve modified information from input fields
            string make = textBoxMake.Text;
            string model = textBoxModel.Text;
            int year;
            if (!int.TryParse(textBoxYear.Text, out year) || year >= DateTime.Now.Year)
            {
                MessageBox.Show("Please enter a valid year that is less than the current year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string color = textBoxColor.Text;
            float mileage;
            if (!float.TryParse(textBoxMileage.Text, out mileage))
            {
                MessageBox.Show("Please enter a valid mileage (numeric value).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float price;
            if (!float.TryParse(textBoxPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price (numeric value).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int status = comboBoxStatus.SelectedItem != null && comboBoxStatus.SelectedItem.ToString() == "Rented" ? 0 : 1;

            // Create a new car object with the modified information
            Car editedCar = new CarBuilder()
                .SetID(selectedCarID) // Ensure to set the ID of the selected car
                .SetMake(make)
                .SetModel(model)
                .SetYear(year)
                .SetColor(color)
                .SetMileage(mileage)
                .SetPrice(price)
                .SetStatus(status)
                .Build();

            // Update the car record in the database
            databaseSystem.EditCar(editedCar);

            MessageBox.Show("Car edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields
            ClearInputFields();
            // Refresh the DataGridView to reflect the changes
            DisplayCarsOnDataGridView();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a car to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm with the user before deleting
            DialogResult result = MessageBox.Show("Are you sure you want to delete this car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Retrieve the ID of the selected car
                int selectedCarID = Convert.ToInt32(dataGridViewCars.SelectedRows[0].Cells["CarID"].Value);

                // Delete the car record from the database
                bool success = databaseSystem.DeleteCar(selectedCarID);

                // Display a message box based on the success of deleting the car
                if (success)
                {
                    MessageBox.Show("Car deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear input fields
                    ClearInputFields();
                    // Refresh the DataGridView to reflect the changes
                    DisplayCarsOnDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed to delete car. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
