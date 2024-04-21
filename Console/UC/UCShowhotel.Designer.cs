namespace Console
{
    partial class UCShowhotel
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
            this.pbPictureHotel = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbNameHotel = new System.Windows.Forms.Label();
            this.lbAddressHotel = new System.Windows.Forms.Label();
            this.lbDescriptionHotel = new System.Windows.Forms.Label();
            this.btShowroom = new Guna.UI2.WinForms.Guna2Button();
            this.panelSeparate = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPictureHotel
            // 
            this.pbPictureHotel.ImageRotate = 0F;
            this.pbPictureHotel.Location = new System.Drawing.Point(32, 30);
            this.pbPictureHotel.Name = "pbPictureHotel";
            this.pbPictureHotel.Size = new System.Drawing.Size(120, 120);
            this.pbPictureHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPictureHotel.TabIndex = 0;
            this.pbPictureHotel.TabStop = false;
            this.pbPictureHotel.Click += new System.EventHandler(this.pbPictureHotel_Click_1);
            // 
            // lbNameHotel
            // 
            this.lbNameHotel.AutoSize = true;
            this.lbNameHotel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNameHotel.ForeColor = System.Drawing.Color.DimGray;
            this.lbNameHotel.Location = new System.Drawing.Point(191, 30);
            this.lbNameHotel.Name = "lbNameHotel";
            this.lbNameHotel.Size = new System.Drawing.Size(50, 20);
            this.lbNameHotel.TabIndex = 1;
            this.lbNameHotel.Text = "label1";
            // 
            // lbAddressHotel
            // 
            this.lbAddressHotel.AutoSize = true;
            this.lbAddressHotel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAddressHotel.ForeColor = System.Drawing.Color.DimGray;
            this.lbAddressHotel.Location = new System.Drawing.Point(191, 80);
            this.lbAddressHotel.Name = "lbAddressHotel";
            this.lbAddressHotel.Size = new System.Drawing.Size(50, 20);
            this.lbAddressHotel.TabIndex = 2;
            this.lbAddressHotel.Text = "label1";
            this.lbAddressHotel.Click += new System.EventHandler(this.lbAddressHotel_Click);
            // 
            // lbDescriptionHotel
            // 
            this.lbDescriptionHotel.AutoSize = true;
            this.lbDescriptionHotel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDescriptionHotel.ForeColor = System.Drawing.Color.DimGray;
            this.lbDescriptionHotel.Location = new System.Drawing.Point(191, 130);
            this.lbDescriptionHotel.Name = "lbDescriptionHotel";
            this.lbDescriptionHotel.Size = new System.Drawing.Size(50, 20);
            this.lbDescriptionHotel.TabIndex = 3;
            this.lbDescriptionHotel.Text = "label1";
            this.lbDescriptionHotel.Click += new System.EventHandler(this.lbDescriptionHotel_Click);
            // 
            // btShowroom
            // 
            this.btShowroom.BorderRadius = 10;
            this.btShowroom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btShowroom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btShowroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btShowroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btShowroom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.btShowroom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btShowroom.ForeColor = System.Drawing.Color.White;
            this.btShowroom.Location = new System.Drawing.Point(879, 30);
            this.btShowroom.Name = "btShowroom";
            this.btShowroom.Size = new System.Drawing.Size(144, 45);
            this.btShowroom.TabIndex = 5;
            this.btShowroom.Text = "Show room";
            this.btShowroom.Click += new System.EventHandler(this.btShowroom_Click);
            // 
            // panelSeparate
            // 
            this.panelSeparate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelSeparate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSeparate.Location = new System.Drawing.Point(0, 185);
            this.panelSeparate.Name = "panelSeparate";
            this.panelSeparate.Size = new System.Drawing.Size(1067, 5);
            this.panelSeparate.TabIndex = 6;
            // 
            // UCShowhotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSeparate);
            this.Controls.Add(this.btShowroom);
            this.Controls.Add(this.lbDescriptionHotel);
            this.Controls.Add(this.lbAddressHotel);
            this.Controls.Add(this.lbNameHotel);
            this.Controls.Add(this.pbPictureHotel);
            this.Name = "UCShowhotel";
            this.Size = new System.Drawing.Size(1067, 190);
            this.Load += new System.EventHandler(this.UCShowhotel_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbPictureHotel;
        private System.Windows.Forms.Label lbNameHotel;
        private System.Windows.Forms.Label lbAddressHotel;
        private System.Windows.Forms.Label lbDescriptionHotel;
        private Guna.UI2.WinForms.Guna2Button btShowroom;
        private System.Windows.Forms.Panel panelSeparate;
    }
}
