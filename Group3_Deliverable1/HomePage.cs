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
        private Image[] playlistImages;
        private string loggedInUser;
        public HomePage(string username)
        {
            InitializeComponent();

            loggedInUser = username;
            playlistImages = new Image[]
            {
                Properties.Resources.Newart,       // ->Feel Good Pop
                Properties.Resources.NewAnime,      // ->Banging Rock
                Properties.Resources.newUPCON,      // ->RnB Grooves
                Properties.Resources.NewAlum       // ->Energising Rap
            };

            lbxPlaylist.SelectedIndexChanged += lbxPlaylist_SelectedIndexChanged;
        }

        private void lbxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Shows correct image for playlist
            ShowImageForIndex(lbxPlaylist.SelectedIndex, pbxLeft, playlistImages);
        }

        private void ShowImageForIndex(int index, PictureBox box, Image[] images)
        {
            //Index valid?? Question mark???
            if (index < 0 || index >= images.Length)
                return;
            //Setting image for playlist
            SetPlaylistImage(box, images[index]);
        }

        private void SetPlaylistImage(PictureBox box, Image image)
        {
            //Set image as picbox yayaya
            box.BackgroundImage = image; 
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Basically searching for part of the playlist name
            int index = lbxPlaylist.FindString(txtSearch.Text);
            //FindString is super cool, does search and returns index, crazyy we love forums <3

            //If statement to highlight a found playlist, otherwise showing a playlist not found
            if (index != ListBox.NoMatches)
            {
                lbxPlaylist.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("Playlist not found.", "Error");
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Flag to check if a playlist was selected

            if (lbxPlaylist.SelectedIndex == -1)
            {
                //No item selected
                MessageBox.Show("Please select a playlist!");
            }
            else
            {

                SignUp signup = new SignUp();
                signup.ShowDialog();
                string PlaylistName = lbxPlaylist.SelectedIndex.ToString();
               


                //Goes to playlist form
                MessageBox.Show("You have selected the" + PlaylistName + "playlist,enjoy!");

                Playlist playlist = new Playlist(username, PlaylistName);
                playlist.Show();

            }
        }

        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            //Input for name of the new playlist
            string PlaylistName = txtSearch.Text;                    //Playlist name being saved for use in Playlist.cs
            //Was not sure where the input was supposed to come from

            //User input is added to the listbox
            lbxPlaylist.Items.Add(PlaylistName);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            //lblUser is the label control on your form
            //It will show a personalised message using the stored username
            lblUser.Text = "Welcome " + loggedInUser + "!";
        }
    }
}
