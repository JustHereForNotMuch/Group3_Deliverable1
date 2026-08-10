using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group3_Deliverable1
{
    public partial class Login : Form
    {
        string filePath = "users.txt";

        public Login()
        {
            string filePath = "users.txt";
            InitializeComponent();
        }


        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //please actually push come on
            //Trial push again

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both a username and password.");
                return;
            }

            bool loginSuccess = false;

            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("No users found. Please register first.");
                    return;
                }

                StreamReader reader = new StreamReader(filePath);
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 2)
                    {
                        if (parts[0] == username && parts[1] == password)
                        {
                            loginSuccess = true;
                            break;
                        }
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while logging in: " + ex.Message);
                return;
            }

            if (loginSuccess)
            {
                MessageBox.Show("Login successful! Welcome, " + username);

                try
                {
                    HomePage home = new HomePage(username);
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to open Home Page: " + ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp register = new SignUp();
            register.Show();
            this.Close();
        }
    }
}
