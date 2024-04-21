namespace Console.UC
{
    partial class UCExploreValue
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblHotels = new Console.GrowLabel();
            this.lblLocation = new Console.GrowLabel();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2ContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PictureBox1.Image = global::Console.Properties.Resources.color_palette_2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(163, 118);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblHotels
            // 
            this.lblHotels.AutoSize = true;
            this.lblHotels.BackColor = System.Drawing.Color.Transparent;
            this.lblHotels.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblHotels.Location = new System.Drawing.Point(5, 160);
            this.lblHotels.Name = "lblHotels";
            this.lblHotels.Size = new System.Drawing.Size(69, 20);
            this.lblHotels.TabIndex = 2;
            this.lblHotels.Text = "12 hotels";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblLocation.Location = new System.Drawing.Point(5, 132);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(77, 21);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Da Nang";
            this.lblLocation.Click += new System.EventHandler(this.lblLocation_Click);
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ContainerControl1.BorderRadius = 10;
            this.guna2ContainerControl1.Controls.Add(this.lblHotels);
            this.guna2ContainerControl1.Controls.Add(this.lblLocation);
            this.guna2ContainerControl1.Controls.Add(this.guna2PictureBox1);
            this.guna2ContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(163, 190);
            this.guna2ContainerControl1.TabIndex = 3;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            this.guna2ContainerControl1.UseTransparentBackground = true;
            // 
            // UCExploreValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2ContainerControl1);
            this.Name = "UCExploreValue";
            this.Size = new System.Drawing.Size(163, 190);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public GrowLabel lblLocation;
        public GrowLabel lblHotels;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
    }
}
