namespace Console
{
    partial class FManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.btnHotelSetup = new Guna.UI2.WinForms.Guna2Button();
            this.pbHotel = new System.Windows.Forms.PictureBox();
            this.btnRoomSetup = new Guna.UI2.WinForms.Guna2Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucRoomSetup1 = new Console.ucRoomSetup();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.btnHotelSetup);
            this.panel1.Controls.Add(this.pbHotel);
            this.panel1.Controls.Add(this.btnRoomSetup);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 111);
            this.panel1.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.BorderRadius = 10;
            this.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.btnReturn.Location = new System.Drawing.Point(1045, 16);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(210, 78);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Back to user";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnHotelSetup
            // 
            this.btnHotelSetup.BorderRadius = 10;
            this.btnHotelSetup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHotelSetup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHotelSetup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHotelSetup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHotelSetup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnHotelSetup.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotelSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.btnHotelSetup.Location = new System.Drawing.Point(774, 16);
            this.btnHotelSetup.Name = "btnHotelSetup";
            this.btnHotelSetup.Size = new System.Drawing.Size(210, 78);
            this.btnHotelSetup.TabIndex = 3;
            this.btnHotelSetup.Text = "Hotel Setup";
            // 
            // pbHotel
            // 
            this.pbHotel.Image = ((System.Drawing.Image)(resources.GetObject("pbHotel.Image")));
            this.pbHotel.Location = new System.Drawing.Point(275, 12);
            this.pbHotel.Name = "pbHotel";
            this.pbHotel.Size = new System.Drawing.Size(168, 86);
            this.pbHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHotel.TabIndex = 2;
            this.pbHotel.TabStop = false;
            // 
            // btnRoomSetup
            // 
            this.btnRoomSetup.BorderRadius = 10;
            this.btnRoomSetup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomSetup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomSetup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoomSetup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoomSetup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnRoomSetup.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.btnRoomSetup.Location = new System.Drawing.Point(503, 16);
            this.btnRoomSetup.Name = "btnRoomSetup";
            this.btnRoomSetup.Size = new System.Drawing.Size(210, 78);
            this.btnRoomSetup.TabIndex = 1;
            this.btnRoomSetup.Text = "Room Setup";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(127, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(86, 86);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucRoomSetup1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1584, 650);
            this.panel2.TabIndex = 1;
            // 
            // ucRoomSetup1
            // 
            this.ucRoomSetup1.BackColor = System.Drawing.Color.White;
            this.ucRoomSetup1.Location = new System.Drawing.Point(92, 0);
            this.ucRoomSetup1.Name = "ucRoomSetup1";
            this.ucRoomSetup1.Size = new System.Drawing.Size(1391, 647);
            this.ucRoomSetup1.TabIndex = 0;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1584, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2Button btnRoomSetup;
        private System.Windows.Forms.Panel panel2;
        private ucRoomSetup ucRoomSetup1;
        private System.Windows.Forms.PictureBox pbHotel;
        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private Guna.UI2.WinForms.Guna2Button btnHotelSetup;
    }
}