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


        private void btnAddSong_Click(object sender, EventArgs e)
        {
            try
            {
                //Filtering file types 
                using(OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Audio Files (*.mp3) | *.mp3 ";

                    if(ofd.ShowDialog() == DialogResult.OK)
                    {
                        lstSongs.Items.Add(ofd.FileName);
                        
                        // Changes are saved immediately after adding a song to the playlist
                        SaveSongs();

                    }

                }
             } 
            catch (Exception ex)
            {
                MessageBox.Show("Error adding song: " + ex.Message);
            }
        }

        private void btnPlaySong_Click(object sender, EventArgs e)
        {
           
            //informs user to selct a song to start playing
            if (lstSongs.SelectedItem == null)
            {
                MessageBox.Show ("Please select a song to play.");
                return; 
                
            }
            try
            {
                //Plays selected song
                string selectedSong = lstSongs.SelectedItem.ToString();
                axWindowsMediaPlayer1.URL = selectedSong;
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error playing song :" + ex.Message);

            }
        }

        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            //Tells user to select a song before clicking delete
           if(lstSongs.SelectedItem == null)
            {
                MessageBox.Show("Please select a song to remove.");
                return;
                
            }

           // Remove song from the playlist
            lstSongs.Items.Remove(lstSongs.SelectedItem);

            //Method to save the changes
            SaveSongs();

        }

        private void btnDeletePlaylist_Click(object sender, EventArgs e)
        {
            try
            {
                //Stops current song playing
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                //clears the media player file path
                axWindowsMediaPlayer1.URL = null;

                if(File.Exists(filePath))
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

       
    }
}
