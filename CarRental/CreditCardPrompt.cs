using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class CreditCardPrompt : Form
    {
        private string bookingSummary;
        private decimal totalAmount;  
        public CreditCardPrompt(string bookingSummary, decimal totalAmount)
        {
            InitializeComponent();
            this.bookingSummary = bookingSummary;
            this.totalAmount = totalAmount;
        }

        private void CreditCardPrompt_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(bookingSummary);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string fullName = textBox1.Text;
            string creditNumber = textBox2.Text;
            string cvv = textBox3.Text;
            string expirationDate = textBox4.Text;
            string billingAddress = textBox5.Text;

         
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(creditNumber) ||
                string.IsNullOrWhiteSpace(cvv) || string.IsNullOrWhiteSpace(expirationDate) ||
                string.IsNullOrWhiteSpace(billingAddress))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate card number
            if (!IsNumeric(creditNumber) || creditNumber.Length != 12)
            {
                MessageBox.Show("Please enter a valid 12-digit card number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate CVV
            if (!IsNumeric(cvv) || cvv.Length != 3)
            {
                MessageBox.Show("Please enter a valid 3-digit CVV.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate name
            if (!IsAlphabetic(fullName))
            {
                MessageBox.Show("Please enter a valid name without numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Credit card validated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            float yPos = 0f;
            int count = 0;
            string line = null;

          
            foreach (var item in listBox1.Items)
            {
                yPos = count * e.Graphics.MeasureString(item.ToString(), listBox1.Font).Height;
                line = item.ToString();

                e.Graphics.DrawString(line, listBox1.Font, Brushes.Black, 10, yPos);
                count++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private bool IsNumeric(string input)
        {
            return input.All(char.IsDigit);
        }

        
        private bool IsAlphabetic(string input)
        {
            return input.All(char.IsLetter);
        }
    }
}
    
    
