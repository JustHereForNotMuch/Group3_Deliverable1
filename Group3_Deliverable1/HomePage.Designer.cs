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
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(901, 694);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(203, 42);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(901, 188);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(203, 42);
            this.btnBrowse.TabIndex = 16;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(767, 153);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(337, 29);
            this.txtSearch.TabIndex = 15;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(319, 163);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(192, 42);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "Hello User";
            // 
            // lbxPlaylist
            // 
            this.lbxPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPlaylist.FormattingEnabled = true;
            this.lbxPlaylist.ItemHeight = 32;
            this.lbxPlaylist.Items.AddRange(new object[] {
            "Feel Good Pop",
            "Banging Rock",
            "RnB Grooves",
            "Energising Rap"});
            this.lbxPlaylist.Location = new System.Drawing.Point(324, 236);
            this.lbxPlaylist.Name = "lbxPlaylist";
            this.lbxPlaylist.Size = new System.Drawing.Size(780, 452);
            this.lbxPlaylist.TabIndex = 22;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(324, 694);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(203, 42);
            this.btnPlay.TabIndex = 23;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnNewPlaylist
            // 
            this.btnNewPlaylist.Location = new System.Drawing.Point(626, 694);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Size = new System.Drawing.Size(203, 42);
            this.btnNewPlaylist.TabIndex = 24;
            this.btnNewPlaylist.Text = "Create new playlist";
            this.btnNewPlaylist.UseVisualStyleBackColor = true;
            this.btnNewPlaylist.Click += new System.EventHandler(this.btnNewPlaylist_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 851);
            this.Controls.Add(this.btnNewPlaylist);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lbxPlaylist);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblUser);
            this.Name = "HomePage";
            this.Text = "HomePage";
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
    }
}