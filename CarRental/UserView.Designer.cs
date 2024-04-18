namespace CarRental
{
    partial class UserView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserView));
            label1 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            CarMake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CarYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CarColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label1.Location = new System.Drawing.Point(384, 479);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(437, 40);
            label1.TabIndex = 0;
            label1.Text = "Available cars to rent:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { CarMake, CarModel, CarYear, CarColor, Price });
            dataGridView1.GridColor = System.Drawing.Color.DarkOrange;
            dataGridView1.Location = new System.Drawing.Point(130, 614);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new System.Drawing.Size(1800, 500);
            dataGridView1.TabIndex = 1;
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
            // CarYear
            // 
            CarYear.HeaderText = "CarYear";
            CarYear.MinimumWidth = 10;
            CarYear.Name = "CarYear";
            CarYear.Width = 200;
            // 
            // CarColor
            // 
            CarColor.HeaderText = "CarColor";
            CarColor.MinimumWidth = 10;
            CarColor.Name = "CarColor";
            CarColor.Width = 200;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 10;
            Price.Name = "Price";
            Price.Width = 200;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Red;
            button1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            button1.Location = new System.Drawing.Point(130, 1151);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(286, 55);
            button1.TabIndex = 3;
            button1.Text = "Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Red;
            button2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            button2.Location = new System.Drawing.Point(706, 1151);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(291, 55);
            button2.TabIndex = 4;
            button2.Text = "See Our Cars";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            button3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            button3.Location = new System.Drawing.Point(1758, 1156);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(172, 50);
            button3.TabIndex = 5;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(384, 555);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search For Car Make";
            textBox1.Size = new System.Drawing.Size(604, 39);
            textBox1.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.Red;
            button4.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            button4.Location = new System.Drawing.Point(1005, 547);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(172, 55);
            button4.TabIndex = 7;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            button5.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            button5.Location = new System.Drawing.Point(1291, 544);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(172, 50);
            button5.TabIndex = 8;
            button5.Text = "Reset";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.Color.Red;
            button6.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            button6.Location = new System.Drawing.Point(1196, 1151);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(311, 55);
            button6.TabIndex = 9;
            button6.Text = "Booking History";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(2129, 448);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label2.Font = new System.Drawing.Font("Showcard Gothic", 16.125F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Green;
            label2.Location = new System.Drawing.Point(1248, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(543, 53);
            label2.TabIndex = 11;
            label2.Text = "Welcome to DV Rental";
            // 
            // UserView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(2174, 1429);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "UserView";
            Text = "Car Rent";
            Load += UserView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarMake;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

