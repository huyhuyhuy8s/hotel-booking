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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ccTop = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnRoomManage = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoomSetup = new Guna.UI2.WinForms.Guna2Button();
            this.btnHotelSetting = new Guna.UI2.WinForms.Guna2Button();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelManager = new System.Windows.Forms.Panel();
            this.ucStatisticRoom1 = new Console.UCStatisticRoom();
            this.panel1.SuspendLayout();
            this.ccTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ccTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 111);
            this.panel1.TabIndex = 0;
            // 
            // ccTop
            // 
            this.ccTop.Controls.Add(this.btnHome);
            this.ccTop.Controls.Add(this.lblWelcome);
            this.ccTop.Controls.Add(this.btnRoomManage);
            this.ccTop.Controls.Add(this.btnRoomSetup);
            this.ccTop.Controls.Add(this.btnHotelSetting);
            this.ccTop.Controls.Add(this.btnReturn);
            this.ccTop.Controls.Add(this.lblBrand);
            this.ccTop.FillColor = System.Drawing.Color.Transparent;
            this.ccTop.Location = new System.Drawing.Point(132, 1);
            this.ccTop.Name = "ccTop";
            this.ccTop.Size = new System.Drawing.Size(1326, 125);
            this.ccTop.TabIndex = 2;
            this.ccTop.Text = "ccTop";
            // 
            // btnHome
            // 
            this.btnHome.BorderRadius = 10;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.btnHome.Location = new System.Drawing.Point(539, 13);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(144, 58);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblWelcome.Location = new System.Drawing.Point(-4, 55);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(322, 30);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome user to Manager Form";
            // 
            // btnRoomManage
            // 
            this.btnRoomManage.BorderRadius = 10;
            this.btnRoomManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoomManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoomManage.FillColor = System.Drawing.Color.White;
            this.btnRoomManage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.btnRoomManage.Location = new System.Drawing.Point(839, 13);
            this.btnRoomManage.Name = "btnRoomManage";
            this.btnRoomManage.Size = new System.Drawing.Size(144, 58);
            this.btnRoomManage.TabIndex = 7;
            this.btnRoomManage.Text = "Room Manage";
            // 
            // btnRoomSetup
            // 
            this.btnRoomSetup.BorderRadius = 10;
            this.btnRoomSetup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomSetup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoomSetup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoomSetup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoomSetup.Enabled = false;
            this.btnRoomSetup.FillColor = System.Drawing.Color.White;
            this.btnRoomSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.btnRoomSetup.Location = new System.Drawing.Point(689, 13);
            this.btnRoomSetup.Name = "btnRoomSetup";
            this.btnRoomSetup.Size = new System.Drawing.Size(144, 58);
            this.btnRoomSetup.TabIndex = 1;
            this.btnRoomSetup.Text = "Room Setup";
            // 
            // btnHotelSetting
            // 
            this.btnHotelSetting.BorderRadius = 10;
            this.btnHotelSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHotelSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHotelSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHotelSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHotelSetting.FillColor = System.Drawing.Color.White;
            this.btnHotelSetting.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotelSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.btnHotelSetting.Location = new System.Drawing.Point(989, 13);
            this.btnHotelSetting.Name = "btnHotelSetting";
            this.btnHotelSetting.Size = new System.Drawing.Size(144, 58);
            this.btnHotelSetting.TabIndex = 3;
            this.btnHotelSetting.Text = "Hotel Setting";
            // 
            // btnReturn
            // 
            this.btnReturn.BorderRadius = 10;
            this.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturn.FillColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.btnReturn.Location = new System.Drawing.Point(1139, 13);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(144, 58);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Back to user";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblBrand.Location = new System.Drawing.Point(-4, 13);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(168, 30);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Travelgoda.com";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelManager);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1584, 650);
            this.panel2.TabIndex = 1;
            // 
            // panelManager
            // 
            this.panelManager.Controls.Add(this.ucStatisticRoom1);
            this.panelManager.Location = new System.Drawing.Point(132, 3);
            this.panelManager.Name = "panelManager";
            this.panelManager.Size = new System.Drawing.Size(1310, 647);
            this.panelManager.TabIndex = 1;
            // 
            // ucStatisticRoom1
            // 
            this.ucStatisticRoom1.End = new System.DateTime(((long)(0)));
            this.ucStatisticRoom1.Location = new System.Drawing.Point(0, 0);
            this.ucStatisticRoom1.Name = "ucStatisticRoom1";
            this.ucStatisticRoom1.Personid = 1;
            this.ucStatisticRoom1.Size = new System.Drawing.Size(1310, 647);
            this.ucStatisticRoom1.Start = new System.DateTime(((long)(0)));
            this.ucStatisticRoom1.TabIndex = 0;
            // 
            // FManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1584, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.panel1.ResumeLayout(false);
            this.ccTop.ResumeLayout(false);
            this.ccTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnRoomSetup;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private Guna.UI2.WinForms.Guna2Button btnHotelSetting;
        private Guna.UI2.WinForms.Guna2ContainerControl ccTop;
        private System.Windows.Forms.Label lblBrand;
        private Guna.UI2.WinForms.Guna2Button btnRoomManage;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelManager;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private UCStatisticRoom ucStatisticRoom1;
    }
}