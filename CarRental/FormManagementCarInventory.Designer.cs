using System.Windows.Forms;
using System.Drawing;
namespace ProjectCarRentalSystem
{
    partial class FormManagementCarInventory
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
            dataGridViewCars = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            comboBoxStatus = new ComboBox();
            textBoxPrice = new TextBox();
            textBoxMileage = new TextBox();
            textBoxColor = new TextBox();
            textBoxYear = new TextBox();
            textBoxMake = new TextBox();
            textBoxModel = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            buttonAddCar = new Button();
            buttonEditCar = new Button();
            buttonDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 113, 176);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1804, 143);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(536, 49);
            label4.Name = "label4";
            label4.Size = new Size(516, 45);
            label4.TabIndex = 2;
            label4.Text = "CAR INVENTORY MANAGEMENT";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Location = new Point(27, 210);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.RowHeadersWidth = 62;
            dataGridViewCars.Size = new Size(1238, 664);
            dataGridViewCars.TabIndex = 1;
            dataGridViewCars.CellContentClick += dataGridViewCars_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 32);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 2;
            label2.Text = "Car Make:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 107);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 3;
            label1.Text = "Car Model:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 181);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 4;
            label3.Text = "Year:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(comboBoxStatus);
            panel2.Controls.Add(textBoxPrice);
            panel2.Controls.Add(textBoxMileage);
            panel2.Controls.Add(textBoxColor);
            panel2.Controls.Add(textBoxYear);
            panel2.Controls.Add(textBoxMake);
            panel2.Controls.Add(textBoxModel);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1298, 210);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 573);
            panel2.TabIndex = 5;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Available", "Rented" });
            comboBoxStatus.Location = new Point(147, 494);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(304, 33);
            comboBoxStatus.TabIndex = 11;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(147, 413);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(304, 31);
            textBoxPrice.TabIndex = 10;
            // 
            // textBoxMileage
            // 
            textBoxMileage.Location = new Point(147, 333);
            textBoxMileage.Name = "textBoxMileage";
            textBoxMileage.Size = new Size(304, 31);
            textBoxMileage.TabIndex = 10;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(147, 253);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(304, 31);
            textBoxColor.TabIndex = 10;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(147, 178);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(304, 31);
            textBoxYear.TabIndex = 10;
            // 
            // textBoxMake
            // 
            textBoxMake.Location = new Point(147, 29);
            textBoxMake.Name = "textBoxMake";
            textBoxMake.Size = new Size(304, 31);
            textBoxMake.TabIndex = 10;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(147, 104);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(304, 31);
            textBoxModel.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(27, 499);
            label8.Name = "label8";
            label8.Size = new Size(76, 28);
            label8.TabIndex = 8;
            label8.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(27, 416);
            label7.Name = "label7";
            label7.Size = new Size(64, 28);
            label7.TabIndex = 7;
            label7.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 336);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 6;
            label6.Text = "Mileage:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 256);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 5;
            label5.Text = "Color:";
            // 
            // buttonAddCar
            // 
            buttonAddCar.BackColor = SystemColors.ButtonShadow;
            buttonAddCar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddCar.ForeColor = SystemColors.ButtonHighlight;
            buttonAddCar.Location = new Point(1300, 820);
            buttonAddCar.Name = "buttonAddCar";
            buttonAddCar.Size = new Size(135, 54);
            buttonAddCar.TabIndex = 6;
            buttonAddCar.Text = "Add";
            buttonAddCar.UseVisualStyleBackColor = false;
            buttonAddCar.Click += buttonAddCar_Click;
            // 
            // buttonEditCar
            // 
            buttonEditCar.BackColor = SystemColors.ButtonShadow;
            buttonEditCar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditCar.ForeColor = SystemColors.ButtonHighlight;
            buttonEditCar.Location = new Point(1472, 820);
            buttonEditCar.Name = "buttonEditCar";
            buttonEditCar.Size = new Size(135, 54);
            buttonEditCar.TabIndex = 7;
            buttonEditCar.Text = "Edit";
            buttonEditCar.UseVisualStyleBackColor = false;
            buttonEditCar.Click += buttonEditCar_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.ButtonShadow;
            buttonDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonDelete.Location = new Point(1635, 820);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(135, 54);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FormManagementCarInventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1803, 904);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEditCar);
            Controls.Add(buttonAddCar);
            Controls.Add(panel2);
            Controls.Add(dataGridViewCars);
            Controls.Add(panel1);
            Name = "FormManagementCarInventory";
            Text = "FormManagementCarInventory";
            WindowState = FormWindowState.Maximized;
            Load += FormManagementCarInventory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private DataGridView dataGridViewCars;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private TextBox textBoxMake;
        private TextBox textBoxModel;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxStatus;
        private TextBox textBoxPrice;
        private TextBox textBoxMileage;
        private TextBox textBoxColor;
        private TextBox textBoxYear;
        private Button buttonAddCar;
        private Button buttonEditCar;
        private Button buttonDelete;
    }
}