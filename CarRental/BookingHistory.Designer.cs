namespace CarRental
{
    partial class BookingHistory
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            CarMake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            BookingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PickUpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PickUpLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { CarMake, CarModel, TotalPrice, BookingDate, PickUpDate, ReturnDate, PickUpLocation });
            dataGridView1.Location = new System.Drawing.Point(42, 343);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new System.Drawing.Size(1482, 308);
            dataGridView1.TabIndex = 0;
            // 
            // CarMake
            // 
            CarMake.HeaderText = "CarMake";
            CarMake.MinimumWidth = 10;
            CarMake.Name = "CarMake";
            CarMake.Width = 200;
            // 
            // CarModel
            // 
            CarModel.HeaderText = "CarModel";
            CarModel.MinimumWidth = 10;
            CarModel.Name = "CarModel";
            CarModel.Width = 200;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "TotalPrice";
            TotalPrice.MinimumWidth = 10;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Width = 200;
            // 
            // BookingDate
            // 
            BookingDate.HeaderText = "BookingDate";
            BookingDate.MinimumWidth = 10;
            BookingDate.Name = "BookingDate";
            BookingDate.Width = 200;
            // 
            // PickUpDate
            // 
            PickUpDate.HeaderText = "PickUpDate";
            PickUpDate.MinimumWidth = 10;
            PickUpDate.Name = "PickUpDate";
            PickUpDate.Width = 200;
            // 
            // ReturnDate
            // 
            ReturnDate.HeaderText = "ReturnDate";
            ReturnDate.MinimumWidth = 10;
            ReturnDate.Name = "ReturnDate";
            ReturnDate.Width = 200;
            // 
            // PickUpLocation
            // 
            PickUpLocation.HeaderText = "ReturnLocation";
            PickUpLocation.MinimumWidth = 10;
            PickUpLocation.Name = "PickUpLocation";
            PickUpLocation.Width = 200;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(42, 695);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(598, 49);
            button1.TabIndex = 1;
            button1.Text = "Cancel Booking";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(926, 695);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(598, 49);
            button2.TabIndex = 2;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(629, 225);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(355, 46);
            label1.TabIndex = 3;
            label1.Text = "Booking History";
            // 
            // BookingHistory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1577, 958);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "BookingHistory";
            Text = "BookingHistory";
            Load += BookingHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn CarMake;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickUpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickUpLocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}