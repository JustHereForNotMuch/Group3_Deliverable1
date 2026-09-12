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
                User newUser = new User(username, password);

                // CHANGED: this is now the ONLY place users get saved -
                // straight to the XML file via serialization, using the
                // User and UserStorage classes. The old plain-text
                // StreamReader/StreamWriter code has been removed since
                // it was a separate, out-of-sync copy of the same data.
                if (UserStorage.SaveUser(newUser))
                {
                    MessageBox.Show("Registration successful! You can now log in.");

                    // FIXED: just close this SignUp dialog. Login is already
                    // open (hidden) underneath, waiting via ShowDialog() in
                    // Login.btnSignUp_Click - it will reappear automatically
                    // once this form closes. No need to create a new Login.
                    this.Close();
                }
                else
                {
                    MessageBox.Show("That username is already taken. Please choose another.");
                    // FIXED: added a return here. Before, execution kept
                    // going even after this failure message, which closed
                    // the form and opened a stray extra Login window as if
                    // registration had actually succeeded.
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while registering: " + ex.Message);
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // "Back to login" link/button, if you have one - just close
            // this dialog, same reasoning as above.
            this.Close();
        }
    }
}
