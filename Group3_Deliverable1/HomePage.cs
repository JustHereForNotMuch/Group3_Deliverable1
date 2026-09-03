using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Group3_Deliverable1
{
    public partial class HomePage : Form
    {
        //So that it can be used in any method
        private Image[] playlistImages;
        private string loggedInUser;

        public HomePage(string username)
        {
            InitializeComponent();
            //Gives loggedInUser a value from the previous form
            loggedInUser = username;
            //Put here so that it can be pulled for when index selection changes
            playlistImages = new Image[]
            {
                Properties.Resources.Otherstarm,       // ->Feel Good Pop
                Properties.Resources.Rockmm,      // ->Banging Rock
                Properties.Resources.Recm,      // ->RnB Grooves
                Properties.Resources.FM       // ->Energising Rap
            };

            lbxPlaylist.SelectedIndexChanged += lbxPlaylist_SelectedIndexChanged;
        }
        //Phahlodi (dgv stats for the playlist)
        public class Song
        {
            public string Title { get; set; }
            public string Artist { get; set; }
            public string Album { get; set; }
            public string Duration { get; set; }

            public Song(string title, string artist, string album, string duration)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Duration = duration;
            }
        }
        // Phahlodi List to hold the songs in the playlist(list variable)
        private List<Song> playlist = new List<Song>();

        // Phahlodi Constructor
        public HomePage() 
        { 
            InitializeComponent();
        }


        private void HomePage_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Welcome " + loggedInUser + "!";

            //Phahlodi setting up the datagrid view
            dgvSongs.Columns.Clear();
            dgvSongs.Columns.Add("colName", "Song Name");
            dgvSongs.Columns.Add("colArtist", "Artist");
            dgvSongs.Columns.Add("colAlbum", "Album");
            dgvSongs.Columns.Add("colGenre", "Genre");

            //Phahlodi  Make the columns stretch evenly to fill the table width
            dgvSongs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSongs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSongs.ReadOnly = true;

            //Phahlodi ADD OBJECTS TO THE PLAYLIST LIST
            playlist.Clear();
            playlist.Add(new Song("Feel Good Inc", "Gorillaz", "Demon Days", "Pop / Alternative"));
            playlist.Add(new Song("Banging Rock", "Rockers", "Rock Hits", "Rock"));
            playlist.Add(new Song("RnB Grooves", "Smooth Vibe", "Late Night", "RnB"));
            playlist.Add(new Song("Energising Rap", "Fast Beats", "Speed Run", "Hip Hop"));

            //Phahlodi  DISPLAY SONGS IN THE DATAGRIDVIEW
            dgvSongs.Rows.Clear();
            foreach (Song song in playlist)
            {
                dgvSongs.Rows.Add(song.Title, song.Artist, song.Album, song.Duration);
            }
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

                string PlaylistName = lbxPlaylist.SelectedItem.ToString();
                
                //Goes to playlist form
                MessageBox.Show("You have selected the " + PlaylistName + " playlist, enjoy!");

                Playlist playlist = new Playlist(loggedInUser, PlaylistName);
                playlist.Show();

            }
        }

        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            //Input for name of the new playlist
            string PlaylistName = txtNewPlay.Text;                    //Playlist name being saved for use in Playlist.cs
            //Was not sure where the input was supposed to come from

            //User input is added to the listbox
            lbxPlaylist.Items.Add(PlaylistName);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //find selected index
            int index = lbxPlaylist.SelectedIndex;

            //make sure index selected lmao
            if (index != -1)
            {
                MessageBox.Show("removed: " + lbxPlaylist.Items[index]);
                //remove entry
                lbxPlaylist.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Please select an entry to delete before pressing delete", "Error");
            }
        }
    }
}
