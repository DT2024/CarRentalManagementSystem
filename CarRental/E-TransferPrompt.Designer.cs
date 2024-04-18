namespace CarRental
{
    partial class E_TransferPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_TransferPrompt));
            listBox1 = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
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
            listBox1.Location = new System.Drawing.Point(573, 104);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(698, 420);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(32, 104);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(507, 30);
            label1.TabIndex = 1;
            label1.Text = "Please enter E-Transfer Email Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(35, 248);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(311, 30);
            label2.TabIndex = 2;
            label2.Text = "Please enter Full Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(35, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(406, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(43, 309);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(406, 39);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(867, 34);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 30);
            label3.TabIndex = 5;
            label3.Text = "Summary";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(573, 582);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(154, 46);
            button1.TabIndex = 6;
            button1.Text = "Print the bill";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(812, 582);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(150, 46);
            button2.TabIndex = 7;
            button2.Text = "Pay";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(1020, 582);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(150, 46);
            button3.TabIndex = 8;
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
            // E_TransferPrompt
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1283, 727);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "E_TransferPrompt";
            Text = "E_TransferPrompt";
            Load += E_TransferPrompt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}