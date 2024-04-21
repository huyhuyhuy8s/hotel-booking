namespace Console
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panelSignUp = new Guna.UI2.WinForms.Guna2Panel();
            this.dtDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbShowPassword = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.titleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.cbClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).BeginInit();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSignUp
            // 
            this.panelSignUp.AutoSize = true;
            this.panelSignUp.BackColor = System.Drawing.Color.Transparent;
            this.panelSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelSignUp.BorderThickness = 2;
            this.panelSignUp.Controls.Add(this.dtDOB);
            this.panelSignUp.Controls.Add(this.lblTerm);
            this.panelSignUp.Controls.Add(this.lblDOB);
            this.panelSignUp.Controls.Add(this.lblPassword);
            this.panelSignUp.Controls.Add(this.lblEmail);
            this.panelSignUp.Controls.Add(this.lblPhoneNumber);
            this.panelSignUp.Controls.Add(this.lblName);
            this.panelSignUp.Controls.Add(this.pbShowPassword);
            this.panelSignUp.Controls.Add(this.btnSignIn);
            this.panelSignUp.Controls.Add(this.btnSignUp);
            this.panelSignUp.Controls.Add(this.txtPassword);
            this.panelSignUp.Controls.Add(this.txtEmail);
            this.panelSignUp.Controls.Add(this.txtPhoneNumber);
            this.panelSignUp.Controls.Add(this.txtName);
            this.panelSignUp.Controls.Add(this.titleBar);
            this.panelSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSignUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSignUp.Location = new System.Drawing.Point(0, 0);
            this.panelSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.ShadowDecoration.BorderRadius = 20;
            this.panelSignUp.Size = new System.Drawing.Size(509, 680);
            this.panelSignUp.TabIndex = 0;
            this.panelSignUp.UseTransparentBackground = true;
            // 
            // dtDOB
            // 
            this.dtDOB.BorderColor = System.Drawing.Color.LightGray;
            this.dtDOB.BorderRadius = 10;
            this.dtDOB.BorderThickness = 1;
            this.dtDOB.Checked = true;
            this.dtDOB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtDOB.CheckedState.FillColor = System.Drawing.Color.White;
            this.dtDOB.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dtDOB.FillColor = System.Drawing.Color.White;
            this.dtDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtDOB.Location = new System.Drawing.Point(51, 446);
            this.dtDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(409, 36);
            this.dtDOB.TabIndex = 25;
            this.dtDOB.Value = new System.DateTime(2024, 3, 28, 2, 36, 16, 947);
            // 
            // lblTerm
            // 
            this.lblTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTerm.AutoSize = true;
            this.lblTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblTerm.Location = new System.Drawing.Point(117, 636);
            this.lblTerm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(289, 13);
            this.lblTerm.TabIndex = 3;
            this.lblTerm.Text = "By signed in, I agree to the Terms of Use and Privacy Policy";
            // 
            // lblDOB
            // 
            this.lblDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblDOB.Location = new System.Drawing.Point(51, 423);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(88, 20);
            this.lblDOB.TabIndex = 22;
            this.lblDOB.Text = "Day of Birth";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblPassword.Location = new System.Drawing.Point(48, 346);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblEmail.Location = new System.Drawing.Point(51, 267);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(51, 193);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(108, 20);
            this.lblPhoneNumber.TabIndex = 19;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblName.Location = new System.Drawing.Point(51, 114);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            // 
            // pbShowPassword
            // 
            this.pbShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbShowPassword.Image")));
            this.pbShowPassword.ImageRotate = 0F;
            this.pbShowPassword.Location = new System.Drawing.Point(428, 381);
            this.pbShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.pbShowPassword.Name = "pbShowPassword";
            this.pbShowPassword.Size = new System.Drawing.Size(15, 10);
            this.pbShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowPassword.TabIndex = 3;
            this.pbShowPassword.TabStop = false;
            this.pbShowPassword.Click += new System.EventHandler(this.pbShowPassword_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignIn.BorderRadius = 10;
            this.btnSignIn.BorderThickness = 1;
            this.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignIn.FillColor = System.Drawing.Color.White;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.btnSignIn.Location = new System.Drawing.Point(55, 572);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(406, 44);
            this.btnSignIn.TabIndex = 15;
            this.btnSignIn.Text = "Already have an accout? Sign in";
            //this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
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
            this.btnSignUp.Location = new System.Drawing.Point(55, 509);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(406, 42);
            this.btnSignUp.TabIndex = 14;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(51, 369);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(409, 35);
            this.txtPassword.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(51, 290);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(409, 35);
            this.txtEmail.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.BorderRadius = 10;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(51, 216);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderText = "Phone Number";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(409, 35);
            this.txtPhoneNumber.TabIndex = 9;
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
            this.txtName.Location = new System.Drawing.Point(51, 141);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Name";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(409, 35);
            this.txtName.TabIndex = 2;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Transparent;
            this.titleBar.Controls.Add(this.cbClose);
            this.titleBar.Controls.Add(this.lblTitle);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(509, 105);
            this.titleBar.TabIndex = 24;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel2_MouseDown);
            // 
            // cbClose
            // 
            this.cbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.BorderRadius = 5;
            this.cbClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.cbClose.IconColor = System.Drawing.Color.White;
            this.cbClose.Location = new System.Drawing.Point(464, 0);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(45, 29);
            this.cbClose.TabIndex = 24;
            this.cbClose.Click += new System.EventHandler(this.cbClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblTitle.Location = new System.Drawing.Point(44, 40);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(121, 40);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Sign up";
            // 
            // SignUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 680);
            this.Controls.Add(this.panelSignUp);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SignUp";
            this.panelSignUp.ResumeLayout(false);
            this.panelSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPassword)).EndInit();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelSignUp;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private Guna.UI2.WinForms.Guna2PictureBox pbShowPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Panel titleBar;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDOB;
        private Guna.UI2.WinForms.Guna2ControlBox cbClose;
    }
}

