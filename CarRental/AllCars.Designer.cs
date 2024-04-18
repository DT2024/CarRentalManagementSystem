namespace CarRental
{
    partial class AllCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllCars));
            dataGridView1 = new System.Windows.Forms.DataGridView();
            CarMake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CarColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CarMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CarPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CarYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { CarMake, CarModel, CarColor, CarMileage, CarPrice, Status, CarYear });
            dataGridView1.Location = new System.Drawing.Point(183, 708);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new System.Drawing.Size(1500, 800);
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
            // CarColor
            // 
            CarColor.HeaderText = "CarColor";
            CarColor.MinimumWidth = 10;
            CarColor.Name = "CarColor";
            CarColor.Width = 200;
            // 
            // CarMileage
            // 
            CarMileage.HeaderText = "CarMileage";
            CarMileage.MinimumWidth = 10;
            CarMileage.Name = "CarMileage";
            CarMileage.Width = 200;
            // 
            // CarPrice
            // 
            CarPrice.HeaderText = "CarPrice";
            CarPrice.MinimumWidth = 10;
            CarPrice.Name = "CarPrice";
            CarPrice.Width = 200;
            // 
            // Status
            // 
            Status.HeaderText = "Availability";
            Status.MinimumWidth = 10;
            Status.Name = "Status";
            Status.Width = 200;
            // 
            // CarYear
            // 
            CarYear.HeaderText = "CarYear";
            CarYear.MinimumWidth = 10;
            CarYear.Name = "CarYear";
            CarYear.Width = 200;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(211, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(330, 233);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(297, 446);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(330, 233);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1154, 446);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(330, 233);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(1210, 128);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(330, 233);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(717, 128);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(330, 233);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            label1.Font = new System.Drawing.Font("Showcard Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(708, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(339, 46);
            label1.TabIndex = 7;
            label1.Text = "Our Favourites";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(730, 639);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(289, 40);
            label2.TabIndex = 8;
            label2.Text = "All of Our Cars\r\n";
            // 
            // AllCars
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(2274, 1559);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Name = "AllCars";
            Text = "AllCars";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += AllCars_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarMake;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarYear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}