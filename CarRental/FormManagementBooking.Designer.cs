using System.Windows.Forms;
using System.Drawing;
namespace ProjectCarRentalSystem
{
    partial class FormManagementBooking
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
            panel1 = new Panel();
            label4 = new Label();
            dataGridViewPending = new DataGridView();
            btnAccept = new Button();
            label1 = new Label();
            btnCancel = new Button();
            label2 = new Label();
            dataGridViewAccept = new DataGridView();
            dataGridViewCancel = new DataGridView();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPending).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccept).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCancel).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 113, 176);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1628, 127);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(575, 39);
            label4.Name = "label4";
            label4.Size = new Size(411, 45);
            label4.TabIndex = 3;
            label4.Text = "BOOKING MANAGEMENT";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewPending
            // 
            dataGridViewPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPending.Location = new Point(44, 226);
            dataGridViewPending.Name = "dataGridViewPending";
            dataGridViewPending.RowHeadersWidth = 62;
            dataGridViewPending.Size = new Size(1545, 315);
            dataGridViewPending.TabIndex = 1;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.Green;
            btnAccept.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccept.ForeColor = SystemColors.ButtonHighlight;
            btnAccept.Location = new Point(1185, 155);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(182, 54);
            btnAccept.TabIndex = 2;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 165);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 3;
            label1.Text = "Pending";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(1407, 155);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(182, 54);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 588);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 5;
            label2.Text = "Accepted";
            // 
            // dataGridViewAccept
            // 
            dataGridViewAccept.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccept.Location = new Point(44, 646);
            dataGridViewAccept.Name = "dataGridViewAccept";
            dataGridViewAccept.ReadOnly = true;
            dataGridViewAccept.RowHeadersWidth = 62;
            dataGridViewAccept.Size = new Size(748, 324);
            dataGridViewAccept.TabIndex = 6;
            // 
            // dataGridViewCancel
            // 
            dataGridViewCancel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCancel.Location = new Point(830, 646);
            dataGridViewCancel.Name = "dataGridViewCancel";
            dataGridViewCancel.ReadOnly = true;
            dataGridViewCancel.RowHeadersWidth = 62;
            dataGridViewCancel.Size = new Size(759, 324);
            dataGridViewCancel.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(830, 588);
            label3.Name = "label3";
            label3.Size = new Size(124, 32);
            label3.TabIndex = 8;
            label3.Text = "Cancelled";
            // 
            // FormManagementBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1625, 1007);
            Controls.Add(label3);
            Controls.Add(dataGridViewCancel);
            Controls.Add(dataGridViewAccept);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(btnAccept);
            Controls.Add(dataGridViewPending);
            Controls.Add(panel1);
            Name = "FormManagementBooking";
            Text = "FormManagementBooking";
            WindowState = FormWindowState.Maximized;
            Load += FormManagementBooking_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPending).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccept).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCancel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private DataGridView dataGridViewPending;
        private Button btnAccept;
        private Label label1;
        private Button btnCancel;
        private Label label2;
        private DataGridView dataGridViewAccept;
        private DataGridView dataGridViewCancel;
        private Label label3;
    }
}