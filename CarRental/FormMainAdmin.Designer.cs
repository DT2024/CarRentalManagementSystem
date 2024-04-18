using System.Windows.Forms;
using System.Drawing;
namespace CarRentalSystem
{
    partial class FormMainAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainAdmin));
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btnCustomerManagement = new Button();
            btnBookingManagement = new Button();
            btnCarInventory = new Button();
            labelUserInfo = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 113, 176);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 230);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(519, 87);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(456, 59);
            label4.TabIndex = 1;
            label4.Text = "CAR RENTAL SYSTEM";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 45, 50);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnCustomerManagement);
            panel2.Controls.Add(btnBookingManagement);
            panel2.Controls.Add(btnCarInventory);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 230);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 1034);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 46);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(378, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(186, 1024);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(224, 74);
            button1.TabIndex = 4;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.BackColor = Color.FromArgb(54, 127, 168);
            btnCustomerManagement.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerManagement.ForeColor = SystemColors.ButtonHighlight;
            btnCustomerManagement.Location = new Point(31, 741);
            btnCustomerManagement.Margin = new Padding(4, 5, 4, 5);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(378, 125);
            btnCustomerManagement.TabIndex = 3;
            btnCustomerManagement.Text = "Customer Management";
            btnCustomerManagement.UseVisualStyleBackColor = false;
            btnCustomerManagement.Click += btnCustomerManagement_Click;
            // 
            // btnBookingManagement
            // 
            btnBookingManagement.BackColor = Color.FromArgb(54, 127, 168);
            btnBookingManagement.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookingManagement.ForeColor = SystemColors.ButtonHighlight;
            btnBookingManagement.Location = new Point(31, 563);
            btnBookingManagement.Margin = new Padding(4, 5, 4, 5);
            btnBookingManagement.Name = "btnBookingManagement";
            btnBookingManagement.Size = new Size(378, 125);
            btnBookingManagement.TabIndex = 2;
            btnBookingManagement.Text = "Booking Management";
            btnBookingManagement.UseVisualStyleBackColor = false;
            btnBookingManagement.Click += btnBookingManagement_Click;
            // 
            // btnCarInventory
            // 
            btnCarInventory.BackColor = Color.FromArgb(54, 127, 168);
            btnCarInventory.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarInventory.ForeColor = SystemColors.ButtonHighlight;
            btnCarInventory.Location = new Point(31, 381);
            btnCarInventory.Margin = new Padding(4, 5, 4, 5);
            btnCarInventory.Name = "btnCarInventory";
            btnCarInventory.Size = new Size(378, 125);
            btnCarInventory.TabIndex = 1;
            btnCarInventory.Text = "Car Inventory Management";
            btnCarInventory.UseVisualStyleBackColor = false;
            btnCarInventory.Click += btnCarInventory_Click;
            // 
            // labelUserInfo
            // 
            labelUserInfo.AutoSize = true;
            labelUserInfo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelUserInfo.ForeColor = Color.OrangeRed;
            labelUserInfo.Location = new Point(476, 266);
            labelUserInfo.Margin = new Padding(4, 0, 4, 0);
            labelUserInfo.Name = "labelUserInfo";
            labelUserInfo.Size = new Size(100, 37);
            labelUserInfo.TabIndex = 2;
            labelUserInfo.Text = "label1";
            // 
            // FormMainAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 1264);
            Controls.Add(labelUserInfo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMainAdmin";
            Text = "FormMainAdmin";
            WindowState = FormWindowState.Maximized;
            Load += FormMainAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCarInventory;
        private System.Windows.Forms.Button btnBookingManagement;
        private System.Windows.Forms.Button btnCustomerManagement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelUserInfo;
        private PictureBox pictureBox1;
    }
}