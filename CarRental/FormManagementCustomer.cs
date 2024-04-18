using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectCarRentalSystem
{
    public partial class FormManagementCustomer : Form
    {
        private DatabaseSystem databaseSystem;
        public FormManagementCustomer()
        {
            InitializeComponent();
            databaseSystem = new DatabaseSystem();
        }

        private void DisplayCustomersOnDataGridView()
        {
          
            List<Customer> customers = databaseSystem.GetAllCustomers();

            
            dataGridViewCustomers.Rows.Clear();

            
            foreach (Customer customer in customers)
            {
                // Tạo một hàng mới cho mỗi xe
                dataGridViewCustomers.Rows.Add(
                    customer.UserID,
                    customer.UserName,
                    customer.Password,
                    customer.Role,
                    customer.FirstName,
                    customer.LastName,
                    customer.Email,
                    customer.PhoneNumber,
                    customer.Address
                );
            }
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCustomers.Rows[e.RowIndex];

                
                textBoxUserID.Text = row.Cells["UserID"].Value.ToString();
                textBoxUserName.Text = row.Cells["UserName"].Value.ToString();
                textBoxPassword.Text = row.Cells["Password"].Value.ToString();
                textBoxFirstName.Text = row.Cells["FirstName"].Value.ToString();
                textBoxLastName.Text = row.Cells["LastName"].Value.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value.ToString();
                textBoxPhoneUser.Text = row.Cells["PhoneNUmber"].Value.ToString();
                textBoxAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }
        private void FormManagementCustomer_Load(object sender, EventArgs e)
        {
            // Define columns for the DataGridView
            dataGridViewCustomers.ColumnCount = 9;
            dataGridViewCustomers.Columns[0].Name = "UserID";
            dataGridViewCustomers.Columns[1].Name = "UserName";
            dataGridViewCustomers.Columns[2].Name = "Password";
            dataGridViewCustomers.Columns[3].Name = "Role";
            dataGridViewCustomers.Columns[4].Name = "FirstName";
            dataGridViewCustomers.Columns[5].Name = "LastName";
            dataGridViewCustomers.Columns[6].Name = "Email";
            dataGridViewCustomers.Columns[7].Name = "PhoneNumber";
            dataGridViewCustomers.Columns[8].Name = "Address";

            dataGridViewCustomers.CellClick += dataGridViewCustomers_CellContentClick;
            // Display cars on the DataGridView
            DisplayCustomersOnDataGridView();

        }

        private bool IsValidEmail(string email)
        {
           
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsValidPhoneNumber(string phone)
        {
            // Check if the phone number contains only digits and has up to 10 digits
            string phonePattern = @"[0-9]";

            return Regex.IsMatch(phone, phonePattern);
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhoneUser.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            // Retrieve data from text boxes
            string userName = textBoxUserName.Text;
            string role = "Customer";
            string password = textBoxPassword.Text;
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string email = textBoxEmail.Text;
            string address = textBoxAddress.Text;
            int roleId = 2;

            // Check if a customer with the same username already exists in the database
            if (databaseSystem.IsUsernameExists(userName))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                return;
            }

            // Check if the password meets the minimum length requirement
            if (password.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters long.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }


            string phoneStr = textBoxPhoneUser.Text;
            if (!IsValidPhoneNumber(phoneStr))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }

            int phoneNumber = Convert.ToInt32(phoneStr);

            // Create a new car using user inputs
            Customer customer = new CustomerBuilder()
                .SetUserName(userName)
                .SetPassword(password)
                .SetRole(role)
                .SetFirstName(firstName)
                .SetLastName(lastName)
                .SetEmail(email)
                .SetPhoneNumber(phoneNumber)
                .SetAddress(address)
                .SetRoleID(roleId)
                .Build();

            // Add the car to the database
            databaseSystem.AddCustomer(customer);

            MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields
            ClearInputFields();
            // Refresh the DataGridView to display the newly added car
            DisplayCustomersOnDataGridView();
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxUserName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhoneUser.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            
            // Retrieve the selected customer's ID
            int selectedUserID = Convert.ToInt32(dataGridViewCustomers.SelectedRows[0].Cells["UserID"].Value);

            // Retrieve modified information from input fields
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string email = textBoxEmail.Text;
            string address = textBoxAddress.Text;

            // Check if the password meets the minimum length requirement
            if (password.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters long.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            string phoneStr = textBoxPhoneUser.Text;
            if (!IsValidPhoneNumber(phoneStr))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }

            int phoneNumber = Convert.ToInt32(phoneStr);

            // Create a new customer object with the modified information
            Customer editedCustomer = new CustomerBuilder()
                .SetUserID(selectedUserID) // Ensure to set the ID of the selected customer
                .SetUserName(userName)
                .SetPassword(password)
                .SetFirstName(firstName)
                .SetLastName(lastName)
                .SetEmail(email)
                .SetPhoneNumber(phoneNumber)
                .SetAddress(address)
                .Build();

            // Update the customer record in the database
            databaseSystem.EditCustomer(editedCustomer);

            MessageBox.Show("Customer edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields
            ClearInputFields();
            // Refresh the DataGridView to reflect the changes
            DisplayCustomersOnDataGridView();
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm with the user before deleting
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Retrieve the ID of the selected customer
                int selectedUserID = Convert.ToInt32(dataGridViewCustomers.SelectedRows[0].Cells["UserID"].Value);

                // Delete the customer record from the database
                bool success = databaseSystem.DeleteCustomer(selectedUserID);

                // Display a message box based on the success of deleting the customer
                if (success)
                {
                    MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear input fields
                    ClearInputFields();
                    // Refresh the DataGridView to reflect the changes
                    DisplayCustomersOnDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed to delete customer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

            private void ClearInputFields()
            {
                textBoxUserID.Text = "";
                textBoxUserName.Text = "";
                textBoxPassword.Text = "";
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
                textBoxPhoneUser.Text = "";
                textBoxAddress.Text = "";
            }

        }
}
