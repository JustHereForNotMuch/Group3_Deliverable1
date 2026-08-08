using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group3_Deliverable1
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Basically searching for part of the playlist name
            int index = lbxPlaylist.FindString(txtSearch.Text);
            //FindString is super cool, does search and returns index, crazyy we love forums <3

            //If statement to highlight a found playlist, otherwise showing a playlist not found
            if (index != ListBox.NoMatches)
            {
                BackColor = Color.LightYellow;
                lbxPlaylist.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("Playlist not found.", "Error");

            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
