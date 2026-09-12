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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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

            //Calling the methods from Juan's code             
            LoadUserProfilePicture();   
            LoadPlaylistCover();

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

            //Taryn 2D array
            int trackCount = playlist.Count;
            string[,] songArray = new string[trackCount, 4];

            // Fill 2d array from the playlist 
            for (int i = 0; i < trackCount; i++)
            {
                songArray[i, 0] = playlist[i].Title;
                songArray[i, 1] = playlist[i].Artist;
                songArray[i, 2] = playlist[i].Album;
                songArray[i, 3] = playlist[i].Duration;
            }


            // Display in DataGridView
            dgvSongs.Rows.Clear();

            for (int r = 0; r < songArray.GetLength(0); r++)
            {
                dgvSongs.Rows.Add(
                    songArray[r, 0],
                    songArray[r, 1],
                    songArray[r, 2],
                    songArray[r, 3]
                    );
            }

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
                //lblTotalFavourites.Text = "Favourite Playlists: " + totalFavourites;
                //Not supposed to be there so changed it since we have a recents lbx

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
        private void LoadUserProfilePicture()
        {
            try
            {
                // Searches for any common image extension matching the username
                string[] extensions = { ".jpg", ".jpeg", ".png", ".bmp" };

                for (int i = 0; i < extensions.Length; i++)
                {
                    string userProfilePic = loggedInUser + extensions[i];
                    if (File.Exists(userProfilePic))
                    {
                        byte[] imageBytes = File.ReadAllBytes(userProfilePic);
                        // Using a stream prevents file-locking bugs in Windows Forms
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            picHomeUserProfile.Image = new Bitmap(ms);
                        }
                        picHomeUserProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                        return; // Image found and loaded, exit the method early
                    }
                }
                picHomeUserProfile.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile picture: " + ex.Message);
            }
        }

        private void btnUploadProfilePic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // This line restricts the view to image files only, making it easy to search
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK) // Triggers when user selects a file and hits Open
                {
                    string extension = Path.GetExtension(ofd.FileName);
                    string targetPath = loggedInUser + extension;

                    //remove old profile photo
                    string[] extensions = { ".jpg", ".jpeg", ".png", ".bmp" };
                    foreach (string ext in extensions)
                    {
                        string oldFile = loggedInUser + ext;
                        if (File.Exists(oldFile) && !oldFile.Equals(targetPath, StringComparison.OrdinalIgnoreCase))
                        {
                            File.Delete(oldFile);
                        }
                    }

                    picHomeUserProfile.Image = null; // Clear old image out of memory
                    File.Copy(ofd.FileName, targetPath, true); // Save to project files

                    LoadUserProfilePicture(); // Re-read and show the new picture
                    MessageBox.Show("Profile picture updated successfully!");
                }
            }
        }
        private string GetPlaylistCoverPath()
        {
            string selectedPlaylistName = lbxPlaylist.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedPlaylistName))
                return null;// Wasn't working so added this

            // Saves the image as "Username_PlaylistName_Cover.jpg" (or .png/etc.)
            return loggedInUser + "_" + selectedPlaylistName + "_Cover.jpg";
        }

        // Method to load the playlist cover image directly from the disk
        private void LoadPlaylistCover()
        {
            try
            {
                string coverPath = GetPlaylistCoverPath();

                if (coverPath != null && File.Exists(coverPath))
                {
                    // Using a stream prevents Windows Forms from locking the file on your disk
                    using (FileStream fs = new FileStream(coverPath, FileMode.Open, FileAccess.Read))
                    {
                        pbxLeft.Image = Image.FromStream(fs);
                    }
                    pbxLeft.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbxLeft.Image = null; // Clear if no cover photo exists yet
                }
            }
            catch
            {
                pbxLeft.Image = null;
            }
        }

        private void btnAddChangeAlbumCover_Click(object sender, EventArgs e)
        {
            if (lbxPlaylist.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a playlist from the list first to assign a cover picture.");
            }

            try
            {
                string selectedPlaylistName = lbxPlaylist.SelectedItem.ToString();
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string targetPath = GetPlaylistCoverPath();

                        // 1. Release the image from the UI so Windows lets us overwrite it
                        pbxLeft.Image = null;

                        // 2. Direct copy overwriting any old picture file
                        File.Copy(ofd.FileName, targetPath, true);

                        // 3. Immediately reload the new image into the UI
                        LoadPlaylistCover();
                        MessageBox.Show("Playlist cover updated successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating cover picture: " + ex.Message);
            }
        }

        private void lblTotalFavourites_Click(object sender, EventArgs e)
        {

        }
    }
}
