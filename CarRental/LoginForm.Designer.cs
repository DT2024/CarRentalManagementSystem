using System.Windows.Forms;
using System.Drawing;
namespace ProjectCarRentalSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            linkLabelSignup = new LinkLabel();
            label5 = new Label();
            btnExitLG = new Button();
            btnLogin = new Button();
            textBoxPassLG = new TextBox();
            textBoxUserNameLG = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 113, 176);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 821);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(68, 440);
            label2.Name = "label2";
            label2.Size = new Size(316, 37);
            label2.TabIndex = 2;
            label2.Text = "The Car Rental System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(151, 380);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 1;
            label1.Text = "WELCOME TO";
            // 
            // linkLabelSignup
            // 
            linkLabelSignup.AutoSize = true;
            linkLabelSignup.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelSignup.Location = new Point(791, 723);
            linkLabelSignup.Name = "linkLabelSignup";
            linkLabelSignup.Size = new Size(115, 25);
            linkLabelSignup.TabIndex = 20;
            linkLabelSignup.TabStop = true;
            linkLabelSignup.Text = "Signup now";
            linkLabelSignup.LinkClicked += linkLabelSignup_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(604, 723);
            label5.Name = "label5";
            label5.Size = new Size(150, 25);
            label5.TabIndex = 19;
            label5.Text = "Not a member ?";
            // 
            // btnExitLG
            // 
            btnExitLG.BackColor = Color.FromArgb(223, 76, 59);
            btnExitLG.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExitLG.Location = new Point(534, 589);
            btnExitLG.Margin = new Padding(3, 4, 3, 4);
            btnExitLG.Name = "btnExitLG";
            btnExitLG.Size = new Size(463, 62);
            btnExitLG.TabIndex = 18;
            btnExitLG.Text = "Exit";
            btnExitLG.UseVisualStyleBackColor = false;
            btnExitLG.Click += btnExitLG_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(60, 88, 155);
            btnLogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(534, 488);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(463, 62);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // textBoxPassLG
            // 
            textBoxPassLG.Location = new Point(534, 387);
            textBoxPassLG.Margin = new Padding(3, 4, 3, 4);
            textBoxPassLG.Name = "textBoxPassLG";
            textBoxPassLG.Size = new Size(463, 31);
            textBoxPassLG.TabIndex = 16;
            // 
            // textBoxUserNameLG
            // 
            textBoxUserNameLG.Location = new Point(534, 237);
            textBoxUserNameLG.Margin = new Padding(3, 4, 3, 4);
            textBoxUserNameLG.Name = "textBoxUserNameLG";
            textBoxUserNameLG.Size = new Size(463, 31);
            textBoxUserNameLG.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.MenuText;
            label6.Location = new Point(529, 313);
            label6.Name = "label6";
            label6.Size = new Size(123, 26);
            label6.TabIndex = 14;
            label6.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuText;
            label4.Location = new Point(529, 183);
            label4.Name = "label4";
            label4.Size = new Size(128, 26);
            label4.TabIndex = 13;
            label4.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(36, 84, 123);
            label3.Location = new Point(704, 49);
            label3.Name = "label3";
            label3.Size = new Size(143, 45);
            label3.TabIndex = 12;
            label3.Text = "LOGIN";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 819);
            Controls.Add(panel1);
            Controls.Add(linkLabelSignup);
            Controls.Add(label5);
            Controls.Add(btnExitLG);
            Controls.Add(btnLogin);
            Controls.Add(textBoxPassLG);
            Controls.Add(textBoxUserNameLG);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "LoginForm";
            Text = "LoginForm";
            WindowState = FormWindowState.Minimized;
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabelSignup;
        private Label label5;
        private Button btnExitLG;
        private Button btnLogin;
        private TextBox textBoxPassLG;
        private TextBox textBoxUserNameLG;
        private Label label6;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
    }
}