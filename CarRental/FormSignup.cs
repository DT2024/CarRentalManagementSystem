using ProjectCarRentalSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class FormSignup : Form
    {
        public FormSignup()
        {
            InitializeComponent();
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

        private void btnSigup_Click(object sender, EventArgs e)
        {
            // Check if any required fields are empty
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) || string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxUserName.Text) || string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxPass.Text) || string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
                string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Please fill out all required fields.");
                return;
            }


            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string username = textBoxUserName.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPass.Text;

            string address = textBoxAddress.Text;
            string role = "Customer";
            int roleId = 2;

            // Check if the username already exists
            DatabaseSystem database = new DatabaseSystem();
            if (database.IsUsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Check if the password meets the minimum length requirement
            if (password.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters long.");
                return;
            }

            string phoneStr = textBoxPhone.Text;
            if (!IsValidPhoneNumber(phoneStr))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }
            int phone = Convert.ToInt32(phoneStr);

            // Instantiate the signup view based on user selection
            SignupViewFactory factory = new SignupViewFactory();
            ISignupView signupView = factory.CreateSignupView(firstName, lastName, username, email, password, phone, address, role, roleId);

            // Register the user
            bool success = signupView.RegisterUser();
            if (success)
            {
                MessageBox.Show("User registered successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to register user. Please try again.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSignup_Load(object sender, EventArgs e)
        {

        }
    }
}