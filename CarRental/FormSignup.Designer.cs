using System.Windows.Forms;
using System.Drawing;
namespace CarRentalSystem
{
    partial class FormSignup
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
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxUserName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPass = new TextBox();
            btnSigup = new Button();
            button2 = new Button();
            label7 = new Label();
            textBoxPhone = new TextBox();
            label8 = new Label();
            textBoxAddress = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 113, 176);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 60);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(247, 18);
            label1.Name = "label1";
            label1.Size = new Size(180, 44);
            label1.TabIndex = 1;
            label1.Text = "SIGN UP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(51, 154);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(51, 220);
            label6.Name = "label6";
            label6.Size = new Size(140, 32);
            label6.TabIndex = 5;
            label6.Text = "Last Name:";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Mongolian Baiti", 9F);
            textBoxFirstName.Location = new Point(201, 154);
            textBoxFirstName.Margin = new Padding(3, 2, 3, 2);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(384, 35);
            textBoxFirstName.TabIndex = 6;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Mongolian Baiti", 9F);
            textBoxLastName.Location = new Point(203, 215);
            textBoxLastName.Margin = new Padding(3, 2, 3, 2);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(382, 35);
            textBoxLastName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(51, 284);
            label3.Name = "label3";
            label3.Size = new Size(146, 32);
            label3.TabIndex = 8;
            label3.Text = "User Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(49, 348);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(51, 416);
            label5.Name = "label5";
            label5.Size = new Size(129, 32);
            label5.TabIndex = 10;
            label5.Text = "Password:";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Font = new Font("Mongolian Baiti", 9F);
            textBoxUserName.Location = new Point(201, 279);
            textBoxUserName.Margin = new Padding(3, 2, 3, 2);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(384, 35);
            textBoxUserName.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Mongolian Baiti", 9F);
            textBoxEmail.Location = new Point(203, 343);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(382, 35);
            textBoxEmail.TabIndex = 12;
            // 
            // textBoxPass
            // 
            textBoxPass.Font = new Font("Mongolian Baiti", 9F);
            textBoxPass.Location = new Point(203, 411);
            textBoxPass.Margin = new Padding(3, 2, 3, 2);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(382, 35);
            textBoxPass.TabIndex = 13;
            // 
            // btnSigup
            // 
            btnSigup.BackColor = Color.FromArgb(60, 88, 155);
            btnSigup.Font = new Font("Microsoft Sans Serif", 10F);
            btnSigup.Location = new Point(55, 603);
            btnSigup.Margin = new Padding(3, 2, 3, 2);
            btnSigup.Name = "btnSigup";
            btnSigup.Size = new Size(532, 57);
            btnSigup.TabIndex = 14;
            btnSigup.Text = "Sign Up";
            btnSigup.UseVisualStyleBackColor = false;
            btnSigup.Click += btnSigup_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(223, 76, 59);
            button2.Font = new Font("Microsoft Sans Serif", 10F);
            button2.Location = new Point(55, 683);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(532, 55);
            button2.TabIndex = 15;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(51, 486);
            label7.Name = "label7";
            label7.Size = new Size(191, 32);
            label7.TabIndex = 16;
            label7.Text = "Phone number:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Mongolian Baiti", 9F);
            textBoxPhone.Location = new Point(203, 481);
            textBoxPhone.Margin = new Padding(3, 2, 3, 2);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(382, 35);
            textBoxPhone.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(55, 552);
            label8.Name = "label8";
            label8.Size = new Size(113, 32);
            label8.TabIndex = 18;
            label8.Text = "Address:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Mongolian Baiti", 9F);
            textBoxAddress.Location = new Point(203, 547);
            textBoxAddress.Margin = new Padding(3, 2, 3, 2);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(382, 35);
            textBoxAddress.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Uighur", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(49, 82);
            label9.Name = "label9";
            label9.Size = new Size(285, 38);
            label9.TabIndex = 20;
            label9.Text = "Please fill all required fields";
            // 
            // FormSignup
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 771);
            Controls.Add(label9);
            Controls.Add(textBoxAddress);
            Controls.Add(label8);
            Controls.Add(textBoxPhone);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(btnSigup);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Mongolian Baiti", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSignup";
            Text = "FormSignup";
            Load += FormSignup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button btnSigup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label9;
    }
}