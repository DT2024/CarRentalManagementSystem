using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCarRentalSystem
{
    public partial class FormManagementBooking : Form
    {
        private DatabaseSystem databaseSystem;
        public FormManagementBooking()
        {
            InitializeComponent();
            databaseSystem = new DatabaseSystem();
        }

        private void LoadBookingsPending()
        {
            // Retrieve list of bookings from the database
            List<Booking> bookings = databaseSystem.GetBookingsWithStatusZero();

            // Bind list of bookings to DataGridView
            dataGridViewPending.DataSource = bookings;
        }

        private void LoadBookingsAccepted()
        {
            // Retrieve list of bookings from the database
            List<Booking> bookings = databaseSystem.GetBookingsWithStatusOne();

            // Bind list of bookings to DataGridView
            dataGridViewAccept.DataSource = bookings;
        }

        private void LoadBookingsCancelled()
        {
            // Retrieve list of bookings from the database
            List<Booking> bookings = databaseSystem.GetBookingsWithStatusTwo();

            // Bind list of bookings to DataGridView
            dataGridViewCancel.DataSource = bookings;
        }

        private void FormManagementBooking_Load(object sender, EventArgs e)
        {
            LoadBookingsPending();
            LoadBookingsAccepted();
            LoadBookingsCancelled();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (dataGridViewPending.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to update its status.", "No Booking Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the selected booking ID from the DataGridView
            int bookingID = Convert.ToInt32(dataGridViewPending.SelectedRows[0].Cells["BookingID"].Value);

            // Update the status of the selected booking to completed (status = 1)
            bool success = databaseSystem.UpdateBookingStatusToAccepted(bookingID);

            if (success)
            {
                MessageBox.Show("Booking status updated to accepted.");
                LoadBookingsPending(); // Refresh the DataGridView
                LoadBookingsAccepted();
            }
            else
            {
                MessageBox.Show("Failed to update booking status.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the DataGridView
            if (dataGridViewPending.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to update its status.", "No Booking Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the selected booking ID from the DataGridView
            int bookingID = Convert.ToInt32(dataGridViewPending.SelectedRows[0].Cells["BookingID"].Value);

            // Update the status of the selected booking to completed (status = 1)
            bool success = databaseSystem.UpdateBookingStatusToCancelled(bookingID);

            if (success)
            {
                MessageBox.Show("Booking status updated to cancelled.");
                LoadBookingsPending(); // Refresh the DataGridView
                LoadBookingsCancelled();
            }
            else
            {
                MessageBox.Show("Failed to update booking status.");
            }
        }

        
    }
}
