namespace Console
{
    partial class FBookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBookingForm));
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.btnAbility4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAbility3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAbility2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAbility1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.ucPeople1 = new Console.UCPeople();
            this.ucTerminal = new Console.UCTerminal();
            this.btnUserManage = new Guna.UI2.WinForms.Guna2Button();
            this.panelTop.SuspendLayout();
            this.guna2ContainerControl1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelTop.Controls.Add(this.guna2ContainerControl1);
            this.panelTop.Controls.Add(this.lblDescription);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1584, 302);
            this.panelTop.TabIndex = 0;
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.Controls.Add(this.btnUserManage);
            this.guna2ContainerControl1.Controls.Add(this.btnSignIn);
            this.guna2ContainerControl1.Controls.Add(this.btnSignUp);
            this.guna2ContainerControl1.Controls.Add(this.btnAbility4);
            this.guna2ContainerControl1.Controls.Add(this.btnAbility3);
            this.guna2ContainerControl1.Controls.Add(this.btnAbility2);
            this.guna2ContainerControl1.Controls.Add(this.btnAbility1);
            this.guna2ContainerControl1.Controls.Add(this.lblBrand);
            this.guna2ContainerControl1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(132, 1);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(1326, 125);
            this.guna2ContainerControl1.TabIndex = 1;
            this.guna2ContainerControl1.Text = "ccTop";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BorderRadius = 10;
            this.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignIn.FillColor = System.Drawing.Color.White;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.btnSignIn.Location = new System.Drawing.Point(1213, 13);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(113, 50);
            this.btnSignIn.TabIndex = 8;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BorderRadius = 10;
            this.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignUp.FillColor = System.Drawing.Color.White;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.btnSignUp.Location = new System.Drawing.Point(1094, 13);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(113, 50);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnAbility4
            // 
            this.btnAbility4.BackColor = System.Drawing.Color.Transparent;
            this.btnAbility4.BorderRadius = 20;
            this.btnAbility4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbility4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbility4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbility4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbility4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnAbility4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbility4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.btnAbility4.Image = ((System.Drawing.Image)(resources.GetObject("btnAbility4.Image")));
            this.btnAbility4.Location = new System.Drawing.Point(344, 55);
            this.btnAbility4.Name = "btnAbility4";
            this.btnAbility4.Size = new System.Drawing.Size(126, 40);
            this.btnAbility4.TabIndex = 6;
            this.btnAbility4.Text = "Transports";
            this.btnAbility4.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // btnAbility3
            // 
            this.btnAbility3.BackColor = System.Drawing.Color.Transparent;
            this.btnAbility3.BorderRadius = 20;
            this.btnAbility3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbility3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbility3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbility3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbility3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnAbility3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbility3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.btnAbility3.Image = ((System.Drawing.Image)(resources.GetObject("btnAbility3.Image")));
            this.btnAbility3.Location = new System.Drawing.Point(217, 55);
            this.btnAbility3.Name = "btnAbility3";
            this.btnAbility3.Size = new System.Drawing.Size(118, 40);
            this.btnAbility3.TabIndex = 5;
            this.btnAbility3.Text = "Coupons";
            this.btnAbility3.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // btnAbility2
            // 
            this.btnAbility2.BackColor = System.Drawing.Color.Transparent;
            this.btnAbility2.BorderRadius = 20;
            this.btnAbility2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbility2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbility2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbility2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbility2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnAbility2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbility2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.btnAbility2.Image = ((System.Drawing.Image)(resources.GetObject("btnAbility2.Image")));
            this.btnAbility2.Location = new System.Drawing.Point(109, 55);
            this.btnAbility2.Name = "btnAbility2";
            this.btnAbility2.Size = new System.Drawing.Size(100, 40);
            this.btnAbility2.TabIndex = 4;
            this.btnAbility2.Text = "Flights";
            this.btnAbility2.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // btnAbility1
            // 
            this.btnAbility1.BackColor = System.Drawing.Color.Transparent;
            this.btnAbility1.BorderRadius = 20;
            this.btnAbility1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbility1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbility1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbility1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbility1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.btnAbility1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbility1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.btnAbility1.Image = ((System.Drawing.Image)(resources.GetObject("btnAbility1.Image")));
            this.btnAbility1.Location = new System.Drawing.Point(7, 55);
            this.btnAbility1.Name = "btnAbility1";
            this.btnAbility1.Size = new System.Drawing.Size(90, 40);
            this.btnAbility1.TabIndex = 3;
            this.btnAbility1.Text = "Stays";
            this.btnAbility1.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblBrand.Location = new System.Drawing.Point(3, 13);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(168, 30);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Travelgoda.com";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(129, 188);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(429, 25);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Search deals on hotels, homes, and much more...";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(124, 143);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(321, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Find your next stay?";
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanel.Location = new System.Drawing.Point(132, 88);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flowPanel.Size = new System.Drawing.Size(1326, 376);
            this.flowPanel.TabIndex = 4;
            this.flowPanel.WrapContents = false;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.flowPanel);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 299);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1584, 462);
            this.panelBottom.TabIndex = 5;
            // 
            // ucPeople1
            // 
            this.ucPeople1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ucPeople1.Location = new System.Drawing.Point(815, 332);
            this.ucPeople1.Name = "ucPeople1";
            this.ucPeople1.Size = new System.Drawing.Size(322, 157);
            this.ucPeople1.TabIndex = 4;
            this.ucPeople1.Visible = false;
            this.ucPeople1.Load += new System.EventHandler(this.ucPeople1_Load);
            // 
            // ucTerminal
            // 
            this.ucTerminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.ucTerminal.Location = new System.Drawing.Point(132, 249);
            this.ucTerminal.Name = "ucTerminal";
            this.ucTerminal.Size = new System.Drawing.Size(1326, 100);
            this.ucTerminal.TabIndex = 3;
            this.ucTerminal.Load += new System.EventHandler(this.ucTerminal1_Load);
            // 
            // btnUserManage
            // 
            this.btnUserManage.BackColor = System.Drawing.Color.Transparent;
            this.btnUserManage.BorderRadius = 10;
            this.btnUserManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserManage.FillColor = System.Drawing.Color.White;
            this.btnUserManage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.btnUserManage.Location = new System.Drawing.Point(966, 13);
            this.btnUserManage.Name = "btnUserManage";
            this.btnUserManage.Size = new System.Drawing.Size(122, 50);
            this.btnUserManage.TabIndex = 9;
            this.btnUserManage.Text = "User Manage";
            this.btnUserManage.Visible = false;
            // 
            // FBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1584, 761);
            this.Controls.Add(this.ucPeople1);
            this.Controls.Add(this.ucTerminal);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FBookingForm";
            this.Text = "SEARCH";
            this.Load += new System.EventHandler(this.FormBooking_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private UCPeople ucPeople1;
        private System.Windows.Forms.Label lblBrand;
        private Guna.UI2.WinForms.Guna2Button btnAbility1;
        private Guna.UI2.WinForms.Guna2Button btnAbility4;
        private Guna.UI2.WinForms.Guna2Button btnAbility3;
        private Guna.UI2.WinForms.Guna2Button btnAbility2;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panelBottom;
        public System.Windows.Forms.FlowLayoutPanel flowPanel;
        private UCTerminal ucTerminal;
        private Guna.UI2.WinForms.Guna2Button btnUserManage;
    }
}