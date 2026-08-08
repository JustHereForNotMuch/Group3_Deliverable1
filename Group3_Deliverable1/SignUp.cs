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
    public partial class SignUp : Form
    {
        // Stores the name of the text file where user registration details are saved.
        string filePath = "users.txt";
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnAccCreate_Click(object sender, EventArgs e)
        {
            // Gets the username and password entered by the user.
            // Trim() removes any unnecessary spaces before or after the input.

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Checks that the user has entered both a username and password.
            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            try
            {
                // Checks whether the users file already exists.
                if (File.Exists(filePath))
                {
                    // Opens the file so that the existing usernames can be checked.
                    StreamReader reader = new StreamReader(filePath);
                    string line;

                    
                    // Reads the file one line at a time until the end of the file.
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        // Checks whether the username already exists in the file.
                        if (parts.Length == 2 && parts[0] == username)
                        {
                            MessageBox.Show("That username is already taken. Please choose another.");
                            // Closes the file before leaving the method.
                            reader.Close();
                            return;
                        }
                    }

                    // Closes the file after checking all existing users.
                    reader.Close();
                }

                // Opens the users file in append mode so that existing users are not overwritten.
                StreamWriter writer = new StreamWriter(filePath, true);

                // Saves the new username and password to the file.
                writer.WriteLine(username + "," + password);

                // Closes the file after writing the new user's details.
                writer.Close();

                MessageBox.Show("Registration successful! You can now log in.");

                // Opens the Login form after successful registration.
                Login login = new Login();
                login.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while registering: " + ex.Message);
            }
        }
    }
}
