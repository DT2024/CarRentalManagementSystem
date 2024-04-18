namespace CarRental
{
    partial class CreditCardPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditCardPrompt));
            listBox1 = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(650, 134);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(659, 388);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(28, 65);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(478, 30);
            label1.TabIndex = 1;
            label1.Text = "Please Enter Card Holder Full Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(28, 186);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(351, 30);
            label2.TabIndex = 2;
            label2.Text = "Please Enter Card Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(28, 319);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(232, 30);
            label3.TabIndex = 3;
            label3.Text = "Please Enter CVV:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(920, 65);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(132, 30);
            label4.TabIndex = 4;
            label4.Text = "Summary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(28, 428);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(399, 30);
            label5.TabIndex = 5;
            label5.Text = "Please Enter Expiration Date: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(28, 562);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(382, 30);
            label6.TabIndex = 6;
            label6.Text = "Please Enter Billing Address:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(34, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(391, 39);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(36, 249);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(391, 39);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(36, 375);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(391, 39);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(36, 483);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(391, 39);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(34, 625);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(391, 39);
            textBox5.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(650, 566);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(190, 43);
            button1.TabIndex = 12;
            button1.Text = "Print the bill";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(871, 566);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(190, 43);
            button2.TabIndex = 13;
            button2.Text = "Pay";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(1080, 566);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(129, 43);
            button3.TabIndex = 14;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (System.Drawing.Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // CreditCardPrompt
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1308, 728);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "CreditCardPrompt";
            Text = "CreditCardPrompt";
            Load += CreditCardPrompt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}