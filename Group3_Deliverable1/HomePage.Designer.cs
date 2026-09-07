namespace Group3_Deliverable1
{
    partial class HomePage
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lbxPlaylist = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnNewPlaylist = new System.Windows.Forms.Button();
            this.pbxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNewPlay = new System.Windows.Forms.TextBox();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.btnAddFavourite = new System.Windows.Forms.Button();
            this.btnRemoveFavourite = new System.Windows.Forms.Button();
            this.lstFavourites = new System.Windows.Forms.ListBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOpenFavourite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1332, 717);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(222, 44);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(1332, 196);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(222, 44);
            this.btnBrowse.TabIndex = 16;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSearch.Location = new System.Drawing.Point(1186, 160);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(368, 31);
            this.txtSearch.TabIndex = 15;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUser.Location = new System.Drawing.Point(682, 160);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(340, 73);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "Hello User";
            // 
            // lbxPlaylist
            // 
            this.lbxPlaylist.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbxPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPlaylist.ForeColor = System.Drawing.Color.White;
            this.lbxPlaylist.FormattingEnabled = true;
            this.lbxPlaylist.ItemHeight = 37;
            this.lbxPlaylist.Items.AddRange(new object[] {
            "Feel Good Pop",
            "Banging Rock",
            "RnB Grooves",
            "Energising Rap"});
            this.lbxPlaylist.Location = new System.Drawing.Point(702, 246);
            this.lbxPlaylist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxPlaylist.Name = "lbxPlaylist";
            this.lbxPlaylist.Size = new System.Drawing.Size(850, 411);
            this.lbxPlaylist.TabIndex = 22;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(1082, 717);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(222, 44);
            this.btnPlay.TabIndex = 23;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnNewPlaylist
            // 
            this.btnNewPlaylist.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNewPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnNewPlaylist.Location = new System.Drawing.Point(702, 760);
            this.btnNewPlaylist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Size = new System.Drawing.Size(222, 44);
            this.btnNewPlaylist.TabIndex = 24;
            this.btnNewPlaylist.Text = "Create new playlist";
            this.btnNewPlaylist.UseVisualStyleBackColor = false;
            this.btnNewPlaylist.Click += new System.EventHandler(this.btnNewPlaylist_Click);
            // 
            // pbxLeft
            // 
            this.pbxLeft.BackColor = System.Drawing.Color.IndianRed;
            this.pbxLeft.BackgroundImage = global::Group3_Deliverable1.Properties.Resources.Otherstarm;
            this.pbxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLeft.Location = new System.Drawing.Point(14, 62);
            this.pbxLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxLeft.Name = "pbxLeft";
            this.pbxLeft.Size = new System.Drawing.Size(664, 792);
            this.pbxLeft.TabIndex = 25;
            this.pbxLeft.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Group3_Deliverable1.Properties.Resources.simple_dark_blue_user_profile_icon_person_symbol_free_vector;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(698, 79);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 96);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // txtNewPlay
            // 
            this.txtNewPlay.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtNewPlay.Location = new System.Drawing.Point(702, 723);
            this.txtNewPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPlay.Name = "txtNewPlay";
            this.txtNewPlay.Size = new System.Drawing.Size(362, 31);
            this.txtNewPlay.TabIndex = 27;
            // 
            // dgvSongs
            // 
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Location = new System.Drawing.Point(164, 354);
            this.dgvSongs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.RowHeadersWidth = 82;
            this.dgvSongs.Size = new System.Drawing.Size(480, 288);
            this.dgvSongs.TabIndex = 28;
            // 
            // btnAddFavourite
            // 
            this.btnAddFavourite.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFavourite.ForeColor = System.Drawing.Color.White;
            this.btnAddFavourite.Location = new System.Drawing.Point(702, 812);
            this.btnAddFavourite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddFavourite.Name = "btnAddFavourite";
            this.btnAddFavourite.Size = new System.Drawing.Size(222, 44);
            this.btnAddFavourite.TabIndex = 29;
            this.btnAddFavourite.Text = "Add to Favourites";
            this.btnAddFavourite.UseVisualStyleBackColor = false;
            this.btnAddFavourite.Click += new System.EventHandler(this.btnAddFavourite_Click);
            // 
            // btnRemoveFavourite
            // 
            this.btnRemoveFavourite.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRemoveFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveFavourite.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFavourite.Location = new System.Drawing.Point(702, 863);
            this.btnRemoveFavourite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveFavourite.Name = "btnRemoveFavourite";
            this.btnRemoveFavourite.Size = new System.Drawing.Size(222, 77);
            this.btnRemoveFavourite.TabIndex = 30;
            this.btnRemoveFavourite.Text = "Remove from Favourites";
            this.btnRemoveFavourite.UseVisualStyleBackColor = false;
            this.btnRemoveFavourite.Click += new System.EventHandler(this.btnRemoveFavourite_Click);
            // 
            // lstFavourites
            // 
            this.lstFavourites.FormattingEnabled = true;
            this.lstFavourites.ItemHeight = 25;
            this.lstFavourites.Location = new System.Drawing.Point(696, 950);
            this.lstFavourites.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstFavourites.Name = "lstFavourites";
            this.lstFavourites.Size = new System.Drawing.Size(924, 279);
            this.lstFavourites.TabIndex = 31;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(979, 761);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(226, 44);
            this.btnOpenFile.TabIndex = 32;
            this.btnOpenFile.Text = "Open Playlist File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnOpenFavourite
            // 
            this.btnOpenFavourite.Location = new System.Drawing.Point(979, 810);
            this.btnOpenFavourite.Name = "btnOpenFavourite";
            this.btnOpenFavourite.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOpenFavourite.Size = new System.Drawing.Size(226, 44);
            this.btnOpenFavourite.TabIndex = 33;
            this.btnOpenFavourite.Text = "Open Favourite";
            this.btnOpenFavourite.UseVisualStyleBackColor = true;
            this.btnOpenFavourite.Click += new System.EventHandler(this.btnOpenFavourite_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2252, 1258);
            this.Controls.Add(this.btnOpenFavourite);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lstFavourites);
            this.Controls.Add(this.btnRemoveFavourite);
            this.Controls.Add(this.btnAddFavourite);
            this.Controls.Add(this.dgvSongs);
            this.Controls.Add(this.txtNewPlay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNewPlaylist);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbxPlaylist);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pbxLeft);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ListBox lbxPlaylist;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNewPlaylist;
        private System.Windows.Forms.PictureBox pbxLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNewPlay;
        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.Button btnAddFavourite;
        private System.Windows.Forms.Button btnRemoveFavourite;
        private System.Windows.Forms.ListBox lstFavourites;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnOpenFavourite;
    }
}