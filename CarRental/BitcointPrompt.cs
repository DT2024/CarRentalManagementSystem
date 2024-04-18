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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRental
{
    public partial class BitcointPrompt : Form
    {
        private string bookingSummary;
        private decimal totalAmount;  

        public BitcointPrompt(string bookingSummary, decimal totalAmount)
        {
            InitializeComponent();
            this.bookingSummary = bookingSummary;
            this.totalAmount = totalAmount;


        }

        private void BitcointPrompt_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(bookingSummary);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string link = textBox1.Text;

            if (string.IsNullOrWhiteSpace(link))

            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Bitcoin validated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
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
    }
}
