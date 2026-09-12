namespace Group3_Deliverable1
{
    partial class Playlist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlist));
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnPlaySong = new System.Windows.Forms.Button();
            this.btnDeleteSong = new System.Windows.Forms.Button();
            this.btnDeletePlaylist = new System.Windows.Forms.Button();
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.lblPlaylistTitle = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.lblTrackCount = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
=======
            this.btnSortSongs = new System.Windows.Forms.Button();
            this.lblLastModified = new System.Windows.Forms.Label();
<<<<<<< HEAD
>>>>>>> 89f5a129de53b8150fffbbc55f2d9a2b405f50b1
=======
            this.picUserProfile = new System.Windows.Forms.PictureBox();
            this.btnUploadProfilePic = new System.Windows.Forms.Button();
>>>>>>> fed67abc79314fef9964976e07ac96b41a42c856
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSong
            // 
            this.btnAddSong.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSong.ForeColor = System.Drawing.Color.White;
            this.btnAddSong.Location = new System.Drawing.Point(147, 422);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(148, 39);
            this.btnAddSong.TabIndex = 0;
            this.btnAddSong.Text = "Add track.";
            this.btnAddSong.UseVisualStyleBackColor = false;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click_1);
            // 
            // btnPlaySong
            // 
            this.btnPlaySong.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPlaySong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaySong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaySong.ForeColor = System.Drawing.Color.White;
            this.btnPlaySong.Location = new System.Drawing.Point(455, 423);
            this.btnPlaySong.Name = "btnPlaySong";
            this.btnPlaySong.Size = new System.Drawing.Size(148, 40);
            this.btnPlaySong.TabIndex = 1;
            this.btnPlaySong.Text = "Play track";
            this.btnPlaySong.UseVisualStyleBackColor = false;
            this.btnPlaySong.Click += new System.EventHandler(this.btnPlaySong_Click_1);
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeleteSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSong.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSong.Location = new System.Drawing.Point(301, 422);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(148, 41);
            this.btnDeleteSong.TabIndex = 2;
            this.btnDeleteSong.Text = "Delete track";
            this.btnDeleteSong.UseVisualStyleBackColor = false;
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click_1);
            // 
            // btnDeletePlaylist
            // 
            this.btnDeletePlaylist.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeletePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlaylist.ForeColor = System.Drawing.Color.White;
            this.btnDeletePlaylist.Location = new System.Drawing.Point(301, 469);
            this.btnDeletePlaylist.Name = "btnDeletePlaylist";
            this.btnDeletePlaylist.Size = new System.Drawing.Size(174, 42);
            this.btnDeletePlaylist.TabIndex = 3;
            this.btnDeletePlaylist.Text = "Delete Playlist";
            this.btnDeletePlaylist.UseVisualStyleBackColor = false;
            this.btnDeletePlaylist.Click += new System.EventHandler(this.btnDeletePlaylist_Click_1);
            // 
            // lstSongs
            // 
            this.lstSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSongs.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.ItemHeight = 25;
            this.lstSongs.Location = new System.Drawing.Point(148, 127);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(411, 204);
            this.lstSongs.TabIndex = 4;
            // 
            // lblPlaylistTitle
            // 
            this.lblPlaylistTitle.AutoSize = true;
            this.lblPlaylistTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaylistTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistTitle.ForeColor = System.Drawing.Color.White;
            this.lblPlaylistTitle.Location = new System.Drawing.Point(148, 80);
            this.lblPlaylistTitle.Name = "lblPlaylistTitle";
            this.lblPlaylistTitle.Size = new System.Drawing.Size(98, 32);
            this.lblPlaylistTitle.TabIndex = 5;
            this.lblPlaylistTitle.Text = "label1";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // lblTrackCount
            // 
            this.lblTrackCount.Location = new System.Drawing.Point(646, 54);
            this.lblTrackCount.Name = "lblTrackCount";
            this.lblTrackCount.Size = new System.Drawing.Size(193, 30);
            this.lblTrackCount.TabIndex = 7;
            this.lblTrackCount.Text = "LABEL 2";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(147, 344);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(403, 72);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            // 
<<<<<<< HEAD
=======
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // lblTrackCount
            // 
            this.lblTrackCount.Location = new System.Drawing.Point(577, 197);
            this.lblTrackCount.Name = "lblTrackCount";
            this.lblTrackCount.Size = new System.Drawing.Size(193, 30);
            this.lblTrackCount.TabIndex = 7;
            this.lblTrackCount.Text = "LABEL 2";
            // 
            // btnSortSongs
            // 
            this.btnSortSongs.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSortSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortSongs.ForeColor = System.Drawing.Color.White;
            this.btnSortSongs.Location = new System.Drawing.Point(147, 469);
            this.btnSortSongs.Name = "btnSortSongs";
            this.btnSortSongs.Size = new System.Drawing.Size(148, 42);
            this.btnSortSongs.TabIndex = 8;
            this.btnSortSongs.Text = "Sort ";
            this.btnSortSongs.UseVisualStyleBackColor = false;
            this.btnSortSongs.Click += new System.EventHandler(this.btnSortSongs_Click_1);
            // 
            // lblLastModified
            // 
            this.lblLastModified.Location = new System.Drawing.Point(577, 255);
            this.lblLastModified.Name = "lblLastModified";
            this.lblLastModified.Size = new System.Drawing.Size(193, 30);
            this.lblLastModified.TabIndex = 9;
            this.lblLastModified.Text = "LABEL 3";
            // 
<<<<<<< HEAD
>>>>>>> 89f5a129de53b8150fffbbc55f2d9a2b405f50b1
=======
            // picUserProfile
            // 
            this.picUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUserProfile.Image = global::Group3_Deliverable1.Properties.Resources.simple_dark_blue_user_profile_icon_person_symbol_free_vector;
            this.picUserProfile.Location = new System.Drawing.Point(18, 24);
            this.picUserProfile.Name = "picUserProfile";
            this.picUserProfile.Size = new System.Drawing.Size(63, 61);
            this.picUserProfile.TabIndex = 10;
            this.picUserProfile.TabStop = false;
            // 
            // btnUploadProfilePic
            // 
            this.btnUploadProfilePic.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUploadProfilePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadProfilePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadProfilePic.ForeColor = System.Drawing.Color.White;
            this.btnUploadProfilePic.Location = new System.Drawing.Point(6, 91);
            this.btnUploadProfilePic.Name = "btnUploadProfilePic";
            this.btnUploadProfilePic.Size = new System.Drawing.Size(108, 42);
            this.btnUploadProfilePic.TabIndex = 11;
            this.btnUploadProfilePic.Text = "Change";
            this.btnUploadProfilePic.UseVisualStyleBackColor = false;
            this.btnUploadProfilePic.Click += new System.EventHandler(this.btnUploadProfilePic_Click);
            // 
>>>>>>> fed67abc79314fef9964976e07ac96b41a42c856
            // Playlist
            // 
            this.BackgroundImage = global::Group3_Deliverable1.Properties.Resources.Otherstarm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 536);
            this.Controls.Add(this.btnUploadProfilePic);
            this.Controls.Add(this.picUserProfile);
            this.Controls.Add(this.lblLastModified);
            this.Controls.Add(this.btnSortSongs);
            this.Controls.Add(this.lblTrackCount);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lblPlaylistTitle);
            this.Controls.Add(this.lstSongs);
            this.Controls.Add(this.btnDeletePlaylist);
            this.Controls.Add(this.btnDeleteSong);
            this.Controls.Add(this.btnPlaySong);
            this.Controls.Add(this.btnAddSong);
            this.Name = "Playlist";
            this.Text = "Playlist";
            this.Load += new System.EventHandler(this.Playlist_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnPlaySong;
        private System.Windows.Forms.Button btnDeleteSong;
        private System.Windows.Forms.Button btnDeletePlaylist;
        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.Label lblPlaylistTitle;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label lblTrackCount;
        private System.Windows.Forms.Button btnSortSongs;
        private System.Windows.Forms.Label lblLastModified;
        private System.Windows.Forms.PictureBox picUserProfile;
        private System.Windows.Forms.Button btnUploadProfilePic;
    }
}