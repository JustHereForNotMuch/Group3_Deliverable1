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
using System.Windows.Forms.VisualStyles;



namespace Group3_Deliverable1
{
    

    public partial class Playlist : Form
    {
        // creates field to stroe info from login and homepage
        private string currentUser;
        private string playlistName;
        private string filePath;
        public Playlist(string username, string selectedPlaylist)
        {
            InitializeComponent();

            currentUser = username;
            playlistName = selectedPlaylist;

            filePath = currentUser + "_" + playlistName + ".txt";


            //class to display song name and filepath seperate
            lstSongs.DisplayMember = "fileName";

        }

        public class song
        {
            public string filePath { get; set; }
            public string fileName { get; set; }

            public override string ToString()
            {
                return fileName;
            }
        }

        // Method to sort the song list alphabetically
        private void SortSongList()
        {
            try
            {
                // Check if there are songs to sort
                if (lstSongs.Items.Count <= 1) return;

                // Extract items from ListBox into a temporary list of strings
                List<string> sortedSongs = new List<string>();
                foreach (var item in lstSongs.Items)
                {
                    sortedSongs.Add(item.ToString());
                }

                // Sort the list alphabetically (A-Z)
                sortedSongs.Sort();

                // Clear the current ListBox items
                lstSongs.Items.Clear();

                // Add the sorted paths back into the ListBox
                foreach (string song in sortedSongs)
                {
                    lstSongs.Items.Add(song);
                }

                // Save the new sorted order immediately to the text file
                SaveSongs();

                MessageBox.Show("Playlist sorted successfully!", "Sorting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sorting playlist: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void Playlist_Load(object sender, EventArgs e)
        {
            //display the playlist name
            lblPlaylistTitle.Text = "Playlist: " + playlistName;
            LoadSongs();

        }

        //Method to load songs from playlist file
        private void LoadSongs()
        {
            lstSongs.Items.Clear();

            if (!File.Exists(filePath)) return;

            try
            {
                //reads the playlist file and adds each song to the listbox
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string song;

                    while ((song = reader.ReadLine()) != null)
                    {
                        lstSongs.Items.Add(song);
                    }
                }

                //Taryn
                // Method to Display count after loading saved playlist

                UpdateTrackCount();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error reading playlist file: " + ex.Message);
            }

        }

        //Method to save the songs added to the playlist to the playlist file

        private void SaveSongs()
        {
            try
            {
                using(StreamWriter writer = new StreamWriter(filePath,false))
                {
                    //iterates through the list box saving all the titles to a file
                    for (int i = 0; i < lstSongs.Items.Count; i++)
                    {
                        writer.WriteLine(lstSongs.Items[i].ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving playlist file: " + ex.Message);
            }
        }
        //Taryn
        //Create a method that returns the number of tracks in the playlist
        private int  GetTrackCount()
        {
            return lstSongs.Items.Count;

        }

        

        public void UpdateTrackCount()
        {
            try
            {
                int total = GetTrackCount();
                lblTrackCount.Text = "Total Tracks :" + total;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error updating track count:" + ex.Message);
            }
        }
        
        private void btnAddSong_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Filtering file types 
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    //select multiple songs at once
                    ofd.Multiselect = true;

                    ofd.Filter = "Audio Files (*.mp3;*.wav;*.flac;*.m4a)|*.mp3;*.wav;*.flac;*.m4a|All Files (*.*)|*.*";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        foreach (string file in ofd.FileNames)
                        {
                            //create object to seperate filepath from song name
                            song newSong = new song
                            {
                                filePath = file,
                                fileName = Path.GetFileName(file)
                            };

                            lstSongs.Items.Add(newSong);
                        }
                        // Changes are saved immediately after adding a song to the playlist
                        SaveSongs();


                        // Taryn
                        // Recalculate and update count when a song is added to the playlist
                        UpdateTrackCount();
                        UpdateLastModified();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding song: " + ex.Message);
            }
        }

        private void btnPlaySong_Click_1(object sender, EventArgs e)
        {
            //informs user to selct a song to start playing
            if (lstSongs.SelectedItem == null)
            {
                MessageBox.Show("Please select a song to play.");
                return;

            }
            else if(lstSongs.SelectedItem is song selectedSong)
            {
                try
                {
                    //Plays selected song
                    string path = selectedSong.filePath;
                    axWindowsMediaPlayer1.URL = path;
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error playing song :" + ex.Message);

                }
            }
            
        }

        private void btnDeleteSong_Click_1(object sender, EventArgs e)
        {
            //Tells user to select a song before clicking delete
            if (lstSongs.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a song to remove.");
                return;

            }

            // Remove song from the playlist
            lstSongs.Items.Remove(lstSongs.SelectedItem);

            //Method to save the changes
            SaveSongs();

            // Taryn
            // Recalculate and update count when song is removed
            UpdateTrackCount();
            UpdateLastModified();  
        }

        private void btnDeletePlaylist_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Stops current song playing
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                //clears the media player file path
                axWindowsMediaPlayer1.URL = null;

                if (File.Exists(filePath))
                {

                    //deletes file path
                    File.Delete(filePath);
                }
                MessageBox.Show("Playlist deleted successfully.");
                this.Close();// exits out of the playlist

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting playlist file:" + ex.Message);
            }
        }

        // Click event handler for your Sort Button
        private void btnSortSongs_Click_1(object sender, EventArgs e)
        {
            SortSongList();
            UpdateLastModified();
        }

        public void UpdateLastModified()   
        {
            try
            {
                if (File.Exists(filePath))
                {
                    DateTime modified = File.GetLastWriteTime(filePath);
                    lblLastModified.Text = "Last Updated: " + modified.ToString("dd MMM yyyy, HH:mm");
                }
                else
                {
                    lblLastModified.Text = "Last Updated: Never";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating last modified date: " + ex.Message);
            }
            //Method showing when last the playlist was modified
        }

        private void Playlist_Load_1(object sender, EventArgs e)
        {
            UpdateLastModified();
            lblPlaylistTitle.Text = "Playlist: " + playlistName;
            LoadSongs();
        }
    }
}
