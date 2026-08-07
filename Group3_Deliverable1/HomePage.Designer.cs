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
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(901, 694);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(203, 42);
            this.button5.TabIndex = 20;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(901, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(645, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 29);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hello User";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Items.AddRange(new object[] {
            "Feel Good Pop",
            "Banging Rock",
            "RnB Grooves",
            "Energising Rap"});
            this.listBox1.Location = new System.Drawing.Point(324, 236);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(780, 452);
            this.listBox1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 694);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 42);
            this.button2.TabIndex = 23;
            this.button2.Text = "Play";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(626, 694);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 42);
            this.button3.TabIndex = 24;
            this.button3.Text = "Create new playlist";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 851);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}