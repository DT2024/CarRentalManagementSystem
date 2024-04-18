//using CarRental;
using CarRental;
using CarRentalSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCarRentalSystem
{
    public partial class LoginForm : Form
    {
        private LoginFormSingleton dataLogin;
        public LoginForm()
        {
            InitializeComponent();
            dataLogin = LoginFormSingleton.Instance;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUserNameLG.Text;
            string password = textBoxPassLG.Text;

            // Check if both username and password fields are filled
            if (string.IsNullOrWhiteSpace(textBoxUserNameLG.Text) || string.IsNullOrWhiteSpace(textBoxPassLG.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
           
            bool isAuthenticated = dataLogin.AuthenticateUser(username, password);
            if (isAuthenticated)
            {
                
                int role = dataLogin.CheckRole(username, password);

                
                if (role == 1) // Admin
                {
                    MessageBox.Show("Loged in successful as an admin");
                    FormMainAdmin formAdmin = new FormMainAdmin(username);
                    formAdmin.Show();
                }
                else if (role == 2) // Customer
                {
                    MessageBox.Show("Loged in successful as a customer");
                    UserView form = new UserView();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Invalid role detected."); 
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnExitLG_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignup formSignup = new FormSignup();
            formSignup.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
