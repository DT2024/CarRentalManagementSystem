using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class E_TransferPrompt : Form
    {
        private string bookingSummary;
        private decimal totalAmount;
        public E_TransferPrompt(string bookingSummary, decimal totalAmount)
        {
            InitializeComponent();
            this.bookingSummary = bookingSummary;
            this.totalAmount = totalAmount;
        }

        private void E_TransferPrompt_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(bookingSummary);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string fullname = textBox2.Text;
            if (string.IsNullOrWhiteSpace(fullname) || string.IsNullOrWhiteSpace(email))

            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate fullname format
            if (!IsAlphabetic(fullname))
            {
                MessageBox.Show("Please enter a valid name without numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("E-Transfer validated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
           
        }

        private bool IsValidEmail(string email)
        {
            // Regular expression for email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }


        private bool IsAlphabetic(string input)
        {
            return input.All(char.IsLetter);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
