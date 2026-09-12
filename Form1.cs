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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Group3_Deliverable1
{
    public partial class Login : Form
    {
        string filePath = "users.txt";
        public Login()
        {  
            InitializeComponent();
        }
        public string Username { get; private set; }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both a username and password.");
                return;
            }

            // Read & deserialize shared user list
            List<User> users = UserStorage.LoadUsers();

            bool loginSuccess = users.Exists(u => u.Username == username && u.Password == password);

            if (loginSuccess)
            {
                MessageBox.Show("Login successful! Welcome, " + username);
                Username = username;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }


        }
           
        

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (SignUp register = new SignUp())
            {
                register.ShowDialog();
            }
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
