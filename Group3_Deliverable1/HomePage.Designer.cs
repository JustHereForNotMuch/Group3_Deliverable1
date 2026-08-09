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
            ((System.ComponentModel.ISupportInitialize)(this.pbxLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1221, 694);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(203, 42);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(1221, 188);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(203, 42);
            this.btnBrowse.TabIndex = 16;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1087, 153);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(337, 29);
            this.txtSearch.TabIndex = 15;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lblUser.Location = new System.Drawing.Point(626, 154);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(314, 80);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "Hello User";
            // 
            // lbxPlaylist
            // 
            this.lbxPlaylist.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lbxPlaylist.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPlaylist.ForeColor = System.Drawing.Color.White;
            this.lbxPlaylist.FormattingEnabled = true;
            this.lbxPlaylist.ItemHeight = 34;
            this.lbxPlaylist.Items.AddRange(new object[] {
            "Feel Good Pop",
            "Banging Rock",
            "RnB Grooves",
            "Energising Rap"});
            this.lbxPlaylist.Location = new System.Drawing.Point(644, 236);
            this.lbxPlaylist.Name = "lbxPlaylist";
            this.lbxPlaylist.Size = new System.Drawing.Size(780, 446);
            this.lbxPlaylist.TabIndex = 22;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(644, 694);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(203, 42);
            this.btnPlay.TabIndex = 23;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnNewPlaylist
            // 
            this.btnNewPlaylist.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnNewPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnNewPlaylist.Location = new System.Drawing.Point(946, 694);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Size = new System.Drawing.Size(203, 42);
            this.btnNewPlaylist.TabIndex = 24;
            this.btnNewPlaylist.Text = "Create new playlist";
            this.btnNewPlaylist.UseVisualStyleBackColor = false;
            this.btnNewPlaylist.Click += new System.EventHandler(this.btnNewPlaylist_Click);
            // 
            // pbxLeft
            // 
            this.pbxLeft.BackColor = System.Drawing.Color.IndianRed;
            this.pbxLeft.BackgroundImage = global::Group3_Deliverable1.Properties.Resources.Newart;
            this.pbxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLeft.Location = new System.Drawing.Point(12, 59);
            this.pbxLeft.Name = "pbxLeft";
            this.pbxLeft.Size = new System.Drawing.Size(608, 760);
            this.pbxLeft.TabIndex = 25;
            this.pbxLeft.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1436, 851);
            this.Controls.Add(this.btnNewPlaylist);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbxPlaylist);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pbxLeft);
            this.Name = "HomePage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLeft)).EndInit();
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
    }
}