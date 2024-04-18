using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    internal class Bitcoin : IPayStrategy
    {
        public void ProcessPayment(double amount)
        {
            if (amount > 0)
            {
                MessageBox.Show("We are processing your Bitcoin payment please wait....", "Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(1000);
                MessageBox.Show("Successfully paid and booked, thank you!","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
