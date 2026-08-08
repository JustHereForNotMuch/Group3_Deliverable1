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
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(66, 248);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 23);
            this.btnAddSong.TabIndex = 0;
            this.btnAddSong.Text = "Add track.";
            this.btnAddSong.UseVisualStyleBackColor = true;
            // 
            // btnPlaySong
            // 
            this.btnPlaySong.Location = new System.Drawing.Point(148, 247);
            this.btnPlaySong.Name = "btnPlaySong";
            this.btnPlaySong.Size = new System.Drawing.Size(75, 23);
            this.btnPlaySong.TabIndex = 1;
            this.btnPlaySong.Text = "Play track";
            this.btnPlaySong.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.Location = new System.Drawing.Point(230, 246);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSong.TabIndex = 2;
            this.btnDeleteSong.Text = "Delete track";
            this.btnDeleteSong.UseVisualStyleBackColor = true;
            // 
            // btnDeletePlaylist
            // 
            this.btnDeletePlaylist.Location = new System.Drawing.Point(326, 245);
            this.btnDeletePlaylist.Name = "btnDeletePlaylist";
            this.btnDeletePlaylist.Size = new System.Drawing.Size(101, 23);
            this.btnDeletePlaylist.TabIndex = 3;
            this.btnDeletePlaylist.Text = "Delete Playlist";
            this.btnDeletePlaylist.UseVisualStyleBackColor = true;
            // 
            // lstSongs
            // 
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.Location = new System.Drawing.Point(82, 75);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(345, 160);
            this.lstSongs.TabIndex = 4;
            // 
            // lblPlaylistTitle
            // 
            this.lblPlaylistTitle.AutoSize = true;
            this.lblPlaylistTitle.Location = new System.Drawing.Point(188, 28);
            this.lblPlaylistTitle.Name = "lblPlaylistTitle";
            this.lblPlaylistTitle.Size = new System.Drawing.Size(35, 13);
            this.lblPlaylistTitle.TabIndex = 5;
            this.lblPlaylistTitle.Text = "label1";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(82, 289);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(328, 47);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // Playlist
            // 
            this.ClientSize = new System.Drawing.Size(487, 445);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lblPlaylistTitle);
            this.Controls.Add(this.lstSongs);
            this.Controls.Add(this.btnDeletePlaylist);
            this.Controls.Add(this.btnDeleteSong);
            this.Controls.Add(this.btnPlaySong);
            this.Controls.Add(this.btnAddSong);
            this.Name = "Playlist";
            this.Text = "Playlist";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
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
    }
}