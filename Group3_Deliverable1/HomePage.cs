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

        // Luqmaan: path to the file that stores THIS user's list of playlist names
        private string playlistsFilePath;

        // Luqmaan: path to the file that stores THIS user's favourite playlist names
        private string favouritesFilePath;

        //Husna: Adding a recently played list with a cap for how many playlists :3
        private List<string> recentlyPlayed = new List<string>();
        private string recentlyPlayedFilePath;
        private const int MaxRecentlyPlayed = 3;

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

            // Luqmaan: each user gets their own playlists file
            playlistsFilePath = loggedInUser + "_playlists.txt";

            favouritesFilePath = loggedInUser + "_favourites.txt";
            recentlyPlayedFilePath = loggedInUser + "_recentlyplayed.txt";

            lbxPlaylist.SelectedIndexChanged += lbxPlaylist_SelectedIndexChanged;
        }
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

            // Luqmaan: load this user's saved playlists into the list box
            LoadUserPlaylists();

            LoadFavourites();
            RecentlyPlayed();

            // calculate and display the 3 statistical insights
            UpdateStatistics();

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

        // Luqmaan: reads this user's playlist names from their file into the ListBox.
        // If they've never had one before, it gives them the 4 starter playlists
        // and saves that as their file for next time
        private void LoadUserPlaylists()
        {
            lbxPlaylist.Items.Clear();

            if (File.Exists(playlistsFilePath))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(playlistsFilePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Trim() != "")
                            {
                                lbxPlaylist.Items.Add(line);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading your playlists: " + ex.Message);
                }
            }
            else
            {
                // First time this user has opened Home - give them starter playlists
                lbxPlaylist.Items.Add("Feel Good Pop");
                lbxPlaylist.Items.Add("Banging Rock");
                lbxPlaylist.Items.Add("RnB Grooves");
                lbxPlaylist.Items.Add("Energising Rap");
                SaveUserPlaylists();
            }
        }

        // Luqmaan: writes whatever is currently in the ListBox out to this user's file
        private void SaveUserPlaylists()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(playlistsFilePath, false))
                {
                    foreach (object item in lbxPlaylist.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving your playlists: " + ex.Message);
            }
        }

        // calculates the 3 statistical insights and displays them in labels.
        // Called whenever something that could change the numbers happens.
        private void UpdateStatistics()
        {
            try
            {
                // Insight 1: total number of playlists
                int totalPlaylists = lbxPlaylist.Items.Count;
                lblTotalPlaylists.Text = "Total Playlists: " + totalPlaylists;

                // Insight 2: total number of favourite playlists
                int totalFavourites = lstFavourites.Items.Count;
                lblTotalFavourites.Text = "Favourite Playlists: " + totalFavourites;

                //  Insight 3 is now "Average Tracks per Playlist"
                
                string[] allUserFiles = Directory.GetFiles(".", loggedInUser + "_*.txt");

                int totalTracksAcrossAll = 0;
                int playlistFileCount = 0;

                for (int i = 0; i < allUserFiles.Length; i++)
                {
                    string file = allUserFiles[i];

                    // Skip files that aren't actual playlist song files
                    if (file.EndsWith("_favourites.txt") ||
                        file.EndsWith("_recentlyplayed.txt") ||
                        file.EndsWith("_playlists.txt"))
                    {
                        continue;
                    }

                    string[] lines = File.ReadAllLines(file);
                    totalTracksAcrossAll += lines.Length;
                    playlistFileCount++;
                }

                if (playlistFileCount > 0)
                {
                    // Round to 1 decimal place 
                    double average = (double)totalTracksAcrossAll / playlistFileCount;
                    lblAverageTracks.Text = "Average Tracks per Playlist: " + average.ToString("0.0");
                }
                else
                {
                    lblAverageTracks.Text = "Average Tracks per Playlist: 0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating statistics: " + ex.Message);
            }
        }

        private void LoadFavourites()
        {
            lstFavourites.Items.Clear();

            if (File.Exists(favouritesFilePath))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(favouritesFilePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Trim() != "")
                            {
                                lstFavourites.Items.Add(line);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading favourites: " + ex.Message);
                }
            }
        }   

        // Luqmaan: saves whatever is currently in lstFavourites back to the file
        private void SaveFavourites()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(favouritesFilePath, false))
                {
                    foreach (object item in lstFavourites.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving favourites: " + ex.Message);
            }
        }
        //Husna: I'm using the same method as Luqmaan in this as it works well and is easy to read
        private void RecentlyPlayed()
        {
            lbxRecentlyPlayed.Items.Clear();   // was lstFavourites
            recentlyPlayed.Clear();

            if (File.Exists(recentlyPlayedFilePath))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(recentlyPlayedFilePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Trim() != "")
                            {
                                recentlyPlayed.Add(line);
                                lbxRecentlyPlayed.Items.Add(line);   // was lstFavourites
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading recently played: " + ex.Message);
                }
            }
            
        }
        private void SaveRecentlyPlayed()
        {
            try
            {
                //Checks to see if file path exists
                using (StreamWriter writer = new StreamWriter(recentlyPlayedFilePath, false))
                {
                    for (int i = 0; i < recentlyPlayed.Count; i++)
                    {
                        writer.WriteLine(recentlyPlayed[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving recently played: " + ex.Message);
            }
        }

        private void AddToRecentlyPlayed(string playlistName)
        {

            // Removes top entry instead of duplicating
            recentlyPlayed.Remove(playlistName);
            lbxRecentlyPlayed.Items.Remove(playlistName);


            // Top recent placement
            recentlyPlayed.Insert(0, playlistName);
            lbxRecentlyPlayed.Items.Insert(0, playlistName);

            

            // I think I put the trim size at the beginning
            while (recentlyPlayed.Count > MaxRecentlyPlayed)
            {
                recentlyPlayed.RemoveAt(recentlyPlayed.Count - 1);
                lbxRecentlyPlayed.Items.RemoveAt(lbxRecentlyPlayed.Items.Count - 1);
            }

            SaveRecentlyPlayed();
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
            string PlaylistName = null;

            // Rewriting since we're only using this one play button for everything
            if (lbxPlaylist.SelectedIndex != -1)
            {
                PlaylistName = lbxPlaylist.SelectedItem.ToString();
            }
            else if (lstFavourites.SelectedIndex != -1)
            {
                PlaylistName = lstFavourites.SelectedItem.ToString();
            }
            else if (lbxRecentlyPlayed.SelectedIndex != -1)
            {
                PlaylistName = lbxRecentlyPlayed.SelectedItem.ToString();
            }
            //If nothing is selected 
            if (PlaylistName == null)
            {
                
                MessageBox.Show("Please select a playlist!");
            }
            else
            {
                MessageBox.Show("You have selected the " + PlaylistName + " playlist, enjoy!");

                AddToRecentlyPlayed(PlaylistName);

                Playlist playlist = new Playlist(loggedInUser, PlaylistName);
                playlist.Show();

                UpdateStatistics();
            }
        }

           

        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            //Input for name of the new playlist
            string PlaylistName = txtNewPlay.Text;                    //Playlist name being saved for use in Playlist.cs
            //Was not sure where the input was supposed to come from

            //User input is added to the listbox
            lbxPlaylist.Items.Add(PlaylistName);

            // last for the current session and disappear again on restart
            SaveUserPlaylists();

            //numbers changed, refresh the statistics
            UpdateStatistics();
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

                
                // Luqmaan: playlist would just reappear again after restarting form
                SaveUserPlaylists();

                // Luqmaan: numbers changed, refresh the statistics
                UpdateStatistics();
            }
            else
            {
                MessageBox.Show("Please select an entry to delete before pressing delete", "Error");
            }
        }

        private void btnAddFavourite_Click(object sender, EventArgs e)
        {
            if (lbxPlaylist.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a playlist to add to favourites.");
                return;
            }

            string selectedPlaylist = lbxPlaylist.SelectedItem.ToString();

            // Don't add it twice if its already a favourite
            if (lstFavourites.Items.Contains(selectedPlaylist))
            {
                MessageBox.Show(selectedPlaylist + " is already in your favourites.");
                return;
            }

            lstFavourites.Items.Add(selectedPlaylist);
            SaveFavourites();

            //refresh the statistics
            UpdateStatistics();

            MessageBox.Show(selectedPlaylist + " added to favourites!");
        }

        private void btnRemoveFavourite_Click(object sender, EventArgs e)
        {
            int index = lstFavourites.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Please select a favourite to remove.");
                return;
            }

            string removedPlaylist = lstFavourites.Items[index].ToString();
            lstFavourites.Items.RemoveAt(index);
            SaveFavourites();

            //  numbers changed, refresh the statistics
            UpdateStatistics();

            MessageBox.Show(removedPlaylist + " removed from favourites.");
        }

        private void dgvSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Open Playlist";
                openFileDialog.Filter = "Playlist files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string playlistFilePath = openFileDialog.FileName;
                    string playlistName = Path.GetFileNameWithoutExtension(playlistFilePath);

                    MessageBox.Show(
                        "You have selected the " + playlistName + " playlist, enjoy!");

                    Playlist playlist = new Playlist(loggedInUser, playlistName);
                    playlist.Show();

                    // FIX: refresh statistics after opening a file-based playlist too
                    UpdateStatistics();
                }
            }
        }
    }
}
