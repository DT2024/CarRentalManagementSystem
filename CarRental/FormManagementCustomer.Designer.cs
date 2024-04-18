using System.Windows.Forms;
using System.Drawing;
namespace ProjectCarRentalSystem
{
    partial class FormManagementCustomer
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
            buttonDeleteCustomer = new Button();
            buttonEditCustomer = new Button();
            buttonAddCustomer = new Button();
            textBoxPhoneUser = new TextBox();
            textBoxEmail = new TextBox();
            textBoxLastName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBoxFirstName = new TextBox();
            textBoxUserID = new TextBox();
            textBoxUserName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            textBoxPassword = new TextBox();
            label9 = new Label();
            textBoxAddress = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            dataGridViewCustomers = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // buttonDeleteCustomer
            // 
            buttonDeleteCustomer.BackColor = SystemColors.ButtonShadow;
            buttonDeleteCustomer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteCustomer.ForeColor = SystemColors.ButtonHighlight;
            buttonDeleteCustomer.Location = new Point(1512, 898);
            buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            buttonDeleteCustomer.Size = new Size(135, 54);
            buttonDeleteCustomer.TabIndex = 14;
            buttonDeleteCustomer.Text = "Delete";
            buttonDeleteCustomer.UseVisualStyleBackColor = false;
            buttonDeleteCustomer.Click += buttonDeleteCustomer_Click;
            // 
            // buttonEditCustomer
            // 
            buttonEditCustomer.BackColor = SystemColors.ButtonShadow;
            buttonEditCustomer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditCustomer.ForeColor = SystemColors.ButtonHighlight;
            buttonEditCustomer.Location = new Point(1349, 898);
            buttonEditCustomer.Name = "buttonEditCustomer";
            buttonEditCustomer.Size = new Size(135, 54);
            buttonEditCustomer.TabIndex = 13;
            buttonEditCustomer.Text = "Edit";
            buttonEditCustomer.UseVisualStyleBackColor = false;
            buttonEditCustomer.Click += buttonEditCustomer_Click;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.BackColor = SystemColors.ButtonShadow;
            buttonAddCustomer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddCustomer.ForeColor = SystemColors.ButtonHighlight;
            buttonAddCustomer.Location = new Point(1177, 898);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(135, 54);
            buttonAddCustomer.TabIndex = 12;
            buttonAddCustomer.Text = "Add";
            buttonAddCustomer.UseVisualStyleBackColor = false;
            buttonAddCustomer.Click += buttonAddCustomer_Click;
            // 
            // textBoxPhoneUser
            // 
            textBoxPhoneUser.Location = new Point(147, 473);
            textBoxPhoneUser.Name = "textBoxPhoneUser";
            textBoxPhoneUser.Size = new Size(304, 31);
            textBoxPhoneUser.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(147, 393);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(304, 31);
            textBoxEmail.TabIndex = 10;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(147, 313);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(304, 31);
            textBoxLastName.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 32);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 2;
            label2.Text = "User ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 241);
            label3.Name = "label3";
            label3.Size = new Size(120, 28);
            label3.TabIndex = 4;
            label3.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 107);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 3;
            label1.Text = "User Name:";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(147, 238);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(304, 31);
            textBoxFirstName.TabIndex = 10;
            // 
            // textBoxUserID
            // 
            textBoxUserID.Location = new Point(147, 29);
            textBoxUserID.Name = "textBoxUserID";
            textBoxUserID.ReadOnly = true;
            textBoxUserID.Size = new Size(304, 31);
            textBoxUserID.TabIndex = 10;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(147, 104);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(304, 31);
            textBoxUserName.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(27, 557);
            label8.Name = "label8";
            label8.Size = new Size(92, 28);
            label8.TabIndex = 8;
            label8.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 476);
            label7.Name = "label7";
            label7.Size = new Size(76, 28);
            label7.TabIndex = 7;
            label7.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 396);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 6;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 316);
            label5.Name = "label5";
            label5.Size = new Size(117, 28);
            label5.TabIndex = 5;
            label5.Text = "Last Name:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(textBoxPassword);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBoxAddress);
            panel2.Controls.Add(textBoxPhoneUser);
            panel2.Controls.Add(textBoxEmail);
            panel2.Controls.Add(textBoxLastName);
            panel2.Controls.Add(textBoxFirstName);
            panel2.Controls.Add(textBoxUserID);
            panel2.Controls.Add(textBoxUserName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1175, 213);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 664);
            panel2.TabIndex = 11;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(147, 170);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(304, 31);
            textBoxPassword.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(28, 173);
            label9.Name = "label9";
            label9.Size = new Size(106, 28);
            label9.TabIndex = 12;
            label9.Text = "Password:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(147, 557);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(304, 86);
            textBoxAddress.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 113, 176);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1681, 144);
            panel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(644, 49);
            label4.Name = "label4";
            label4.Size = new Size(435, 45);
            label4.TabIndex = 3;
            label4.Text = "CUSTOMER MANAGEMENT";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(36, 213);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 62;
            dataGridViewCustomers.Size = new Size(1088, 664);
            dataGridViewCustomers.TabIndex = 15;
            dataGridViewCustomers.CellContentClick += dataGridViewCustomers_CellContentClick;
            // 
            // FormManagementCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1683, 969);
            Controls.Add(dataGridViewCustomers);
            Controls.Add(buttonDeleteCustomer);
            Controls.Add(buttonEditCustomer);
            Controls.Add(buttonAddCustomer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormManagementCustomer";
            Text = "FormManagementCustomer";
            WindowState = FormWindowState.Maximized;
            Load += FormManagementCustomer_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDeleteCustomer;
        private Button buttonEditCustomer;
        private Button buttonAddCustomer;
        private TextBox textBoxPhoneUser;
        private TextBox textBoxEmail;
        private TextBox textBoxLastName;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox textBoxFirstName;
        private TextBox textBoxUserID;
        private TextBox textBoxUserName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel2;
        private Panel panel1;
        private Label label4;
        private TextBox textBoxAddress;
        private DataGridView dataGridViewCustomers;
        private TextBox textBoxPassword;
        private Label label9;
    }
}