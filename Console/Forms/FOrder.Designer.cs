namespace Console
{
    partial class FOrder
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
            this.panelSignIn = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.cbClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txtRoomId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPersonId = new Guna.UI2.WinForms.Guna2TextBox();
            this.titleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelSignIn.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSignIn
            // 
            this.panelSignIn.BackColor = System.Drawing.Color.Transparent;
            this.panelSignIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelSignIn.BorderThickness = 2;
            this.panelSignIn.Controls.Add(this.lblCheckOut);
            this.panelSignIn.Controls.Add(this.btnCancel);
            this.panelSignIn.Controls.Add(this.lblCheckIn);
            this.panelSignIn.Controls.Add(this.cbClose);
            this.panelSignIn.Controls.Add(this.lblTerm);
            this.panelSignIn.Controls.Add(this.lblRoomId);
            this.panelSignIn.Controls.Add(this.lblPersonId);
            this.panelSignIn.Controls.Add(this.btnUpdate);
            this.panelSignIn.Controls.Add(this.txtRoomId);
            this.panelSignIn.Controls.Add(this.txtPersonId);
            this.panelSignIn.Controls.Add(this.titleBar);
            this.panelSignIn.Controls.Add(this.dtCheckIn);
            this.panelSignIn.Controls.Add(this.dtCheckOut);
            this.panelSignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSignIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSignIn.Location = new System.Drawing.Point(0, 0);
            this.panelSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.ShadowDecoration.BorderRadius = 20;
            this.panelSignIn.Size = new System.Drawing.Size(513, 682);
            this.panelSignIn.TabIndex = 2;
            this.panelSignIn.UseTransparentBackground = true;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblCheckOut.Location = new System.Drawing.Point(49, 401);
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(76, 20);
            this.lblCheckOut.TabIndex = 26;
            this.lblCheckOut.Text = "Check Out";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.btnCancel.Location = new System.Drawing.Point(51, 555);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(406, 42);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Want to cancel your trip? Cancel here for free!";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblCheckIn.Location = new System.Drawing.Point(50, 314);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(64, 20);
            this.lblCheckIn.TabIndex = 25;
            this.lblCheckIn.Text = "Check In";
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
            this.lblTerm.Location = new System.Drawing.Point(116, 629);
            this.lblTerm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(297, 13);
            this.lblTerm.TabIndex = 3;
            this.lblTerm.Text = "By comfirming, I agree to the Terms of Use and Privacy Policy";
            // 
            // lblRoomId
            // 
            this.lblRoomId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomId.AutoSize = true;
            this.lblRoomId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblRoomId.Location = new System.Drawing.Point(49, 234);
            this.lblRoomId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(68, 20);
            this.lblRoomId.TabIndex = 21;
            this.lblRoomId.Text = "Room ID";
            // 
            // lblPersonId
            // 
            this.lblPersonId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(145)))), ((int)(((byte)(180)))));
            this.lblPersonId.Location = new System.Drawing.Point(50, 155);
            this.lblPersonId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(57, 20);
            this.lblPersonId.TabIndex = 20;
            this.lblPersonId.Text = "Your ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(238)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(51, 490);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(406, 42);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update Information";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtRoomId
            // 
            this.txtRoomId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoomId.BorderRadius = 10;
            this.txtRoomId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomId.DefaultText = "";
            this.txtRoomId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomId.Enabled = false;
            this.txtRoomId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomId.Location = new System.Drawing.Point(50, 262);
            this.txtRoomId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.PasswordChar = '*';
            this.txtRoomId.PlaceholderText = "Room ID";
            this.txtRoomId.SelectedText = "";
            this.txtRoomId.Size = new System.Drawing.Size(409, 35);
            this.txtRoomId.TabIndex = 11;
            // 
            // txtPersonId
            // 
            this.txtPersonId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonId.BorderRadius = 10;
            this.txtPersonId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPersonId.DefaultText = "";
            this.txtPersonId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPersonId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPersonId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPersonId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPersonId.Enabled = false;
            this.txtPersonId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPersonId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPersonId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPersonId.Location = new System.Drawing.Point(50, 182);
            this.txtPersonId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.PasswordChar = '\0';
            this.txtPersonId.PlaceholderText = "Your ID";
            this.txtPersonId.SelectedText = "";
            this.txtPersonId.Size = new System.Drawing.Size(409, 35);
            this.txtPersonId.TabIndex = 10;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Transparent;
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
            this.lblSubTitle.Size = new System.Drawing.Size(376, 20);
            this.lblSubTitle.TabIndex = 25;
            this.lblSubTitle.Text = "Please make sure that everything are under your control";
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
            this.lblTitle.Size = new System.Drawing.Size(288, 40);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Manage Your Order";
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtCheckIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtCheckIn.BorderRadius = 10;
            this.dtCheckIn.BorderThickness = 1;
            this.dtCheckIn.Checked = true;
            this.dtCheckIn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtCheckIn.CheckedState.FillColor = System.Drawing.Color.White;
            this.dtCheckIn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dtCheckIn.FillColor = System.Drawing.Color.White;
            this.dtCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtCheckIn.Location = new System.Drawing.Point(50, 341);
            this.dtCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.Size = new System.Drawing.Size(409, 36);
            this.dtCheckIn.TabIndex = 28;
            this.dtCheckIn.Value = new System.DateTime(2024, 4, 4, 13, 14, 12, 307);
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtCheckOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtCheckOut.BorderRadius = 10;
            this.dtCheckOut.BorderThickness = 1;
            this.dtCheckOut.Checked = true;
            this.dtCheckOut.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtCheckOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.dtCheckOut.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dtCheckOut.FillColor = System.Drawing.Color.White;
            this.dtCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtCheckOut.Location = new System.Drawing.Point(50, 428);
            this.dtCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(409, 36);
            this.dtCheckOut.TabIndex = 29;
            this.dtCheckOut.Value = new System.DateTime(2024, 4, 4, 13, 14, 12, 307);
            // 
            // FOrder
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(513, 682);
            this.Controls.Add(this.panelSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FOrder";
            this.Text = "FOrder";
            this.Load += new System.EventHandler(this.FOrder_Load);
            this.panelSignIn.ResumeLayout(false);
            this.panelSignIn.PerformLayout();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelSignIn;
        private Guna.UI2.WinForms.Guna2ControlBox cbClose;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblRoomId;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomId;
        private Guna.UI2.WinForms.Guna2TextBox txtPersonId;
        private Guna.UI2.WinForms.Guna2Panel titleBar;
        private System.Windows.Forms.Label lblSubTitle;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckIn;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckOut;
    }
}