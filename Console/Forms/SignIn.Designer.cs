namespace Console
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.panelSignIn = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.lblForget = new System.Windows.Forms.Label();
            this.cbRemember = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnPasswordShow = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.titleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panelSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPasswordShow)).BeginInit();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSignIn
            // 
            this.panelSignIn.BackColor = System.Drawing.Color.Transparent;
            this.panelSignIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelSignIn.BorderThickness = 2;
            this.panelSignIn.Controls.Add(this.btnSignUp);
            this.panelSignIn.Controls.Add(this.lblForget);
            this.panelSignIn.Controls.Add(this.cbRemember);
            this.panelSignIn.Controls.Add(this.cbClose);
            this.panelSignIn.Controls.Add(this.lblTerm);
            this.panelSignIn.Controls.Add(this.lblPassword);
            this.panelSignIn.Controls.Add(this.lblPhoneNumber);
            this.panelSignIn.Controls.Add(this.btnPasswordShow);
            this.panelSignIn.Controls.Add(this.btnSignIn);
            this.panelSignIn.Controls.Add(this.txtPassword);
            this.panelSignIn.Controls.Add(this.txtPhoneNumber);
            this.panelSignIn.Controls.Add(this.titleBar);
            this.panelSignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSignIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSignIn.Location = new System.Drawing.Point(0, 0);
            this.panelSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.ShadowDecoration.BorderRadius = 20;
            this.panelSignIn.Size = new System.Drawing.Size(513, 567);
            this.panelSignIn.TabIndex = 2;
            this.panelSignIn.UseTransparentBackground = true;
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
            this.btnSignUp.FillColor = System.Drawing.Color.White;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.btnSignUp.Location = new System.Drawing.Point(54, 445);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(406, 42);
            this.btnSignUp.TabIndex = 27;
            this.btnSignUp.Text = "New user? Sign Up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblForget
            // 
            this.lblForget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblForget.AutoSize = true;
            this.lblForget.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblForget.Location = new System.Drawing.Point(357, 334);
            this.lblForget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForget.Name = "lblForget";
            this.lblForget.Size = new System.Drawing.Size(112, 17);
            this.lblForget.TabIndex = 26;
            this.lblForget.Text = "Forget Password?";
            // 
            // cbRemember
            // 
            this.cbRemember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRemember.AutoSize = true;
            this.cbRemember.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.cbRemember.CheckedState.BorderRadius = 0;
            this.cbRemember.CheckedState.BorderThickness = 0;
            this.cbRemember.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbRemember.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRemember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.cbRemember.Location = new System.Drawing.Point(54, 330);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(113, 21);
            this.cbRemember.TabIndex = 25;
            this.cbRemember.Text = "Remember me";
            this.cbRemember.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.cbRemember.UncheckedState.BorderRadius = 0;
            this.cbRemember.UncheckedState.BorderThickness = 0;
            this.cbRemember.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            // 
            // cbClose
            // 
            this.cbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.BorderRadius = 5;
            this.cbClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.cbClose.IconColor = System.Drawing.Color.White;
            this.cbClose.Location = new System.Drawing.Point(467, 1);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(45, 29);
            this.cbClose.TabIndex = 23;
            // 
            // lblTerm
            // 
            this.lblTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTerm.AutoSize = true;
            this.lblTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblTerm.Location = new System.Drawing.Point(116, 519);
            this.lblTerm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(292, 13);
            this.lblTerm.TabIndex = 3;
            this.lblTerm.Text = "By logging in, I agree to the Terms of Use and Privacy Policy";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblPassword.Location = new System.Drawing.Point(49, 242);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(50, 155);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(108, 20);
            this.lblPhoneNumber.TabIndex = 20;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // btnPasswordShow
            // 
            this.btnPasswordShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPasswordShow.Image = ((System.Drawing.Image)(resources.GetObject("btnPasswordShow.Image")));
            this.btnPasswordShow.ImageRotate = 0F;
            this.btnPasswordShow.Location = new System.Drawing.Point(431, 281);
            this.btnPasswordShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnPasswordShow.Name = "btnPasswordShow";
            this.btnPasswordShow.Size = new System.Drawing.Size(15, 10);
            this.btnPasswordShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPasswordShow.TabIndex = 3;
            this.btnPasswordShow.TabStop = false;
            this.btnPasswordShow.Click += new System.EventHandler(this.btnPasswordShow_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignIn.BackColor = System.Drawing.Color.White;
            this.btnSignIn.BorderRadius = 10;
            this.btnSignIn.BorderThickness = 1;
            this.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(54, 380);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(406, 42);
            this.btnSignIn.TabIndex = 14;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
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
            this.txtPassword.Location = new System.Drawing.Point(50, 270);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(409, 35);
            this.txtPassword.TabIndex = 11;
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
            this.txtPhoneNumber.Location = new System.Drawing.Point(50, 182);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderText = "Phone Number";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(409, 35);
            this.txtPhoneNumber.TabIndex = 10;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Transparent;
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Controls.Add(this.lblSubTitle);
            this.titleBar.Controls.Add(this.lblTitle);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(513, 134);
            this.titleBar.TabIndex = 24;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel2_MouseDown);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblSubTitle.Location = new System.Drawing.Point(49, 91);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(358, 20);
            this.lblSubTitle.TabIndex = 25;
            this.lblSubTitle.Text = "To ensure safety, please sign in to access information";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblTitle.Location = new System.Drawing.Point(43, 42);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(112, 40);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Sign In";
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(486, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 18);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "guna2Button1";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SignIn
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(513, 567);
            this.Controls.Add(this.panelSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.panelSignIn.ResumeLayout(false);
            this.panelSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPasswordShow)).EndInit();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelSignIn;
        private Guna.UI2.WinForms.Guna2ControlBox cbClose;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox btnPasswordShow;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2Panel titleBar;
        private System.Windows.Forms.Label lblSubTitle;
        private Guna.UI2.WinForms.Guna2CheckBox cbRemember;
        private System.Windows.Forms.Label lblForget;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}