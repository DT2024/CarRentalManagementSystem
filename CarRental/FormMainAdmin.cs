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

namespace CarRentalSystem
{
    public partial class FormMainAdmin : Form
    {
        private DatabaseSystem databaseSystem = new DatabaseSystem();
        private string loggedInUsername;
        public FormMainAdmin(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }

        private void FormMainAdmin_Load(object sender, EventArgs e)
        {

            string userInfo = databaseSystem.GetUserInfo(loggedInUsername);
            if (userInfo != null)
            {
                labelUserInfo.Text = "Welcome! " + userInfo;
            }
            else
            {
                labelUserInfo.Text = "Welcome!";
            }

        }

        private void btnCarInventory_Click(object sender, EventArgs e)
        {
            FormManagementCarInventory formManagementCarInventory = new FormManagementCarInventory();
            formManagementCarInventory.Show();
        }

        private void btnBookingManagement_Click(object sender, EventArgs e)
        {
            FormManagementBooking formManagementBooking = new FormManagementBooking();
            formManagementBooking.Show();
        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            FormManagementCustomer formManagementCustomer = new FormManagementCustomer();
            formManagementCustomer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
