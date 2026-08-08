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
        string filePath = "users.txt";
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnAccCreate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            try
            {
                
                if (File.Exists(filePath))
                {
                    StreamReader reader = new StreamReader(filePath);
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length == 2 && parts[0] == username)
                        {
                            MessageBox.Show("That username is already taken. Please choose another.");
                            reader.Close();
                            return;
                        }
                    }

                    reader.Close();
                }

               
                StreamWriter writer = new StreamWriter(filePath, true);
                writer.WriteLine(username + "," + password);
                writer.Close();

                MessageBox.Show("Registration successful! You can now log in.");

                
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
