﻿using System.Drawing.Imaging;

namespace Console
{
    partial class HotelAssignmentForm
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
            this.cbClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblHotline = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.txtHotline = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.titleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panelHotel = new Guna.UI2.WinForms.Guna2Panel();
            this.pbPicture4 = new System.Windows.Forms.PictureBox();
            this.pbPicture5 = new System.Windows.Forms.PictureBox();
            this.pbPicture2 = new System.Windows.Forms.PictureBox();
            this.pbPicture3 = new System.Windows.Forms.PictureBox();
            this.cbStar = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblStar = new System.Windows.Forms.Label();
            this.cbProvince = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.cbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.titleBar.SuspendLayout();
            this.panelHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClose
            // 
            this.cbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.BorderRadius = 5;
            this.cbClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.cbClose.IconColor = System.Drawing.Color.White;
            this.cbClose.Location = new System.Drawing.Point(463, 1);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(45, 29);
            this.cbClose.TabIndex = 23;
            this.cbClose.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // lblTerm
            // 
            this.lblTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTerm.AutoSize = true;
            this.lblTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblTerm.Location = new System.Drawing.Point(117, 803);
            this.lblTerm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(292, 13);
            this.lblTerm.TabIndex = 3;
            this.lblTerm.Text = "By logging in, I agree to the Terms of Use and Privacy Policy";
            // 
            // lblHotline
            // 
            this.lblHotline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHotline.AutoSize = true;
            this.lblHotline.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblHotline.Location = new System.Drawing.Point(56, 404);
            this.lblHotline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHotline.Name = "lblHotline";
            this.lblHotline.Size = new System.Drawing.Size(58, 20);
            this.lblHotline.TabIndex = 22;
            this.lblHotline.Text = "Hotline";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblAddress.Location = new System.Drawing.Point(53, 326);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(112, 20);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "Hotel\'s Address";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblName.Location = new System.Drawing.Point(53, 111);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 20);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name of Hotel";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblDescription.Location = new System.Drawing.Point(52, 485);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 20);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Description";
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblType.Location = new System.Drawing.Point(53, 184);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(99, 20);
            this.lblType.TabIndex = 18;
            this.lblType.Text = "Type of Hotel";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblTitle.Location = new System.Drawing.Point(44, 40);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 40);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Hotel Assignment";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUp.BackColor = System.Drawing.Color.White;
            this.btnSignUp.BorderRadius = 10;
            this.btnSignUp.BorderThickness = 1;
            this.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(55, 734);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(406, 42);
            this.btnSignUp.TabIndex = 14;
            this.btnSignUp.Text = "Sign up your hotel!";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtHotline
            // 
            this.txtHotline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotline.BorderRadius = 10;
            this.txtHotline.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHotline.DefaultText = "";
            this.txtHotline.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHotline.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHotline.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHotline.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHotline.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHotline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHotline.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHotline.Location = new System.Drawing.Point(56, 433);
            this.txtHotline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHotline.Name = "txtHotline";
            this.txtHotline.PasswordChar = '\0';
            this.txtHotline.PlaceholderText = "Hotline";
            this.txtHotline.SelectedText = "";
            this.txtHotline.Size = new System.Drawing.Size(409, 35);
            this.txtHotline.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BorderRadius = 10;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(56, 354);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "Hotel\'s Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(409, 35);
            this.txtAddress.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BorderRadius = 10;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(56, 136);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Name of Hotel";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(409, 35);
            this.txtName.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BorderRadius = 10;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Location = new System.Drawing.Point(52, 513);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "Description";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(409, 52);
            this.txtDescription.TabIndex = 9;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Transparent;
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(509, 105);
            this.titleBar.TabIndex = 24;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel2_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(482, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 18);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "guna2Button1";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelHotel
            // 
            this.panelHotel.BackColor = System.Drawing.Color.Transparent;
            this.panelHotel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelHotel.BorderThickness = 2;
            this.panelHotel.Controls.Add(this.pbPicture4);
            this.panelHotel.Controls.Add(this.pbPicture5);
            this.panelHotel.Controls.Add(this.pbPicture2);
            this.panelHotel.Controls.Add(this.pbPicture3);
            this.panelHotel.Controls.Add(this.cbStar);
            this.panelHotel.Controls.Add(this.lblStar);
            this.panelHotel.Controls.Add(this.cbProvince);
            this.panelHotel.Controls.Add(this.lblProvince);
            this.panelHotel.Controls.Add(this.lblImage);
            this.panelHotel.Controls.Add(this.btnBrowse);
            this.panelHotel.Controls.Add(this.pbPicture);
            this.panelHotel.Controls.Add(this.cbType);
            this.panelHotel.Controls.Add(this.cbClose);
            this.panelHotel.Controls.Add(this.lblTerm);
            this.panelHotel.Controls.Add(this.lblHotline);
            this.panelHotel.Controls.Add(this.lblAddress);
            this.panelHotel.Controls.Add(this.lblName);
            this.panelHotel.Controls.Add(this.lblDescription);
            this.panelHotel.Controls.Add(this.lblType);
            this.panelHotel.Controls.Add(this.lblTitle);
            this.panelHotel.Controls.Add(this.btnSignUp);
            this.panelHotel.Controls.Add(this.txtHotline);
            this.panelHotel.Controls.Add(this.txtAddress);
            this.panelHotel.Controls.Add(this.txtName);
            this.panelHotel.Controls.Add(this.txtDescription);
            this.panelHotel.Controls.Add(this.titleBar);
            this.panelHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHotel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelHotel.Location = new System.Drawing.Point(0, 0);
            this.panelHotel.Margin = new System.Windows.Forms.Padding(2);
            this.panelHotel.Name = "panelHotel";
            this.panelHotel.ShadowDecoration.BorderRadius = 20;
            this.panelHotel.Size = new System.Drawing.Size(509, 852);
            this.panelHotel.TabIndex = 1;
            this.panelHotel.UseTransparentBackground = true;
            // 
            // pbPicture4
            // 
            this.pbPicture4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPicture4.BackColor = System.Drawing.Color.DarkGray;
            this.pbPicture4.Location = new System.Drawing.Point(265, 650);
            this.pbPicture4.Name = "pbPicture4";
            this.pbPicture4.Size = new System.Drawing.Size(95, 55);
            this.pbPicture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture4.TabIndex = 35;
            this.pbPicture4.TabStop = false;
            // 
            // pbPicture5
            // 
            this.pbPicture5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPicture5.BackColor = System.Drawing.Color.DarkGray;
            this.pbPicture5.Location = new System.Drawing.Point(366, 650);
            this.pbPicture5.Name = "pbPicture5";
            this.pbPicture5.Size = new System.Drawing.Size(95, 55);
            this.pbPicture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture5.TabIndex = 34;
            this.pbPicture5.TabStop = false;
            // 
            // pbPicture2
            // 
            this.pbPicture2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPicture2.BackColor = System.Drawing.Color.DarkGray;
            this.pbPicture2.Location = new System.Drawing.Point(266, 583);
            this.pbPicture2.Name = "pbPicture2";
            this.pbPicture2.Size = new System.Drawing.Size(94, 61);
            this.pbPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture2.TabIndex = 33;
            this.pbPicture2.TabStop = false;
            // 
            // pbPicture3
            // 
            this.pbPicture3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPicture3.BackColor = System.Drawing.Color.DarkGray;
            this.pbPicture3.Location = new System.Drawing.Point(366, 583);
            this.pbPicture3.Name = "pbPicture3";
            this.pbPicture3.Size = new System.Drawing.Size(95, 61);
            this.pbPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture3.TabIndex = 32;
            this.pbPicture3.TabStop = false;
            // 
            // cbStar
            // 
            this.cbStar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbStar.BackColor = System.Drawing.Color.Transparent;
            this.cbStar.BorderRadius = 10;
            this.cbStar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStar.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbStar.ItemHeight = 30;
            this.cbStar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbStar.Location = new System.Drawing.Point(265, 207);
            this.cbStar.Name = "cbStar";
            this.cbStar.Size = new System.Drawing.Size(200, 36);
            this.cbStar.TabIndex = 30;
            this.cbStar.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // lblStar
            // 
            this.lblStar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStar.AutoSize = true;
            this.lblStar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblStar.Location = new System.Drawing.Point(262, 184);
            this.lblStar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(94, 20);
            this.lblStar.TabIndex = 31;
            this.lblStar.Text = "Star of Hotel";
            // 
            // cbProvince
            // 
            this.cbProvince.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbProvince.BackColor = System.Drawing.Color.Transparent;
            this.cbProvince.BorderRadius = 10;
            this.cbProvince.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvince.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbProvince.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbProvince.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbProvince.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbProvince.ItemHeight = 30;
            this.cbProvince.Items.AddRange(new object[] {
            "Da Nang",
            "Quang Nam",
            "Vung Tau",
            "Tien Giang",
            "Ha Tinh",
            "Hue",
            "Binh Duong",
            "Dong Nai",
            "HCMC",
            "Ha Noi",
            "Quang Ngai",
            "Quang Tri",
            "Can Tho"});
            this.cbProvince.Location = new System.Drawing.Point(56, 279);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(409, 36);
            this.cbProvince.TabIndex = 29;
            this.cbProvince.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // lblProvince
            // 
            this.lblProvince.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblProvince.Location = new System.Drawing.Point(53, 252);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(115, 20);
            this.lblProvince.TabIndex = 24;
            this.lblProvince.Text = "Hotel\'s Province";
            // 
            // lblImage
            // 
            this.lblImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblImage.Location = new System.Drawing.Point(51, 583);
            this.lblImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(92, 20);
            this.lblImage.TabIndex = 28;
            this.lblImage.Text = "Hotel Image";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.BorderRadius = 10;
            this.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(51, 620);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(86, 85);
            this.btnBrowse.TabIndex = 27;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPicture.BackColor = System.Drawing.Color.DarkGray;
            this.pbPicture.Location = new System.Drawing.Point(148, 583);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(108, 122);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 26;
            this.pbPicture.TabStop = false;
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbType.BackColor = System.Drawing.Color.Transparent;
            this.cbType.BorderRadius = 10;
            this.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbType.ItemHeight = 30;
            this.cbType.Location = new System.Drawing.Point(56, 207);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(200, 36);
            this.cbType.TabIndex = 0;
            this.cbType.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // HotelAssignmentForm
            // 
            this.AcceptButton = this.btnSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(509, 852);
            this.Controls.Add(this.panelHotel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HotelAssignmentForm";
            this.Text = "Form2";
            this.titleBar.ResumeLayout(false);
            this.panelHotel.ResumeLayout(false);
            this.panelHotel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox cbClose;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblHotline;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2TextBox txtHotline;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2Panel titleBar;
        private Guna.UI2.WinForms.Guna2Panel panelHotel;
        private Guna.UI2.WinForms.Guna2ComboBox cbType;
        private System.Windows.Forms.Label lblImage;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Label lblProvince;
        private Guna.UI2.WinForms.Guna2ComboBox cbProvince;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ComboBox cbStar;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.PictureBox pbPicture4;
        private System.Windows.Forms.PictureBox pbPicture5;
        private System.Windows.Forms.PictureBox pbPicture2;
        private System.Windows.Forms.PictureBox pbPicture3;
    }
}